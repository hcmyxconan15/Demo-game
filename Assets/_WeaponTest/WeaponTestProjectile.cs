using System.Collections.Generic;
using UnityEngine;

namespace WeaponTest
{
    public enum ProjectileMotion { Straight, Homing, Boomerang }

    /// <summary>
    /// Drives a spawned bullet prefab (whose original scripts are empty stubs):
    /// moves it, detects hits against WeaponTestTarget, handles pierce / ricochet / explosion.
    /// </summary>
    public class WeaponTestProjectile : MonoBehaviour
    {
        private ProjectileMotion _motion;
        private int _damage;
        private float _speed;
        private float _lifeTime;
        private int _pierceLeft;
        private int _ricochetLeft;
        private float _explosionRadius;
        private Transform _owner;

        private float _age;
        private Vector3 _dir;
        private WeaponTestTarget _homingTarget;
        private bool _returning;
        // Not readonly: HashSet is not serialisable, so a domain reload while playing leaves it null; CheckHits recreates it.
        private HashSet<WeaponTestTarget> _alreadyHit = new HashSet<WeaponTestTarget>();

        private const float HitRadius = 0.35f;
        private const float HomingTurnDegPerSec = 240f;
        private const float BoomerangOutTime = 0.6f;

        public void Init(ProjectileMotion motion, int damage, float speed, float lifeTime, int pierce, int ricochet,
                         float explosionRadius, Transform owner)
        {
            _motion = motion;
            _damage = damage;
            _speed = speed;
            _lifeTime = lifeTime;
            _pierceLeft = pierce;
            _ricochetLeft = ricochet;
            _explosionRadius = explosionRadius;
            _owner = owner;
            _dir = Flat(transform.forward);
            if (motion == ProjectileMotion.Homing)
                _homingTarget = WeaponTestTarget.Nearest(transform.position, 40f);
        }

        private void Update()
        {
            float dt = Time.deltaTime;
            _age += dt;
            if (_age >= _lifeTime) { Finish(); return; }

            switch (_motion)
            {
                case ProjectileMotion.Homing:
                    if (_homingTarget == null || !_homingTarget.IsAlive)
                        _homingTarget = WeaponTestTarget.Nearest(transform.position, 40f);
                    if (_homingTarget != null)
                    {
                        Vector3 want = Flat(_homingTarget.transform.position - transform.position).normalized;
                        _dir = Vector3.RotateTowards(_dir, want, HomingTurnDegPerSec * Mathf.Deg2Rad * dt, 0f);
                    }
                    break;
                case ProjectileMotion.Boomerang:
                    if (!_returning && _age >= BoomerangOutTime) { _returning = true; _alreadyHit.Clear(); }
                    if (_returning && _owner != null)
                    {
                        Vector3 back = Flat(_owner.position - transform.position);
                        if (back.magnitude < 1f) { Finish(); return; }
                        _dir = back.normalized;
                    }
                    break;
            }

            Vector3 from = transform.position;
            transform.position += _dir * (_speed * dt);
            if (_dir.sqrMagnitude > 0.0001f) transform.rotation = Quaternion.LookRotation(_dir, Vector3.up);
            CheckHits(from);
        }

        // Swept test along this frame's path: bullets at 100+ m/s move ~2 m per frame and would skip over targets.
        private void CheckHits(Vector3 from)
        {
            _alreadyHit ??= new HashSet<WeaponTestTarget>();
            Vector3 seg = Flat(transform.position - from);
            float segSqr = seg.sqrMagnitude;
            var all = WeaponTestTarget.All;
            for (int i = all.Count - 1; i >= 0; i--)
            {
                var t = all[i];
                if (!t.IsAlive || _alreadyHit.Contains(t)) continue;
                Vector3 toT = Flat(t.transform.position - from);
                float along = segSqr > 0f ? Mathf.Clamp01(Vector3.Dot(toT, seg) / segSqr) : 0f;
                if ((toT - seg * along).magnitude > HitRadius + t.Radius) continue;

                _alreadyHit.Add(t);
                if (_explosionRadius > 0f) { WeaponTestTarget.DamageInRadius(transform.position, _explosionRadius, _damage); Destroy(gameObject); return; }
                t.TakeDamage(_damage);

                // Boomerangs pass through everything.
                if (_motion == ProjectileMotion.Boomerang) continue;
                if (_ricochetLeft > 0)
                {
                    _ricochetLeft--;
                    var next = WeaponTestTarget.Nearest(transform.position, 15f, t);
                    if (next != null) { _dir = Flat(next.transform.position - transform.position).normalized; continue; }
                }
                if (_pierceLeft > 0) { _pierceLeft--; continue; }
                Finish();
                return;
            }
        }

        /// <summary>End of flight without a direct hit: missiles still detonate where they end up.</summary>
        private void Finish()
        {
            if (_explosionRadius > 0f && _motion == ProjectileMotion.Homing)
                WeaponTestTarget.DamageInRadius(transform.position, _explosionRadius, _damage);
            Destroy(gameObject);
        }

        private static Vector3 Flat(Vector3 v) { v.y = 0f; return v; }
    }
}
