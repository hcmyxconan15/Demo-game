using System.Collections.Generic;
using UnityEngine;

namespace WeaponTest
{
    /// <summary>
    /// Sandbox player: assembles a mech (base + body) from MechaDB, moves with WASD, aims at the mouse
    /// and fires one weapon from WeaponDb at a time.
    ///
    /// Keys: WASD move | LMB fire | F auto-fire | Q/E weapon | Z/X level | V base/evolution list | Tab mech | R heal targets
    /// </summary>
    public class WeaponTestPlayer : MonoBehaviour
    {
        private const string LogTag = "[WeaponTestPlayer]";

        [SerializeField] private MechaDataBase mechaDb;
        [SerializeField] private Camera cam;
        [SerializeField] private Vector3 cameraOffset = new Vector3(0f, 22f, -12f);
        [SerializeField] private float fallbackMoveSpeed = 7f;

        public string MechName { get; private set; }
        public WeaponTestGun Gun { get; private set; }
        public int WeaponIndex { get; private set; }
        public int WeaponCount => _weapons.Count;
        public bool UsingEvolutions { get; private set; }
        public bool AutoFire { get; set; }
        /// <summary>When set, aims at this world point instead of the mouse (used by the smoke runner).</summary>
        public Vector3? AimOverride { get; set; }
        public int MechCount => mechaDb != null ? mechaDb.MechList.Count : 0;
        public Vector3 AimDirection => _aimDir;
        /// <summary>World point under the cursor (or AimOverride), at ground height.</summary>
        public Vector3 AimPoint => _aimPoint;

        public void SelectWeapon(int index) => EquipWeapon(index);

        public void SelectWeaponList(bool evolutions)
        {
            UsingEvolutions = evolutions;
            BuildWeaponList();
            EquipWeapon(0);
        }

        private readonly List<Weapon> _weapons = new List<Weapon>();
        private int _mechIndex;
        private Transform _legs, _bodyPivot;
        private BaseJoin _baseJoin;
        private BodyJoin _bodyJoin;
        private float _moveSpeed;
        private Vector3 _aimDir = Vector3.forward;
        private Vector3 _aimPoint = Vector3.forward * 10f;
        private Animator _legsAnimator;
        private int _runningHash, _groundedHash, _xHash, _yHash;
        private bool _hasRunning, _hasGrounded, _hasX, _hasY;

#if UNITY_EDITOR
        private void OnValidate()
        {
            if (Application.isPlaying) return;
            if (mechaDb == null) Debug.LogWarning($"{LogTag} mechaDb is not assigned.", this);
            if (cam == null) Debug.LogWarning($"{LogTag} cam is not assigned.", this);
        }
#endif

        private void Start()
        {
            if (mechaDb == null || cam == null)
            {
                Debug.LogError($"{LogTag} Missing references: mechaDb={(mechaDb != null)}, cam={(cam != null)}. Assign them in the Inspector.", this);
                enabled = false;
                return;
            }
            BuildWeaponList();
            BuildMech(0);
        }

        // ---------------------------------------------------------------- assembly

        private void BuildMech(int index)
        {
            var mechs = mechaDb.MechList;
            _mechIndex = (index % mechs.Count + mechs.Count) % mechs.Count;
            var mech = mechs[_mechIndex];
            MechName = mech.MechName;

            if (_legs != null) Destroy(_legs.gameObject);
            if (_bodyPivot != null) Destroy(_bodyPivot.gameObject);
            Gun = null;

            BaseType baseType = mechaDb.RobotBaseDb.BaseTypes.Find(b => b.BaseId == mech.BaseId);
            BodyType bodyType = mechaDb.RobotBodyDb.BodyTypes.Find(b => b.BodyId == mech.BodyId);
            if (baseType == null || baseType.BasePrefab == null || bodyType == null || bodyType.BodyJoin == null)
            {
                Debug.LogError($"{LogTag} Mech '{mech.MechName}' cannot be built: baseId={mech.BaseId} found={baseType?.BasePrefab != null}, bodyId={mech.BodyId} found={bodyType?.BodyJoin != null}.", this);
                return;
            }
            _moveSpeed = baseType.Speed > 0f ? baseType.Speed : fallbackMoveSpeed;

            _legs = new GameObject("Legs").transform;
            _legs.SetParent(transform, false);
            var baseGo = Instantiate(baseType.BasePrefab, _legs);
            baseGo.SetActive(true);
            _baseJoin = baseGo.GetComponentInChildren<BaseJoin>(true);

            _bodyPivot = new GameObject("BodyPivot").transform;
            _bodyPivot.SetParent(transform, false);
            _bodyJoin = Instantiate(bodyType.BodyJoin, _bodyPivot);
            _bodyJoin.gameObject.SetActive(true);

            SetupLegsAnimator(_baseJoin != null ? _baseJoin.BaseAnimator : baseGo.GetComponentInChildren<Animator>());
            EquipWeapon(WeaponIndex);
        }

