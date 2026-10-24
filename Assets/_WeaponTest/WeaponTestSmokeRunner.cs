using System;
using System.IO;
using System.Text;
using UnityEngine;

namespace WeaponTest
{
    /// <summary>
    /// Automated pass over every weapon: equips it, auto-fires at the nearest target for a few seconds,
    /// then logs damage dealt, errors raised and a screenshot path. Added by WeaponTestSmokeLauncher.
    /// </summary>
    public class WeaponTestSmokeRunner : MonoBehaviour
    {
        private const string LogTag = "[Smoke]";
        private const float SecondsPerWeapon = 3f;
        private const float ScreenshotAt = 2f;

        public static string ScreenshotDir = "D:/IronHuntersRip/_tools/smoke_shots";
        private static string ResultPath => $"{ScreenshotDir}/results.txt";
        public event Action Finished;

        private WeaponTestPlayer _player;
        private bool _evolutions;
        private int _index = -1;
        private float _weaponStart;
        private bool _shotTaken;
        private int _errors;
        private string _firstError;
        private readonly StringBuilder _summary = new StringBuilder();
        private int _ok, _noDamage, _withErrors;

        private void Start()
        {
            _player = FindAnyObjectByType<WeaponTestPlayer>();
            if (_player == null)
            {
                Debug.LogError($"{LogTag} No WeaponTestPlayer in scene; aborting.");
                Finished?.Invoke();
                enabled = false;
                return;
            }
            Directory.CreateDirectory(ScreenshotDir);
            File.WriteAllText(ResultPath, "");
            Application.logMessageReceived += OnLog;
            Debug.Log($"{LogTag} Started, writing results to {ResultPath}");
            _player.AutoFire = true;
        }

        private void OnDestroy() => Application.logMessageReceived -= OnLog;

        private void OnLog(string message, string stack, LogType type)
        {
            if (type != LogType.Error && type != LogType.Exception && type != LogType.Assert) return;
            if (message.StartsWith(LogTag)) return;
            // Raised when the Editor window is unfocused during a command-line run; not a weapon fault.
            if (message.StartsWith("Failed to capture screen shot")) return;
            _errors++;
            _firstError ??= message.Length > 160 ? message.Substring(0, 160) : message;
        }

        private void Update()
        {
            // The player builds its mech and weapon list in its own Start, which may run after ours.
            if (_index < 0)
            {
                if (_player.WeaponCount > 0 && _player.Gun != null) NextWeapon();
                return;
            }
            if (_player.Gun == null) return;

            var target = WeaponTestTarget.Nearest(_player.transform.position, 100f);
            _player.AimOverride = target != null ? target.transform.position : _player.transform.position + Vector3.forward * 10f;

            float t = Time.time - _weaponStart;
            if (!_shotTaken && t >= ScreenshotAt)
            {
                _shotTaken = true;
                ScreenCapture.CaptureScreenshot(ShotPath());
            }
            if (t >= SecondsPerWeapon) { Report(); NextWeapon(); }
        }

        private void NextWeapon()
        {
            while (true)
            {
                // Leftovers (20 s mines, area fields, bullets in flight) would credit their damage to the next weapon.
                ClearSpawns();
                // Reset before equipping so errors raised by Init are attributed to this weapon.
                _errors = 0;
                _firstError = null;
                _index++;
                if (_index >= _player.WeaponCount)
                {
                    if (_evolutions) { Finish(); return; }
                    _evolutions = true;
                    _index = 0;
                    _player.SelectWeaponList(true);
                }
                else if (_index == 0) _player.SelectWeaponList(false);
                else _player.SelectWeapon(_index);

                if (_player.Gun == null || PassesFilter(_player.Gun.Data.WeaponName)) break;
            }

            PlacePlayer();
            foreach (var target in WeaponTestTarget.All) target.ResetHp();
            WeaponTestTarget.TotalDamage = 0;
            _shotTaken = false;
            _weaponStart = Time.time;
        }

