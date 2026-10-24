using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpiderMovementController : MovementController
{
	[CompilerGenerated]
	private sealed class _003CIncreaseSpeedCoroutineEffect_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpiderMovementController _003C_003E4__this;

		public float time;

		public float speedToIncrease;

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
		public _003CIncreaseSpeedCoroutineEffect_003Ed__108(int _003C_003E1__state)
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
	private sealed class _003CStarDash_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpiderMovementController _003C_003E4__this;

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
		public _003CStarDash_003Ed__103(int _003C_003E1__state)
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

	private const float RotationInputThreshold = 0.01f;

	private const float MovementInputThreshold = 0.1f;

	private const float GroundedStickVelocity = -2f;

	private const float DashFloorNormalY = 0.85f;

	private const int GroundLayer = 9;

	private const int BlockingLayerMask = 512;

	public int RotationSpeed;

	public CharacterController CharacterController;

	private float _horizontal;

	private float _vertical;

	private float _verticalVelocity;

	[SerializeField]
	private bool TurnLeft;

	[SerializeField]
	private bool TurnRight;

	private Vector3 _forward;

	private Vector3 _right;

	private Vector3 _move;

	private Quaternion _targetRotation;

	private float _lastHorizontal;

	private float _lastVertical;

	[Header("Speed increase")]
	public List<ParticleSystem> SpeedParticleSystems;

	[Header("TypeB Mouse Movement")]
	[Tooltip("Distance from player to start moving towards mouse")]
	public float MouseMoveStartThreshold;

	[Tooltip("Distance from player to stop moving (should be less than start threshold)")]
	public float MouseMoveStopThreshold;

	private Vector3 _mouseWorldPosition;

	private bool _isMovingTowardsMouse;

	[Header("Dash")]
	public float DashCooldownOriginal;

	public float DashCooldown;

	public float DashTime;

	public float DashDistance;

	public float DashContactAvoidTime;

	public bool Dashing;

	public ProgressBarPro ProgressBarProDash;

	public CanvasGroup CanvasGroupDash;

	public List<ParticleSystem> DashParticleSystems;

	public List<ParticleSystem> DriftParticleSystems;

	private Vector3 _dashDirection;

	private float _baseDashCooldown;

	private float _dashCooldown;

	private int _dashActiveLastValue;

	private bool _isRecharging;

	private bool _dashInputBuffered;

	private float _dashContactImmuneUntil;

	private Coroutine _dashCoroutine;

	private int _lastDisplayedCurrentDashCharges;

	private int _lastDisplayedMaxDashCharges;

	private float _cachedStepOffset;

	private int _obstacleStepBlockCount;

	private readonly RaycastHit[] _dashCastHits;

	private readonly Collider[] _dashOverlapColliders;

	private Vector3 _lastPosition;

	private bool _inputMovement;

	private bool _wasInMoveState;

	private bool _locomotionTriggersReady;

	private float _stationaryLingerEndTime;

	private float _stationarySinceTime;

	public override bool IsDashContactImmune => false;

	public bool IsMovingForOverloadTriggers => false;

	private bool HasMovementInput => false;

	public bool IsStationaryLingerActive => false;

	public bool IsEffectivelyStationaryForBonuses => false;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void TypeAMovement()
	{
	}

	private void TypeBMovement()
	{
	}

	private void CurrentVelocitySpeed()
	{
	}

	private void HandleMovement()
	{
	}

	public override void Move()
	{
	}

	public override void Rotate()
	{
	}

	public override void SetDash(float dashTimer, int baseDashCharges = 1)
	{
	}

	private void ManageMovementTriggers()
	{
	}

	private void MarkStationaryStart()
	{
	}

	private void BeginStationaryLingerIfNeeded()
	{
	}

	public void ManageDash()
	{
	}

	private bool ShouldShowDashCooldownBar()
	{
		return false;
	}

	public override void Dash()
	{
	}

	private void HandleDashInput()
	{
	}

	private bool WasDashPressedThisFrame()
	{
		return false;
	}

	private void TryStartDash()
	{
	}

	private void SyncDashReloadTime()
	{
	}

	private void SyncDashChargeCapacity()
	{
	}

	private void StartDashRecharge()
	{
	}

	private void ConsumeDashCharge()
	{
	}

	private void UpdateDashIconsIfNeeded(bool forceUpdate = false)
	{
	}

	public override Quaternion GetInputDirection()
	{
		return default;
	}

	public override void IncreaseSpeedByTime(float speed, float time)
	{
	}

	public override void ActiveDashParticles(bool active)
	{
	}

	public override void ActiveDriftParticles(bool active)
	{
	}

	public Vector3 ClampMotionAgainstRocks(Vector3 motion)
	{
		return default;
	}

	public void BeginObstacleStepBlock()
	{
	}

	public void EndObstacleStepBlock()
	{
	}

	private Vector3 ClampDashMotion(Vector3 motion)
	{
		return default;
	}

	private void SetObstacleFrameStepOffset(bool blockedByObstacle)
	{
	}

	private static bool IsBlockingObstacle(Collider collider)
	{
		return false;
	}

	private void GetDashCapsulePoints(out Vector3 bottom, out Vector3 top)
	{
		bottom = default;
		top = default;
	}

	private bool TryGetDashBlockingDistance(Vector3 bottom, Vector3 top, float castRadius, Vector3 direction, float distance, out float hitDistance)
	{
		hitDistance = default;
		return false;
	}

	private bool DashOverlapWouldPushUp(Vector3 bottom, Vector3 top, Vector3 dashDirection)
	{
		return false;
	}

	private void ApplyDashStepOffset()
	{
	}

	private void RestoreDashStepOffset()
	{
	}

	[IteratorStateMachine(typeof(_003CStarDash_003Ed__103))]
	private IEnumerator StarDash()
	{
		return null;
	}

	private void EndDash()
	{
	}

	public override void CancelDash()
	{
	}

	private void UiDashAnimation(int endValue)
	{
	}

	private void RestartComponent()
	{
	}

	[IteratorStateMachine(typeof(_003CIncreaseSpeedCoroutineEffect_003Ed__108))]
	private IEnumerator IncreaseSpeedCoroutineEffect(float speedToIncrease, float time)
	{
		return null;
	}
}