        private void BuildWeaponList()
        {
            _weapons.Clear();
            var db = UsingEvolutions ? mechaDb.WeaponsDb.WeaponsEvolutionsDb : mechaDb.WeaponsDb;
            foreach (var w in db.Weapons)
            {
                if (w.WeaponPrefab == null) { Debug.LogWarning($"{LogTag} Skipping '{w.WeaponName}' (id {w.WeaponId}): no WeaponPrefab."); continue; }
                if (FindBullet(w.BulletId) == null) { Debug.LogWarning($"{LogTag} Skipping '{w.WeaponName}' (id {w.WeaponId}): bullet {w.BulletId} has no prefab."); continue; }
                _weapons.Add(w);
            }
        }

        private BulletType FindBullet(int id)
        {
            var b = mechaDb.WeaponsDb.BulletsDb.Bullets.Find(x => x.BulletId == id);
            return b != null && b.BulletPrefab != null ? b : null;
        }

        private void EquipWeapon(int index)
        {
            if (_weapons.Count == 0) { Debug.LogError($"{LogTag} No usable weapons in the list (evolutions={UsingEvolutions})."); return; }
            int level = Gun != null ? Gun.Level : 1;
            if (Gun != null) Destroy(Gun.gameObject);

            WeaponIndex = (index % _weapons.Count + _weapons.Count) % _weapons.Count;
            var w = _weapons[WeaponIndex];
            Transform mount = FindMount(w.WeaponSlotType);

            var go = Instantiate(w.WeaponPrefab, mount);
            go.SetActive(true);
            go.transform.localPosition = Vector3.zero;
            go.transform.localRotation = Quaternion.identity;
            Gun = go.AddComponent<WeaponTestGun>();
            Gun.Init(w, FindBullet(w.BulletId), this, level);
        }

        private Transform FindMount(Weapon.SlotType slot)
        {
            var positions = _bodyJoin.WeaponsPositions;
            if (positions != null)
            {
                foreach (var p in positions)
                    if (p.SlotType == slot && p.WeaponTransformPosition != null) return p.WeaponTransformPosition;
                foreach (var p in positions)
                    if (p.WeaponTransformPosition != null)
                    {
                        Debug.LogWarning($"{LogTag} Body of '{MechName}' has no slot {slot}; mounting on {p.SlotType} instead.");
                        return p.WeaponTransformPosition;
                    }
            }
            Debug.LogWarning($"{LogTag} Body of '{MechName}' has no weapon positions; mounting on the body root.");
            return _bodyJoin.transform;
        }

        private void SetupLegsAnimator(Animator animator)
        {
            _legsAnimator = animator;
            _hasRunning = _hasGrounded = _hasX = _hasY = false;
            if (animator == null || animator.runtimeAnimatorController == null) return;
            foreach (var p in animator.parameters)
            {
                if (p.name == "Running") { _hasRunning = true; _runningHash = p.nameHash; }
                else if (p.name == "Grounded") { _hasGrounded = true; _groundedHash = p.nameHash; }
                else if (p.name == "X") { _hasX = true; _xHash = p.nameHash; }
                else if (p.name == "Y") { _hasY = true; _yHash = p.nameHash; }
            }
        }

