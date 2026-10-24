using System.Collections.Generic;
using UnityEngine;

namespace WeaponTest
{
    public enum WeaponBehavior { Projectile, Shotgun, Homing, Boomerang, Beam, Chain, AreaAtTarget, Mine, Aura }

    /// <summary>
    /// Fires one weapon from WeaponDb. Added at runtime to the spawned weapon prefab.
    /// Behaviour is picked from the bullet prefab's original class; numbers come from the Weapon data.
    /// Level scaling (base + growUp * (level - 1)) is a guess: the original formulas were not recoverable.
    /// </summary>
    public class WeaponTestGun : MonoBehaviour
    {
        private const string LogTag = "[WeaponTestGun]";

        public Weapon Data { get; private set; }
        public BulletType Bullet { get; private set; }
        public WeaponBehavior Behavior { get; private set; }
        public int Level { get; private set; } = 1;
        public int Damage { get; private set; }
        public float AttackInterval { get; private set; }
        public float ReloadTime { get; private set; }
        public int Magazine { get; private set; }
        public int ShotsLeft { get; private set; }
        public int ShotsFired { get; private set; }
        public bool IsReloading => !Continuous && Time.time < _reloadUntil;

        /// <summary>Sandbox mode: no magazine/reload and at most MaxContinuousInterval between shots.</summary>
        public static bool Continuous = true;
        private const float MaxContinuousInterval = 0.35f;
        private const float MaxProjectileSpeed = 150f;
        private const float MaxProjectileLife = 4f;

        // WeaponJoin's static constructor hashes "Shoot" (string literal recovered from the ISIL dump).
        private static readonly int ShootHash = Animator.StringToHash("Shoot");

        // A plain object reference (not a delegate) so it survives a domain reload while playing.
        private WeaponTestPlayer _player;
        private Transform _owner;
        private List<Transform> _launchPoints;
        private List<ParticleSystem> _muzzles;
        private readonly List<Animator> _shootAnimators = new List<Animator>();
        private float _nextShot;
        private float _reloadUntil;
        private GameObject _aura;

        public void Init(Weapon data, BulletType bullet, WeaponTestPlayer player, int level)
        {
            Data = data;
            Bullet = bullet;
            _player = player;
            _owner = player.transform;
            Behavior = ResolveBehavior(bullet.BulletPrefab, bullet);

            var join = GetComponent<WeaponJoin>();
            _launchPoints = join != null && join.LaunchPoint != null && join.LaunchPoint.Count > 0 ? join.LaunchPoint : new List<Transform> { transform };
            _muzzles = join != null ? join.MuzzleEffects : null;
            if (join == null)
                Debug.LogWarning($"{LogTag} {data.WeaponName}: weapon prefab has no WeaponJoin, firing from its root.", this);
            else
            {
                AddShootAnimator(join.WeaponAnimator);
                AddShootAnimator(join.WeaponAnimator2);
            }

            SetLevel(level);
        }

        public void SetLevel(int level)
        {
            Level = Mathf.Clamp(level, 1, Mathf.Max(1, (int)Data.MaxWeaponLevel));
            int n = Level - 1;
            Damage = Mathf.Max(1, Mathf.RoundToInt(Data.WeaponDamage + Data.WeaponDamageGrowUp * n));
            AttackInterval = Mathf.Max(0.05f, Data.AttackRate - Data.AttackRateGrowUp * n);
            ReloadTime = Mathf.Max(0.1f, Data.ReloadTime - Data.ReloadTimeGrowUp * n);
            Magazine = Mathf.Max(1, Mathf.RoundToInt(Data.BaseMagazine + Data.BaseMagazineGrowUp * n));
            ShotsLeft = Magazine;
            _reloadUntil = 0f;

            if (Behavior == WeaponBehavior.Aura) SpawnAura();
        }

        private void AddShootAnimator(Animator animator)
        {
            if (animator == null || animator.runtimeAnimatorController == null) return;
            foreach (var p in animator.parameters)
                if (p.nameHash == ShootHash && p.type == AnimatorControllerParameterType.Trigger)
                {
                    _shootAnimators.Add(animator);
                    return;
                }
        }

        private void OnDestroy()
        {
            if (_aura != null) Destroy(_aura);
        }

        /// <summary>Called every frame by the player while the fire button is held (or auto-fire is on).</summary>
        public void TickFire()
        {
            if (Behavior == WeaponBehavior.Aura || Time.time < _nextShot || IsReloading) return;

            FireOnce();
            ShotsFired++;
            _nextShot = Time.time + (Continuous ? Mathf.Min(AttackInterval, MaxContinuousInterval) : AttackInterval);
            if (Continuous) return;
            if (--ShotsLeft <= 0)
            {
                _reloadUntil = Time.time + ReloadTime;
                ShotsLeft = Magazine;
            }
        }

