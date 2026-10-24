using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
	private enum AttackPositionState
	{
		None = 0,
		SideWaypoint = 1,
		FinalPoint = 2,
		Ready = 3
	}

	[CompilerGenerated]
	private sealed class _003CFaceTargetYaw_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyMovement _003C_003E4__this;

		public float maxDuration;

		private Transform _003Ctarget_003E5__2;

		private float _003CangularSpeed_003E5__3;

		private float _003Celapsed_003E5__4;

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
		public _003CFaceTargetYaw_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CUpdateDestinationRoutine_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyMovement _003C_003E4__this;

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
		public _003CUpdateDestinationRoutine_003Ed__73(int _003C_003E1__state)
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

	public bool IsMoving;

	public bool PatrolState;

	public float UpdateMovementTime;

	public EnemyBase EnemyBase;

	public NavMeshAgent NavMeshAgent;

	public NavMeshObstacle NavMeshObstacle;

	public Transform AttackAlertTransform;

	public bool UseMoveOffsetOnMaterial;

	public MoveOffsetOnMaterial MoveOffsetOnMaterial;

	[Header("Attack positioning")]
	[Tooltip("Use a side waypoint before entering attack range.")]
	public bool UseAttackPositioning;

	[Tooltip("Lateral distance from the direct route to the attack point.")]
	public float AttackPositionSideOffset;

	[Tooltip("Final distance from the player as a fraction of the attack range.")]
	[Range(0.2f, 0.9f)]
	public float AttackPositionDistanceFactor;

	[Tooltip("While positioning, stop and start the attack if the player is within this distance. 0 = use attack range.")]
	public float AttackEngageDistance;

	[Tooltip("Seconds before this enemy can use attack positioning again.")]
	public float AttackPositionCooldown;

	[Tooltip("Maximum time allowed to finish the positioning route.")]
	public float AttackPositionMaxDuration;

	private bool _stop;

	private bool _walking;

	private float _moveTime;

	private const float DestinationThresholdSqr = 4f;

	private const float NavMeshSampleRadius = 3f;

	private const float ReadyTimeout = 2f;

	private const float FaceTargetAngleTolerance = 0.5f;

	private const float DefaultFaceAngularSpeed = 300f;

	private const int EliteAvoidancePriority = 0;

	private static readonly int Walk1;

	private static readonly WaitForSeconds WaitDestinationOnscreen;

	private static readonly WaitForSeconds WaitDestinationOffscreen;

	private int _defaultAvoidancePriority;

	private bool _forceDestinationUpdate;

	private AttackPositionState _attackPositionState;

	private Vector3 _attackSideWaypoint;

	private Vector3 _attackFinalPoint;

	private float _attackPositionStartTime;

	private float _attackPositionReadyTime;

	private float _nextAttackPositionTime;

	private float _attackEngageDistanceSqr;

	private float _baseSpeed;

	private float _speedMultiplier;

	private bool _hasBaseSpeed;

	private bool _updateDestination;

	public bool IsPositioningForAttack => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void OnEnableActivation()
	{
	}

	public virtual void StopMovement(bool stop)
	{
	}

	public void SetMovementSuppressed(bool suppressed)
	{
	}

	public virtual void RandomPositionOnMapToMove()
	{
	}

	public virtual void MoveToPositionIgnoringPlayer(Vector3 position)
	{
	}

	public virtual void ResumeChasePlayer()
	{
	}

	public virtual void StopEnemyInPlace(bool stop)
	{
	}

	public virtual void EnableNavMesh(bool enable)
	{
	}

	[IteratorStateMachine(typeof(_003CFaceTargetYaw_003Ed__51))]
	public IEnumerator FaceTargetYaw(float maxDuration = 1f)
	{
		return null;
	}

	public void SetSpeedMultiplier(float multiplier)
	{
	}

	private void CacheBaseSpeed()
	{
	}

	private void RefreshAgentSpeed()
	{
	}

	public void DisableNavigationOnDeath()
	{
	}

	public void RequestImmediateDestinationUpdate()
	{
	}

	public bool TryStartAttackPositioning(float attackRange)
	{
		return false;
	}

	public bool ConsumeAttackPositionReady()
	{
		return false;
	}

	public void CancelAttackPositioning()
	{
	}

	private void UpdateAttackPositioning()
	{
	}

	private bool TryBuildAttackPositionRoute(float attackRange)
	{
		return false;
	}

	private bool HasReachedAttackPosition(Vector3 position)
	{
		return false;
	}

	private bool IsPlayerWithinEngageDistance()
	{
		return false;
	}

	private void MarkAttackPositionReady()
	{
	}

	private void CancelAttackPositioningInternal(bool applyCooldown)
	{
	}

	private void ResetAttackPositioningState()
	{
	}

	private static bool TrySampleNavMesh(Vector3 intendedPosition, out Vector3 sampledPosition)
	{
		sampledPosition = default;
		return false;
	}

	private void Walk(bool walk)
	{
	}

	private void ResumeMovementOnStart()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateDestinationRoutine_003Ed__73))]
	private IEnumerator UpdateDestinationRoutine()
	{
		return null;
	}
}
