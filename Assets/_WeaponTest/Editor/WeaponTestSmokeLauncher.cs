using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace WeaponTest.EditorTools
{
    /// <summary>
    /// Runs WeaponTestSmokeRunner in Play mode. From the command line:
    ///   Unity.exe -projectPath ... -executeMethod WeaponTest.EditorTools.WeaponTestSmokeLauncher.RunAndExit
    /// SessionState survives the domain reload that happens when entering Play mode.
    /// </summary>
    [InitializeOnLoad]
    public static class WeaponTestSmokeLauncher
    {
        private const string LogTag = "[WeaponTestSmokeLauncher]";
        private const string ScenePath = "Assets/_WeaponTest/WeaponTest.unity";
        private const string ActiveKey = "WeaponTestSmoke.Active";
        private const string ExitKey = "WeaponTestSmoke.ExitWhenDone";

        static WeaponTestSmokeLauncher()
        {
            EditorApplication.playModeStateChanged += OnPlayModeChanged;
        }

        [MenuItem("Tools/Weapon Test/Run Smoke Test")]
        public static void Run() => Start(false);

        public static void RunAndExit() => Start(true);

        private static void Start(bool exitWhenDone)
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                Debug.LogError($"{LogTag} Already in Play mode.");
                return;
            }
            if (AssetDatabase.LoadAssetAtPath<SceneAsset>(ScenePath) == null)
            {
                Debug.LogError($"{LogTag} {ScenePath} not found. Run Tools/Weapon Test/Create Sandbox Scene first.");
                if (exitWhenDone) EditorApplication.Exit(2);
                return;
            }
            EditorSceneManager.OpenScene(ScenePath);
            SessionState.SetBool(ActiveKey, true);
            SessionState.SetBool(ExitKey, exitWhenDone);
            EditorApplication.EnterPlaymode();
        }

        private static void OnPlayModeChanged(PlayModeStateChange change)
        {
            if (!SessionState.GetBool(ActiveKey, false)) return;
            Debug.Log($"{LogTag} Play mode state: {change}");

            if (change == PlayModeStateChange.EnteredPlayMode)
            {
                // Play mode stops ticking when the Editor window is unfocused unless this is on (ProjectSettings has it off).
                Application.runInBackground = true;
                var runner = new GameObject("SmokeRunner").AddComponent<WeaponTestSmokeRunner>();
                runner.Finished += () => EditorApplication.ExitPlaymode();
            }
            else if (change == PlayModeStateChange.EnteredEditMode)
            {
                SessionState.SetBool(ActiveKey, false);
                if (SessionState.GetBool(ExitKey, false)) EditorApplication.Exit(0);
            }
        }
    }
}
