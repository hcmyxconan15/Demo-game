using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MechPlayerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CContactPushRoutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MechPlayerController _003C_003E4__this;

		public float pushDuration;

		public float pushDistance;

		public Vector3 pushDirection;

		public float rotationSpeed;

		public float rotationDirection;

		public float controlDisableTime;

		private TopWeaponAiming[] _003CtopWeaponAimings_003E5__2;

		private CharacterController _003CcharacterController_003E5__3;

		private SpiderMovementController _003CspiderMovement_003E5__4;

		private float _003Celapsed_003E5__5;

		private float _003CpushSpeed_003E5__6;

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
		public _003CContactPushRoutine_003Ed__45(int _003C_003E1__state)
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

	public bool CanControl;

	public Camera MainPlayerCamera;

	public CanvasGroup PlayerUiInGameCanvas;

	public PlayerBuffStatusUi PlayerBuffStatusUi;

	public Stats Stats;

	public MovementController MovementController;

	public RobotParts RobotParts;

	public TurretController TurretController;

	public InputController InputController;

	public AnimatorController AnimatorController;

	public PlayerDamageEffects PlayerDamageEffects;

	public GameControllers GameControllers;

	public ParticleSystem LevelUpParticleSystem;

	public ParticleSystem HealParticleSystem;

	public DirectionMarkersController DirectionMarkersController;

	public InteractionsController InteractionsController;

	public Transform FollowPlayerPositionTransform;

	private bool _mainMenuRobotVisualSnapshotValid;

	private int _mainUiSnapPilotId;

	private int _mainUiSnapMechId;

	private int _mainUiSnapBaseType;

	private int _mainUiSnapBaseId;

	private int _mainUiSnapBodyId;

	private string _mainUiSnapWeaponsKey;

	private string _mainUiSnapPilotSkillsKey;

	private Coroutine _contactPushCoroutine;

	private bool _contactPushBlockingStep;

	public static MechPlayerController Instance;

	public bool IsContactPushing => false;

	public bool IsDashContactImmune => false;

	private void Awake()
	{
	}

	public void SetInitialRobot()
	{
	}

	private void InitRobot(MechData mechData)
	{
	}

	public void SetInitialRobotUiOnMain(MechData mechData)
	{
	}

	public void ShowPlayerUiInGame(bool show, float delay = 0f)
	{
	}

	private static string BuildLoadoutKey(List<int> weapons, int droneId)
	{
		return null;
	}

	private static string BuildPilotSkillsUnlockedKey(int pilotId)
	{
		return null;
	}

	private bool MainUiMechVisualFingerprintChanged(MechData mechData, string weaponsKey)
	{
		return false;
	}

	private void StoreMainMenuRobotSnapshot(MechData mechData, string weaponsKey, string pilotSkillsKey)
	{
	}

	private void OnDisable()
	{
	}

	public void ApplyContactPush(Vector3 pushDirection, float pushDistance, float pushDuration, float controlDisableTime, float rotationSpeed, bool randomizeRotationDirection)
	{
	}

	private void BeginContactPushStepBlock()
	{
	}

	private void EndContactPushStepBlock()
	{
	}

	[IteratorStateMachine(typeof(_003CContactPushRoutine_003Ed__45))]
	private IEnumerator ContactPushRoutine(Vector3 pushDirection, float pushDistance, float pushDuration, float controlDisableTime, float rotationSpeed, float rotationDirection)
	{
		return null;
	}
}
