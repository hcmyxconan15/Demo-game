using System.Collections.Generic;
using UnityEngine;

namespace WeaponTest
{
    /// <summary>Debug HUD for the weapon sandbox: weapon panel, floating damage numbers, chain lines.</summary>
    public class WeaponTestHud : MonoBehaviour
    {
        private const string LogTag = "[WeaponTestHud]";

        [SerializeField] private WeaponTestPlayer player;
        [SerializeField] private Camera cam;

        private struct Popup { public Vector3 Pos; public string Text; public float Born; }

        private static readonly List<Popup> Popups = new List<Popup>();
        private static Material _lineMaterial;
        private const float PopupLife = 0.8f;
        private GUIStyle _popupStyle, _panelStyle;

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (Application.isPlaying) return;
            if (player == null) Debug.LogWarning($"{LogTag} player is not assigned.", this);
            if (cam == null) Debug.LogWarning($"{LogTag} cam is not assigned.", this);
        }
#endif

        private void OnDisable() => Popups.Clear();

        public static void ShowDamage(Vector3 worldPos, int amount)
        {
            worldPos += new Vector3(Random.Range(-0.4f, 0.4f), 0f, Random.Range(-0.4f, 0.4f));
            Popups.Add(new Popup { Pos = worldPos, Text = amount.ToString(), Born = Time.time });
        }

        public static void DrawChain(Vector3 from, List<WeaponTestTarget> hits)
        {
            if (_lineMaterial == null) _lineMaterial = new Material(Shader.Find("Sprites/Default"));
            var lr = new GameObject("ChainLine").AddComponent<LineRenderer>();
            lr.sharedMaterial = _lineMaterial;
            lr.startColor = lr.endColor = new Color(0.5f, 0.8f, 1f);
            lr.widthMultiplier = 0.15f;
            lr.positionCount = hits.Count + 1;
            lr.SetPosition(0, from);
            for (int i = 0; i < hits.Count; i++) lr.SetPosition(i + 1, hits[i].transform.position + Vector3.up);
            Destroy(lr.gameObject, 0.15f);
        }

        private void OnGUI()
        {
            if (player == null || cam == null) return;
            _popupStyle ??= new GUIStyle(GUI.skin.label) { fontSize = 20, fontStyle = FontStyle.Bold, alignment = TextAnchor.MiddleCenter };
            _panelStyle ??= new GUIStyle(GUI.skin.box) { fontSize = 14, alignment = TextAnchor.UpperLeft, richText = true, padding = new RectOffset(10, 10, 8, 8) };

            DrawPopups();
            DrawPanel();
        }

        private void DrawPopups()
        {
            for (int i = Popups.Count - 1; i >= 0; i--)
            {
                var p = Popups[i];
                float t = (Time.time - p.Born) / PopupLife;
                if (t >= 1f) { Popups.RemoveAt(i); continue; }
                Vector3 sp = cam.WorldToScreenPoint(p.Pos + Vector3.up * t * 1.5f);
                if (sp.z < 0f) continue;
                GUI.color = new Color(1f, 0.9f, 0.3f, 1f - t);
                GUI.Label(new Rect(sp.x - 40f, Screen.height - sp.y - 15f, 80f, 30f), p.Text, _popupStyle);
            }
            GUI.color = Color.white;
        }

        private void DrawPanel()
        {
            var g = player.Gun;
            string body;
            if (g == null) body = $"<b>{player.MechName}</b>\nNo weapon equipped";
            else
            {
                string ammo = g.IsReloading ? "<color=orange>RELOADING</color>" : $"{g.ShotsLeft}/{g.Magazine}";
                body =
                    $"<b>Mech:</b> {player.MechName}   <b>List:</b> {(player.UsingEvolutions ? "Evolutions" : "Base")}\n" +
                    $"<b>[{player.WeaponIndex + 1}/{player.WeaponCount}] {g.Data.WeaponName}</b>  (id {g.Data.WeaponId}, slot {g.Data.WeaponSlotType})\n" +
                    $"Bullet: {g.Bullet.Name} → <color=cyan>{g.Behavior}</color> ({g.Bullet.BulletPrefab.GetType().Name})\n" +
                    $"Level {g.Level}/{g.Data.MaxWeaponLevel}   Damage {g.Damage}   Interval {g.AttackInterval:0.00}s\n" +
                    $"Ammo {ammo}   Reload {g.ReloadTime:0.0}s   Pierce {g.Data.PassEnemyCount}   Ricochet {g.Data.RicochetCount}\n" +
                    $"Auto-fire: {(player.AutoFire ? "<color=lime>ON</color>" : "off")}   " +
                    $"Continuous: {(WeaponTestGun.Continuous ? "<color=lime>ON</color> (no reload)" : "off (WeaponDb timing)")}   Shots {g.ShotsFired}\n\n" +
                    "<size=12>WASD move · LMB fire · F auto · C continuous · Q/E weapon · Z/X level · V evolutions · Tab mech · R heal</size>";
            }
            GUI.Box(new Rect(10f, 10f, 560f, 175f), body, _panelStyle);
        }
    }
}