        private static void ClearSpawns()
        {
            foreach (var p in FindObjectsByType<WeaponTestProjectile>(FindObjectsSortMode.None)) Destroy(p.gameObject);
            foreach (var z in FindObjectsByType<WeaponTestZone>(FindObjectsSortMode.None)) Destroy(z.gameObject);
        }

        // Targets stand 9 m+ from the origin; short-range weapons (auras, beams) only reach them when the player walks up,
        // as enemies would close in during a real match. Long-range weapons are tested from the origin.
        private const float CloseRangeStandOff = 2.5f;

        private void PlacePlayer()
        {
            var g = _player.Gun;
            bool closeRange = g != null && (g.Behavior == WeaponBehavior.Aura || g.Behavior == WeaponBehavior.Beam);
            Vector3 pos = Vector3.zero;
            if (closeRange)
            {
                var target = WeaponTestTarget.Nearest(Vector3.zero, 100f);
                if (target != null)
                {
                    Vector3 t = target.transform.position; t.y = 0f;
                    pos = t - t.normalized * CloseRangeStandOff;
                }
            }
            _player.transform.position = pos;
        }

        /// <summary>Command line "-smokeFilter a,b" limits the run to weapons whose name contains one of the parts.</summary>
        private static bool PassesFilter(string weaponName)
        {
            string[] args = Environment.GetCommandLineArgs();
            int i = Array.IndexOf(args, "-smokeFilter");
            if (i < 0 || i + 1 >= args.Length) return true;
            foreach (string part in args[i + 1].Split(','))
                if (weaponName.IndexOf(part.Trim(), StringComparison.OrdinalIgnoreCase) >= 0) return true;
            return false;
        }

        private static string DescribeZones()
        {
            var sb = new StringBuilder();
            foreach (var z in FindObjectsByType<WeaponTestZone>(FindObjectsSortMode.None))
            {
                var near = WeaponTestTarget.Nearest(z.transform.position, 1000f);
                float d = near != null ? Vector3.Distance(near.transform.position, z.transform.position) : -1f;
                sb.Append($" zone[{z.name} active={z.isActiveAndEnabled} pos={z.transform.position} nearest={d:0.0}]");
            }
            return sb.Length > 0 ? sb.ToString() : " zone[none]";
        }

        private void Report()
        {
            var g = _player.Gun;
            long dmg = WeaponTestTarget.TotalDamage;
            bool firing = g.ShotsFired >= 3 || g.Behavior == WeaponBehavior.Aura;
            string status = _errors > 0 ? "ERROR" : !firing ? "NOT_FIRING" : dmg > 0 ? "OK" : "NO_DAMAGE";
            if (status == "OK") _ok++; else if (status == "ERROR") _withErrors++; else _noDamage++;

            string line = $"{(_evolutions ? "EVO" : "BASE")} #{_index + 1:00} {g.Data.WeaponName,-28} {g.Behavior,-12} " +
                          $"bullet={g.Bullet.BulletPrefab.GetType().Name,-24} shots={g.ShotsFired,3} dmg={dmg,6} errors={_errors} {status}" +
                          (g.Behavior == WeaponBehavior.Aura && dmg == 0 ? DescribeZones() : "") +
                          (_firstError != null ? $" | {_firstError}" : "");
            Debug.Log($"{LogTag} {line}");
            File.AppendAllText(ResultPath, line + "\n");
            _summary.AppendLine(line);
        }

        private void Finish()
        {
            File.AppendAllText(ResultPath, $"SUMMARY ok={_ok} not_ok={_noDamage} errors={_withErrors}\n");
            Debug.Log($"{LogTag} SUMMARY ok={_ok} not_ok={_noDamage} errors={_withErrors}\n{_summary}");
            enabled = false;
            Finished?.Invoke();
        }

        private string ShotPath()
        {
            string name = _player.Gun.Data.WeaponName;
            foreach (char c in Path.GetInvalidFileNameChars()) name = name.Replace(c, '_');
            return $"{ScreenshotDir}/{(_evolutions ? "evo" : "base")}_{_index + 1:00}_{name}.png";
        }
    }
}