        private void FireOnce()
        {
            Vector3 aim = _player.AimDirection;
            if (_muzzles != null)
                foreach (var m in _muzzles) if (m != null) m.Play(true);
            foreach (var a in _shootAnimators) a.SetTrigger(ShootHash);

            switch (Behavior)
            {
                case WeaponBehavior.AreaAtTarget: FireArea(aim); return;
                case WeaponBehavior.Chain: FireChain(); return;
                case WeaponBehavior.Mine: FireMine(aim); return;
            }

            foreach (var lp in _launchPoints)
            {
                Vector3 pos = lp.position;
                // Converge on the aim point: launch points sit metres to the side of the mech's centre,
                // so firing parallel to the centre's aim line misses the target by that offset.
                Vector3 toAim = _player.AimPoint - pos; toAim.y = 0f;
                Quaternion rot = Quaternion.LookRotation(toAim.sqrMagnitude > 4f ? toAim : aim, Vector3.up);
                switch (Behavior)
                {
                    case WeaponBehavior.Beam:
                        float length = Bullet.BulletPrefab is LaserBeam lb && lb.MaxLength > 0f ? lb.MaxLength : Bullet.BulletPrefab is FlamethrowerBullet ? 6f : 12f;
                        SpawnZone(pos, rot, ZoneKind.Beam, 0.6f, length, 0.12f, Mathf.Max(0.3f, AttackInterval), lp, _player);
                        break;
                    case WeaponBehavior.Shotgun:
                        for (int i = -2; i <= 2; i++)
                            SpawnProjectile(pos, rot * Quaternion.Euler(0f, i * 9f, 0f), ProjectileMotion.Straight, 0f);
                        break;
                    case WeaponBehavior.Homing:
                        float r = Bullet.BulletPrefab is MissileDamage md && md.DamageRadius > 0f ? md.DamageRadius : 2f;
                        SpawnProjectile(pos, rot * Quaternion.Euler(0f, Random.Range(-35f, 35f), 0f), ProjectileMotion.Homing, r);
                        break;
                    case WeaponBehavior.Boomerang:
                        SpawnProjectile(pos, rot, ProjectileMotion.Boomerang, 0f);
                        break;
                    default:
                        float blast = Bullet.BulletPrefab is ExplosiveBullet eb ? (eb.DamageRadius > 0f ? eb.DamageRadius : 2.5f)
                                    : Bullet.BulletPrefab is FragmentedBullet ? 2.5f : 0f;
                        SpawnProjectile(pos, rot, ProjectileMotion.Straight, blast);
                        break;
                }
            }
        }

        private void SpawnProjectile(Vector3 pos, Quaternion rot, ProjectileMotion motion, float explosionRadius)
        {
            var go = SpawnBulletPrefab(pos, rot, null);
            float speed = 25f, life = 2.5f;
            switch (Bullet.BulletPrefab)
            {
                case global::Bullet b:
                    if (b.Speed > 0f) speed = b.Speed;
                    if (b.LifeTime > 0f) life = b.LifeTime;
                    break;
                case BoomerangBullet bb:
                    if (bb.Speed > 0f) speed = bb.Speed;
                    life = bb.LifeTime > 0f ? bb.LifeTime : 3f;
                    break;
                case ExplosiveBullet eb:
                    if (eb.Speed > 0f) speed = eb.Speed;
                    if (eb.LifeTime > 0f) life = eb.LifeTime;
                    break;
            }
            // Some prefabs store a physics force here (Grenade launcher: 1500), not m/s; keep shots visible and in the arena.
            speed = Mathf.Min(speed, MaxProjectileSpeed);
            life = Mathf.Min(life, MaxProjectileLife);
            if (motion == ProjectileMotion.Homing) speed = Mathf.Min(speed, 18f);
            go.AddComponent<WeaponTestProjectile>().Init(motion, Damage, speed, life, Data.PassEnemyCount, Data.RicochetCount, explosionRadius, _owner);
        }

        private void FireArea(Vector3 aim)
        {
            var target = WeaponTestTarget.Nearest(_owner.position, 18f);
            Vector3 pos = target != null ? target.transform.position : _owner.position + aim * 8f;
            pos.y = 0f;
            SpawnZone(pos, Quaternion.identity, ZoneKind.Area, 3f, 0f, 0.5f, 2f, null);
        }

        // Sandbox targets never walk onto mines, so mines are thrown near the closest target instead of dropped underfoot.
        private void FireMine(Vector3 aim)
        {
            var target = WeaponTestTarget.Nearest(_owner.position, 15f);
            Vector3 pos = target != null
                ? target.transform.position + new Vector3(Random.Range(-1.5f, 1.5f), 0f, Random.Range(-1.5f, 1.5f))
                : _owner.position + aim * 6f;
            pos.y = 0f;
            SpawnZone(pos, Quaternion.identity, ZoneKind.Mine, 1.2f, 0f, 0f, 20f, null);
        }

