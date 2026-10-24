using UnityEngine;

namespace WeaponTest
{
    public enum ZoneKind
    {
        /// <summary>Damage ticks in a radius at a fixed spot (ground fields, explosions).</summary>
        Area,
        /// <summary>Damage ticks in a radius that follows the player (spinning blades, swords, copter).</summary>
        Aura,
        /// <summary>Sits still until a target steps in, then explodes once.</summary>
        Mine,
        /// <summary>Damage ticks along a line from the launch point (lasers, flamethrower).</summary>
        Beam,
    }

    /// <summary>Drives area / aura / mine / beam bullet prefabs whose original scripts are empty stubs.</summary>
    public class WeaponTestZone : MonoBehaviour
    {
        private ZoneKind _kind;
        private int _damage;
        private float _radius;
        private float _length;
        private float _tickInterval;
        private float _lifeTime;
        private Transform _follow;
        private WeaponTestPlayer _aimer;

        private float _age;
        private float _nextTick;
        private LineRenderer[] _lines;

        /// <param name="aimer">Beams only: points the beam at the player's aim point instead of the launch point's own forward.</param>
        public void Init(ZoneKind kind, int damage, float radius, float length, float tickInterval, float lifeTime, Transform follow,
                         WeaponTestPlayer aimer = null)
        {
            _aimer = aimer;
            _kind = kind;
            _damage = damage;
            _radius = radius;
            _length = length;
            _tickInterval = tickInterval;
            _lifeTime = lifeTime;
            _follow = follow;
            _lines = kind == ZoneKind.Beam ? GetComponentsInChildren<LineRenderer>(true) : null;
        }

        private void Update()
        {
            _age += Time.deltaTime;
            if (_lifeTime > 0f && _age >= _lifeTime) { Destroy(gameObject); return; }

            if (_follow != null)
            {
                transform.position = _follow.position;
                if (_kind == ZoneKind.Beam) transform.rotation = BeamRotation();
            }
            if (_kind == ZoneKind.Beam) UpdateBeamLines();

            if (_kind == ZoneKind.Mine)
            {
                if (WeaponTestTarget.Nearest(transform.position, _radius) == null) return;
                WeaponTestTarget.DamageInRadius(transform.position, _radius * 1.5f, _damage);
                Destroy(gameObject);
                return;
            }

            if (_age < _nextTick) return;
            _nextTick = _age + _tickInterval;
            if (_kind == ZoneKind.Beam) DamageAlongBeam();
            else WeaponTestTarget.DamageInRadius(transform.position, _radius, _damage);
        }

        private Quaternion BeamRotation()
        {
            if (_aimer == null) return _follow.rotation;
            Vector3 dir = _aimer.AimPoint - transform.position; dir.y = 0f;
            return dir.sqrMagnitude > 1f ? Quaternion.LookRotation(dir, Vector3.up) : Quaternion.LookRotation(_aimer.AimDirection, Vector3.up);
        }

        private void DamageAlongBeam()
        {
            Vector3 a = transform.position;
            Vector3 dir = transform.forward; dir.y = 0f; dir.Normalize();
            var all = WeaponTestTarget.All;
            for (int i = all.Count - 1; i >= 0; i--)
            {
                var t = all[i];
                if (!t.IsAlive) continue;
                Vector3 to = t.transform.position - a; to.y = 0f;
                float along = Vector3.Dot(to, dir);
                if (along < 0f || along > _length) continue;
                if ((to - dir * along).magnitude <= _radius + t.Radius) t.TakeDamage(_damage);
            }
        }

        // The original LaserBeam script positioned its LineRenderers at runtime; do the same here.
        private void UpdateBeamLines()
        {
            if (_lines == null) return;
            Vector3 a = transform.position;
            Vector3 b = a + transform.forward * _length;
            foreach (var lr in _lines)
            {
                if (lr.positionCount < 2) lr.positionCount = 2;
                lr.useWorldSpace = true;
                lr.SetPosition(0, a);
                lr.SetPosition(lr.positionCount - 1, b);
            }
        }
    }
}