        // ---------------------------------------------------------------- per frame

        private void Update()
        {
            if (_bodyJoin == null) return;
            HandleHotkeys();

            Vector3 move = new Vector3(
                (Input.GetKey(KeyCode.D) ? 1f : 0f) - (Input.GetKey(KeyCode.A) ? 1f : 0f), 0f,
                (Input.GetKey(KeyCode.W) ? 1f : 0f) - (Input.GetKey(KeyCode.S) ? 1f : 0f));
            if (move.sqrMagnitude > 1f) move.Normalize();
            transform.position += move * (_moveSpeed * Time.deltaTime);
            if (move.sqrMagnitude > 0.01f)
                _legs.rotation = Quaternion.RotateTowards(_legs.rotation, Quaternion.LookRotation(move), 720f * Time.deltaTime);

            UpdateAim();
            UpdateLegsAnimator(move);

            if (Gun != null && (AutoFire || Input.GetMouseButton(0))) Gun.TickFire();
        }

        private void LateUpdate()
        {
            if (_bodyJoin == null) return;
            // Seat the body on the legs' attach point (the original FollowTransform script is a stub).
            if (_baseJoin != null && _baseJoin.BaseTransform != null)
            {
                Vector3 seat = _baseJoin.BaseTransform.position;
                Vector3 offset = _bodyJoin.BaseTransform != null ? _bodyJoin.transform.position - _bodyJoin.BaseTransform.position : Vector3.zero;
                _bodyPivot.position = seat + offset;
            }
            _bodyPivot.rotation = Quaternion.LookRotation(_aimDir, Vector3.up);

            cam.transform.position = transform.position + cameraOffset;
            cam.transform.LookAt(transform.position);
        }

        private void UpdateAim()
        {
            Vector3 point;
            if (AimOverride.HasValue) point = AimOverride.Value;
            else
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                var ground = new Plane(Vector3.up, Vector3.zero);
                if (!ground.Raycast(ray, out float enter)) return;
                point = ray.GetPoint(enter);
            }
            Vector3 dir = point - transform.position;
            dir.y = 0f;
            if (dir.sqrMagnitude > 0.25f)
            {
                _aimDir = dir.normalized;
                _aimPoint = new Vector3(point.x, 0f, point.z);
            }
        }

        private void UpdateLegsAnimator(Vector3 move)
        {
            if (_legsAnimator == null) return;
            bool running = move.sqrMagnitude > 0.01f;
            Vector3 local = _legs.InverseTransformDirection(move);
            if (_hasRunning) _legsAnimator.SetBool(_runningHash, running);
            if (_hasGrounded) _legsAnimator.SetBool(_groundedHash, true);
            if (_hasX) _legsAnimator.SetFloat(_xHash, local.x);
            if (_hasY) _legsAnimator.SetFloat(_yHash, local.z);
        }

        private void HandleHotkeys()
        {
            if (Input.GetKeyDown(KeyCode.E)) EquipWeapon(WeaponIndex + 1);
            if (Input.GetKeyDown(KeyCode.Q)) EquipWeapon(WeaponIndex - 1);
            if (Input.GetKeyDown(KeyCode.X) && Gun != null) Gun.SetLevel(Gun.Level + 1);
            if (Input.GetKeyDown(KeyCode.Z) && Gun != null) Gun.SetLevel(Gun.Level - 1);
            if (Input.GetKeyDown(KeyCode.F)) AutoFire = !AutoFire;
            if (Input.GetKeyDown(KeyCode.C)) WeaponTestGun.Continuous = !WeaponTestGun.Continuous;
            if (Input.GetKeyDown(KeyCode.Tab)) BuildMech(_mechIndex + 1);
            if (Input.GetKeyDown(KeyCode.V)) SelectWeaponList(!UsingEvolutions);
            if (Input.GetKeyDown(KeyCode.R))
                foreach (var t in WeaponTestTarget.All) t.ResetHp();
        }
    }
}