        private void FireChain()
        {
            const int maxHops = 5;
            var hit = new List<WeaponTestTarget>();
            Vector3 from = _launchPoints[0].position;
            var current = WeaponTestTarget.Nearest(from, 15f);
            while (current != null && hit.Count < maxHops)
            {
                hit.Add(current);
                current.TakeDamage(Damage);
                Destroy(SpawnBulletPrefab(current.transform.position, Quaternion.identity, null), 0.5f);
                current = NearestExcluding(current.transform.position, 8f, hit);
            }
            if (hit.Count > 0) WeaponTestHud.DrawChain(from, hit);
        }

        private static WeaponTestTarget NearestExcluding(Vector3 from, float range, List<WeaponTestTarget> exclude)
        {
            WeaponTestTarget best = null;
            float bestSqr = range * range;
            foreach (var t in WeaponTestTarget.All)
            {
                if (!t.IsAlive || exclude.Contains(t)) continue;
                float d = (t.transform.position - from).sqrMagnitude;
                if (d < bestSqr) { bestSqr = d; best = t; }
            }
            return best;
        }

        private void SpawnAura()
        {
            if (_aura != null) Destroy(_aura);
            _aura = SpawnZone(_owner.position, Quaternion.identity, ZoneKind.Aura, 3.5f, 0f, 0.3f, 0f, _owner);
        }

        private GameObject SpawnZone(Vector3 pos, Quaternion rot, ZoneKind kind, float radius, float length, float tick, float life, Transform follow,
                                     WeaponTestPlayer aimer = null)
        {
            var go = SpawnBulletPrefab(pos, rot, null);
            go.AddComponent<WeaponTestZone>().Init(kind, Damage, radius, length, tick, life, follow, aimer);
            return go;
        }

        private GameObject SpawnBulletPrefab(Vector3 pos, Quaternion rot, Transform parent)
        {
            var go = Instantiate(Bullet.BulletPrefab.gameObject, pos, rot, parent);
            go.SetActive(true);
            // Stub physics would make bullets fall or collide; movement is driven by our components.
            foreach (var rb in go.GetComponentsInChildren<Rigidbody>(true)) rb.isKinematic = true;
            foreach (var ps in go.GetComponentsInChildren<ParticleSystem>(true)) if (!ps.isPlaying) ps.Play(true);
            return go;
        }

        public static WeaponBehavior ResolveBehavior(DamageBase prefab, BulletType bullet)
        {
            switch (prefab)
            {
                case BoomerangBullet _: return WeaponBehavior.Boomerang;
                case MissileDamage _: return WeaponBehavior.Homing;
                case LaserBeam _:
                case FlamethrowerBullet _:
                case DamageMechForwardDirection _: return WeaponBehavior.Beam;
                case ChainLightning _:
                case ChainLightningDamage _: return WeaponBehavior.Chain;
                case ContactMineBullet _: return WeaponBehavior.Mine;
                case ShotgunTypeBullet _: return WeaponBehavior.Shotgun;
                case DamageSpinAroundPlayer _:
                case AreaDamageDpsAroundPlayerByRadius _:
                case SwordsSkill _:
                case DamageEnemyOnTouch _:
                case CallCopter _:
                case CopterFighter _:
                case DamageTrails _:
                case ArealDamageOnPlayerPosition _: return WeaponBehavior.Aura;
                case AreaDamageExplosive _:
                case AreaDamageLeftOnGround _:
                case AreaDamageRandomAroundPlayer _:
                case AreaDamageRandomTargetOnRange _:
                case DamageOnPositionByRadius _:
                case DamageOnSideDirections _:
                case MultipleBulletPlayerPosition _: return WeaponBehavior.AreaAtTarget;
                case global::Bullet _:
                case ExplosiveBullet _:
                case FragmentedBullet _:
                case IgnoreEnemyBullet _: return WeaponBehavior.Projectile;
            }

            var byType = bullet.TypeBullet switch
            {
                BulletType.TypeOfBullet.Missile => WeaponBehavior.Homing,
                BulletType.TypeOfBullet.Beam => WeaponBehavior.Beam,
                BulletType.TypeOfBullet.Area => WeaponBehavior.AreaAtTarget,
                _ => WeaponBehavior.Projectile,
            };
            Debug.LogWarning($"{LogTag} Bullet '{bullet.Name}' uses unmapped class {prefab.GetType().Name}; using {byType} from TypeBullet={bullet.TypeBullet}.");
            return byType;
        }
    }
}
