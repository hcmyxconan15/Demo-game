using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace WeaponTest.EditorTools
{
    /// <summary>One-shot builder for the weapon sandbox scene. Safe to re-run: asks before overwriting.</summary>
    public static class WeaponTestSceneBuilder
    {
        private const string LogTag = "[WeaponTestSceneBuilder]";
        private const string ScenePath = "Assets/_WeaponTest/WeaponTest.unity";

        [MenuItem("Tools/Weapon Test/Create Sandbox Scene")]
        public static void Build()
        {
            if (EditorApplication.isPlayingOrWillChangePlaymode)
            {
                Debug.LogError($"{LogTag} Exit Play mode first.");
                return;
            }
            if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) return;
            if (AssetDatabase.LoadAssetAtPath<SceneAsset>(ScenePath) != null &&
                !EditorUtility.DisplayDialog("Weapon Test", $"{ScenePath} already exists. Overwrite?", "Overwrite", "Cancel"))
                return;

            if (AssetDatabase.FindAssets("t:MechaDataBase").Length != 1)
            {
                Debug.LogError($"{LogTag} Expected exactly one MechaDataBase asset.");
                return;
            }

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            // Load after NewScene: opening a scene in Single mode unloads unused assets loaded before it.
            var mechaDb = FindSingle<MechaDataBase>("t:MechaDataBase");
            if (mechaDb == null) return;

            var light = new GameObject("Directional Light").AddComponent<Light>();
            light.type = LightType.Directional;
            light.intensity = 1.2f;
            light.transform.rotation = Quaternion.Euler(50f, -30f, 0f);

            var camGo = new GameObject("Main Camera") { tag = "MainCamera" };
            var cam = camGo.AddComponent<Camera>();
            cam.fieldOfView = 45f;
            cam.farClipPlane = 300f;
            camGo.AddComponent<AudioListener>();

            var ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
            ground.name = "Ground";
            ground.transform.localScale = new Vector3(10f, 1f, 10f);

            var player = new GameObject("Player").AddComponent<WeaponTestPlayer>();
            SetRef(player, "mechaDb", mechaDb);
            SetRef(player, "cam", cam);

            var hud = new GameObject("HUD").AddComponent<WeaponTestHud>();
            SetRef(hud, "player", player);
            SetRef(hud, "cam", cam);

            var targets = new GameObject("Targets").transform;
            for (int i = 0; i < 10; i++)
            {
                float a = i * Mathf.PI * 2f / 10f;
                float r = i % 2 == 0 ? 9f : 14f;
                SpawnTarget(targets, new Vector3(Mathf.Cos(a) * r, 1f, Mathf.Sin(a) * r), $"Target_{i}");
            }
            for (int i = 0; i < 6; i++)
                SpawnTarget(targets, new Vector3(-4f + (i % 3) * 1.8f, 1f, 20f + (i / 3) * 1.8f), $"Cluster_{i}");

            EditorSceneManager.SaveScene(scene, ScenePath);
            Debug.Log($"{LogTag} Created {ScenePath} with mechaDb='{mechaDb.name}'. Press Play to test.");
        }

        private static void SpawnTarget(Transform parent, Vector3 pos, string name)
        {
            var go = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            go.name = name;
            go.transform.SetParent(parent, false);
            go.transform.position = pos;
            Object.DestroyImmediate(go.GetComponent<Collider>());
            var target = go.AddComponent<WeaponTestTarget>();
            SetRef(target, "bodyRenderer", go.GetComponent<Renderer>());
        }

        private static void SetRef(Object owner, string field, Object value)
        {
            var so = new SerializedObject(owner);
            var prop = so.FindProperty(field);
            if (prop == null)
            {
                Debug.LogError($"{LogTag} Field '{field}' not found on {owner.GetType().Name}.");
                return;
            }
            prop.objectReferenceValue = value;
            so.ApplyModifiedPropertiesWithoutUndo();
        }

        private static T FindSingle<T>(string filter) where T : Object
        {
            var guids = AssetDatabase.FindAssets(filter);
            if (guids.Length != 1)
            {
                Debug.LogError($"{LogTag} Expected exactly one asset for '{filter}', found {guids.Length}.");
                return null;
            }
            return AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(guids[0]));
        }
    }
}
