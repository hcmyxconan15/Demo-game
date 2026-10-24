using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FIMSpace.FSpine
{
	[AddComponentMenu("FImpossible Creations/Spinal Animator 2")]
	[DefaultExecutionOrder(-11)]
	[HelpURL("https://assetstore.unity.com/packages/tools/animation/spine-animator-128322")]
	public class FSpineAnimator : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		public enum EFSpineEditorCategory
		{
			Setup = 0,
			Tweak = 1,
			Adjust = 2,
			Physical = 3
		}

		public enum EFDeltaType
		{
			DeltaTime = 0,
			SmoothDeltaTime = 1,
			UnscaledDeltaTime = 2,
			FixedDeltaTime = 3,
			SafeDelta = 4
		}

		public enum EParamChange
		{
			GoBackSpeed = 0,
			SpineAnimatorAmount = 1,
			AngleLimit = 2,
			StraightenSpeed = 3,
			PositionSmoother = 4,
			RotationSmoother = 5
		}

		public class HeadBone
		{
			public Transform baseTransform;

			public Transform transform;

			private Vector3 snapshotPoseBaseTrSpacePosition;

			public Vector3 SnapshotPosition;

			private Quaternion snapshotPoseBaseTrSpaceRotationF;

			private Quaternion snapshotPoseBaseTrSpaceRotationB;

			public Quaternion snapshotPoseLocalRotation;

			public Quaternion SnapshotRotation;

			public Vector3 InitialLocalPosition { get; private set; }

			public Quaternion InitialLocalRotation { get; private set; }

			public HeadBone(Transform t)
			{
			}

			public void PrepareBone(Transform baseTransform, List<SpineBone> bones, int index, bool flatten)
			{
			}

			internal Quaternion GetLocalRotationDiff()
			{
				return default;
			}

			public void SetCoordsForFrameForward()
			{
			}

			public void SetCoordsForFrameBackward()
			{
			}

			public void TakePoseSnapshot(Transform targetSpace, List<SpineBone> bones, int index, bool flatten)
			{
			}
		}

		[Serializable]
		public class SpineBone
		{
			public bool Collide;

			public float CollisionRadius;

			public Vector3 ColliderOffset;

			public Transform transform;

			public Vector3 ProceduralPosition;

			public Quaternion ProceduralRotation;

			public Vector3 HelperDiffPosition;

			public Quaternion HelperDiffRoation;

			public Vector3 PreviousPosition;

			public Vector3 DefaultForward;

			public float StraightenFactor;

			public float TargetStraightenFactor;

			private float boneLengthB;

			private float boneLengthF;

			private Vector3 boneLocalOffsetB;

			private Vector3 boneLocalOffsetF;

			public float MotionWeight;

			public Quaternion FinalRotation;

			public Vector3 FinalPosition;

			public Vector3 ManualPosOffset;

			public Quaternion ManualRotOffset;

			public Vector3 ReferencePosition;

			public Vector3 PreviousReferencePosition;

			public Quaternion ReferenceRotation;

			private Quaternion lastKeyframeRotation;

			private Vector3 lastKeyframePosition;

			private Vector3 lastFinalLocalPosition;

			private Quaternion lastFinalLocalRotation;

			public Vector3 forward;

			public Vector3 right;

			public Vector3 up;

			public float BoneLength { get; private set; }

			public Vector3 BoneLocalOffset { get; private set; }

			public Vector3 InitialLocalPosition { get; private set; }

			public Quaternion InitialLocalRotation { get; private set; }

			public float GetCollisionRadiusScaled()
			{
				return 0f;
			}

			public void UpdateReferencePosition(Vector3 pos)
			{
			}

			public void ZeroKeyframeCheck()
			{
			}

			public void RefreshFinalLocalPose()
			{
			}

			public SpineBone(Transform t)
			{
			}

			public void PrepareBone(Transform baseTransform, List<SpineBone> bones, int index)
			{
			}

			public void SetDistanceForFrameForward()
			{
			}

			public void SetDistanceForFrameBackward()
			{
			}

			public float GetUnscalledBoneLength()
			{
				return 0f;
			}

			private void PrepareAxes(Transform baseTransform, List<SpineBone> bonesList, int index)
			{
			}

			internal void CalculateDifferencePose(Vector3 upAxis, Vector3 rightAxis)
			{
			}

			internal void ApplyDifferencePose()
			{
			}

			public void Editor_SetLength(float length)
			{
			}
		}

		public enum EFixedMode
		{
			None = 0,
			Basic = 1,
			Late = 2
		}

		[CompilerGenerated]
		private sealed class _003CIEChangeValue_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float executionDelay;

			public float duration;

			public FSpineAnimator _003C_003E4__this;

			public EParamChange param;

			public float to;

			private float _003Celapsed_003E5__2;

			private float _003CstartVal_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CIEChangeValue_003Ed__89(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CLateFixed_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FSpineAnimator _003C_003E4__this;

			private WaitForFixedUpdate _003CfixedWait_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CLateFixed_003Ed__35(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private bool collisionInitialized;

		private bool forceRefreshCollidersData;

		[FPD_Percentage(0f, 1f, false, true, "%", false)]
		[Tooltip("You can use this variable to blend intensity of spinal animator motion over skeleton animation\n\nValue = 1: Animation with spinal Animator motion\nValue = 0: Only skeleton animation")]
		public float SpineAnimatorAmount;

		private Quaternion Rotate180;

		private int initAfterTPoseCounter;

		private bool fixedUpdated;

		private bool lateFixedIsRunning;

		private bool fixedAllow;

		private bool chainReverseFlag;

		public EFSpineEditorCategory _Editor_Category;

		public bool _Editor_PivotoffsetXYZ;

		private bool _editor_isQuitting;

		private int leadingBoneIndex;

		private int chainIndexDirection;

		private int chainIndexOffset;

		protected float delta;

		protected float unifiedDelta;

		protected float elapsedDeltaHelper;

		protected int updateLoops;

		private bool initialized;

		private Vector3 previousPos;

		private bool wasBlendedOut;

		private List<FSpineBoneConnector> connectors;

		private float referenceDistance;

		public Vector3 ModelForwardAxis;

		public Vector3 ModelForwardAxisScaled;

		public Vector3 ModelUpAxis;

		public Vector3 ModelUpAxisScaled;

		internal Vector3 ModelRightAxis;

		internal Vector3 ModelRightAxisScaled;

		public List<SpineBone> SpineBones;

		public List<Transform> SpineTransforms;

		private HeadBone frontHead;

		private HeadBone backHead;

		private HeadBone headBone;

		[Tooltip("Main character object - by default it is game object to which Spinal Animator is attached.\n\nYou can use it to control spine of character from different game object.")]
		public Transform BaseTransform;

		public Transform ForwardReference;

		[Tooltip("If your spine lead bone is in beggining of your hierarchy chain then toggle it.\n\nComponent's gizmos can help you out to define which bone should be leading (check head gizmo when you switch this toggle).")]
		public bool LastBoneLeading;

		[Tooltip("Sometimes spine chain can face in different direction than desired or you want your characters to move backward with spine motion.")]
		public bool ReverseForward;

		[Tooltip("If you're using 'Animate Physics' on animator you should set this variable to be enabled.")]
		public EFixedMode AnimatePhysics;

		public Transform AnchorRoot;

		[Tooltip("Connecting lead bone position to given transform, useful when it is tail and you already animating spine with other Spinal Animator component.")]
		public Transform HeadAnchor;

		[Tooltip("Letting head anchor to animate rotation")]
		public bool AnimateAnchor;

		[Tooltip("If you need to offset leading bone rotation.")]
		public Vector3 LeadBoneRotationOffset;

		[Tooltip("If Lead Bone Rotation Offset should affect reference pose or bone rotation")]
		public bool LeadBoneOffsetReference;

		[Tooltip("List of bone positioning/rotation fixers if using paws positioning with IK controlls disconnected out of arms/legs in the hierarchy")]
		public List<SpineAnimator_FixIKControlledBones> BonesFixers;

		[Tooltip("Useful when you use few spinal animators and want to rely on animated position and rotation by other spinal animator.")]
		public bool UpdateAsLast;

		public bool QueueToLastUpdate;

		[Tooltip("If corrections should affect spine chain children.")]
		public bool ManualAffectChain;

		[Tooltip("Often when you drop model to scene, it's initial pose is much different than animations, which causes problems, this toggle solves it at start.")]
		public bool StartAfterTPose;

		[Tooltip("If you want spinal animator to stop computing when choosed mesh is not visible in any camera view (editor's scene camera is detecting it too)")]
		public Renderer OptimizeWithMesh;

		[Tooltip("Delta Time for Spinal Animator calculations")]
		public EFDeltaType DeltaType;

		[Tooltip("Making update rate stable for target rate.\nIf this value is = 0 then update rate is unlimited.")]
		public float UpdateRate;

		[Tooltip("In some cases you need to use chain corrections, it will cost a bit more in performance, not much but always.")]
		public bool UseCorrections;

		[Tooltip("Sometimes offsetting model's pivot position gives better results using spinal animator, offset forward axis so front legs are in centrum and see the difference (generating additional transform inside hierarchy)")]
		public Vector3 MainPivotOffset;

		[Tooltip("Generating offset runtime only, allows you to adjust it on prefabs on scene")]
		public bool PivotOffsetOnStart;

		[Range(0f, 1f)]
		[Tooltip("If animation of changing segments position should be smoothed - creating a little gumy effect.")]
		public float PosSmoother;

		[Range(0f, 1f)]
		[Tooltip("If animation of changing segments rotation should be smoothed - making it more soft, but don't overuse it!")]
		public float RotSmoother;

		[Range(0f, 1f)]
		[Tooltip("We stretching segments to bigger value than bones are by default to create some extra effect which looks good but sometimes it can stretch to much if you using position smoothing, you can adjust it here.")]
		public float MaxStretching;

		[Tooltip("Making algorithm referencing back to static rotation if value = 0f | at 1 motion have more range and is more slithery.")]
		[Range(0f, 1f)]
		public float Slithery;

		[Range(1f, 91f)]
		[Tooltip("Limiting rotation angle difference between each segment of spine.")]
		public float AngleLimit;

		[Range(0f, 1f)]
		[Tooltip("Smoothing how fast limiting should make segments go back to marginal pose.")]
		public float LimitSmoother;

		[Range(0f, 15f)]
		[Tooltip("How fast spine should be rotated to straight pose when your character moves.")]
		public float StraightenSpeed;

		public bool TurboStraighten;

		[Tooltip("Spine going back to straight position constantly with choosed speed intensity.")]
		[Range(0f, 1f)]
		public float GoBackSpeed;

		[Tooltip("Elastic spring effect good for tails to make them more 'meaty'.")]
		[Range(0f, 1f)]
		public float Springiness;

		[Tooltip("How much effect on spine chain should have character movement.")]
		[Range(0f, 1f)]
		public float MotionInfluence;

		[Tooltip("Useful when your creature jumps on moving platform, so when platform moves spine is not reacting, by default world space is used (null).")]
		public Transform MotionSpace;

		[Tooltip("Fade rotations to sides or rotation up/down with this parameter - can be helpful for character jump handling")]
		public Vector2 RotationsFade;

		[SerializeField]
		[HideInInspector]
		private Transform mainPivotOffsetTransform;

		[Tooltip("<! Most models can not need this !> Offset for bones rotations, thanks to that animation is able to rotate to segments in a correct way, like from center of mass.")]
		public Vector3 SegmentsPivotOffset;

		[Tooltip("Multiplies distance value between bones segments - can be useful for use with humanoid skeletons")]
		public float DistancesMultiplier;

		[Tooltip("(Experimental) Makes possible LastBoneLeading + ReverseForward switching smoother")]
		public bool FlattenReferencePose;

		[Tooltip("Pushing segments in world direction (should have included ground collider to collide with).")]
		public Vector3 GravityPower;

		protected Vector3 gravityScale;

		[Tooltip("[Experimental] Using some simple calculations to make spine bend on colliders.")]
		public bool UseCollisions;

		public List<Collider> IncludedColliders;

		protected List<FImp_ColliderData_Base> IncludedCollidersData;

		protected List<FImp_ColliderData_Base> CollidersDataToCheck;

		[Tooltip("If disabled Colliders can be offsetted a bit in wrong way - check pink spheres in scene view (playmode, with true positions disabled colliders are fitting to stiff reference pose) - but it gives more stable collision projection! But to avoid stuttery you can increase position smoothing.")]
		public bool UseTruePosition;

		public Vector3 OffsetAllColliders;

		public AnimationCurve CollidersScale;

		public float CollidersScaleMul;

		[Range(0f, 1f)]
		public float DifferenceScaleFactor;

		[Tooltip("If you want to continue checking collision if segment collides with one collider (very useful for example when you using gravity power with ground)")]
		public bool DetailedCollision;

		[SerializeField]
		[HideInInspector]
		private bool _CheckedPivot;

		private bool updateSpineAnimator;

		private bool callSpineReposeCalculations;

		public string EditorIconPath => null;

		[Obsolete("Use SpineAnimatorAmount instead, but remember that it works in reversed way -> SpineAnimatorAmount 1 = BlendToOriginal 0  and  SpineAnimatorAmount 0 = BlendToOriginal 1")]
		public float BlendToOriginal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool EndBoneIsHead
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void RemovePivotOffset()
		{
		}

		public void UpdatePivotOffsetState()
		{
		}

		private void RestoreBasePivotChildren()
		{
		}

		private void PreMotionBoneOffsets()
		{
		}

		private void PreMotionNoHead()
		{
		}

		private void PreMotionHead()
		{
		}

		private void SegmentPreOffset(int i)
		{
		}

		private void SegmentPreOffsetWithPivot(int i)
		{
		}

		private void PostMotionBoneOffsets()
		{
		}

		private void PostMotionNoHead()
		{
		}

		private void PostMotionHead()
		{
		}

		private void SegmentPostOffset(int i)
		{
		}

		private void SegmentPostOffsetWithPivot(int i)
		{
		}

		private void BeginPhysicsUpdate()
		{
		}

		public void RefreshCollidersDataList()
		{
		}

		private float GetColliderSphereRadiusFor(int i)
		{
			return 0f;
		}

		public void AddCollider(Collider collider)
		{
		}

		private void InitColliders()
		{
		}

		public void CheckForColliderDuplicates()
		{
		}

		public void PushIfSegmentInsideCollider(SpineBone bone, ref Vector3 targetPoint)
		{
		}

		private void CalculateBonesCoordinates()
		{
		}

		private void CalculateTargetBonePosition(int index)
		{
		}

		private void CalculateTargetBoneRotation(int index)
		{
		}

		public void UpdateChainIndexHelperVariables()
		{
		}

		private void RefreshReferencePose()
		{
		}

		private void ReposeSpine()
		{
		}

		private void BeginBaseBonesUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CLateFixed_003Ed__35))]
		private IEnumerator LateFixed()
		{
			return null;
		}

		public void OnDestroy()
		{
		}

		private void OnValidate()
		{
		}

		public void AddConnector(FSpineBoneConnector connector)
		{
		}

		public void Init()
		{
		}

		public void CreateSpineChain(Transform start, Transform end)
		{
		}

		private void PreCalibrateBones()
		{
		}

		private void CalibrateBones()
		{
		}

		private void DeltaTimeCalculations()
		{
		}

		private void StableUpdateRateCalculations()
		{
		}

		private void ApplyNewBonesCoordinates()
		{
		}

		private void EndUpdate()
		{
		}

		public void OnDrop(PointerEventData data)
		{
		}

		private Vector3 RoundPosDiff(Vector3 pos, int digits = 1)
		{
			return default;
		}

		private Vector3 RoundToBiggestValue(Vector3 vec)
		{
			return default;
		}

		private float GetClampedSmoothDelta()
		{
			return 0f;
		}

		public List<Transform> GetOldSpineTransforms()
		{
			return null;
		}

		public void ClearOldSpineTransforms()
		{
		}

		public Transform FindBaseTransform()
		{
			return null;
		}

		public SpineBone GetLeadingBone()
		{
			return null;
		}

		public SpineBone GetEndBone()
		{
			return null;
		}

		public Transform GetHeadBone()
		{
			return null;
		}

		public SpineBone GetLeadBone()
		{
			return null;
		}

		public Transform GetBaseTransform()
		{
			return null;
		}

		public void User_ChangeParameter(EParamChange parameter, float to, float transitionDuration, float executionDelay = 0f)
		{
		}

		public void User_ChangeParameterAndRestore(EParamChange parameter, float to, float transitionDuration, float restoreAfter = 0f)
		{
		}

		public void User_ResetBones()
		{
		}

		[IteratorStateMachine(typeof(_003CIEChangeValue_003Ed__89))]
		private IEnumerator IEChangeValue(EParamChange param, float to, float duration, float executionDelay)
		{
			return null;
		}

		private float GetValue(EParamChange param)
		{
			return 0f;
		}

		private void SetValue(EParamChange param, float val)
		{
		}

		private void _ResetBones()
		{
		}

		private void Reset()
		{
		}

		private void Start()
		{
		}

		internal void Update()
		{
		}

		internal void FixedUpdate()
		{
		}

		internal void LateUpdate()
		{
		}
	}
}
