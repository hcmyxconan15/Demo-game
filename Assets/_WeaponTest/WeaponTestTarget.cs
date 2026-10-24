using System.Collections.Generic;
using UnityEngine;

namespace WeaponTest
{
    /// <summary>Dummy enemy for the weapon sandbox: takes damage, flashes, respawns.</summary>
    public class WeaponTestTarget : MonoBehaviour
    {
        public static readonly List<WeaponTestTarget> All = new List<WeaponTestTarget>();
        /// <summary>Damage dealt to all targets since the last reset (read by the smoke runner).</summary>
        public static long TotalDamage;

        [SerializeField] private int maxHp = 500;
        [SerializeField] private float radius = 0.8f;
        [SerializeField] private float respawnDelay = 2f;
        [SerializeField] private Renderer bodyRenderer;

        public float Radius => radius;
        public bool IsAlive => _hp > 0;
        public int Hp => _hp;
        public int MaxHp => maxHp;

        private static readonly int BaseColorId = Shader.PropertyToID("_BaseColor");
        private MaterialPropertyBlock _mpb;
        private int _hp;
        private float _flashUntil;
        private float _respawnAt;

        private void OnEnable()
        {
            All.Add(this);
            _hp = maxHp;
        }

        private void OnDisable() => All.Remove(this);

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (!Application.isPlaying && bodyRenderer == null)
                Debug.LogWarning($"[WeaponTestTarget] {name}: bodyRenderer is not assigned.", this);
        }
#endif

        public void ResetHp() => _hp = maxHp;

        public void TakeDamage(int amount)
        {
            if (!IsAlive) return;
            TotalDamage += amount;
            _hp = Mathf.Max(0, _hp - amount);
            _flashUntil = Time.time + 0.08f;
            WeaponTestHud.ShowDamage(transform.position + Vector3.up * 2f, amount);
            if (_hp == 0) _respawnAt = Time.time + respawnDelay;
        }

        private void Update()
        {
            if (!IsAlive && Time.time >= _respawnAt) _hp = maxHp;

            if (bodyRenderer == null) return;
            _mpb ??= new MaterialPropertyBlock();
            Color c = !IsAlive ? new Color(0.2f, 0.2f, 0.2f) : Time.time < _flashUntil ? Color.white : Color.Lerp(Color.red, new Color(1f, 0.6f, 0.1f), (float)_hp / maxHp);
            _mpb.SetColor(BaseColorId, c);
            bodyRenderer.SetPropertyBlock(_mpb);
        }

        public static WeaponTestTarget Nearest(Vector3 from, float maxDistance, WeaponTestTarget exclude = null)
        {
            WeaponTestTarget best = null;
            float bestSqr = maxDistance * maxDistance;
            foreach (var t in All)
            {
                if (!t.IsAlive || t == exclude) continue;
                float d = (t.transform.position - from).sqrMagnitude;
                if (d < bestSqr) { bestSqr = d; best = t; }
            }
            return best;
        }

        /// <summary>Damages every live target within radius (flat XZ distance).</summary>
        public static int DamageInRadius(Vector3 center, float radius, int damage)
        {
            int hits = 0;
            for (int i = All.Count - 1; i >= 0; i--)
            {
                var t = All[i];
                if (!t.IsAlive) continue;
                Vector3 d = t.transform.position - center;
                d.y = 0f;
                if (d.magnitude <= radius + t.Radius) { t.TakeDamage(damage); hits++; }
            }
            return hits;
        }
    }
}
