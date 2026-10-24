using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackControllerJumpDistance : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerJumpDistance _003C_003E4__this;

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
		public _003CAttacking_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CDelayFirstAttack_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerJumpDistance _003C_003E4__this;

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
		public _003CDelayFirstAttack_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CDisplace_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerJumpDistance _003C_003E4__this;

		private Vector3 _003CdisplacePosition_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

		private float _003CdisplacementDuration_003E5__4;

		private float _003CelapsedTime_003E5__5;

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
		public _003CDisplace_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CRunFollowThrough_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerJumpDistance _003C_003E4__this;

		public Vector3 followPosition;

		private NavMeshAgent _003Cagent_003E5__2;

		private float _003Celapsed_003E5__3;

		private float _003CreachSqr_003E5__4;

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
		public _003CRunFollowThrough_003Ed__41(int _003C_003E1__state)
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

	public float DistanceToAttack;

	public float DisplaceDistance;

	public float DisplaceSpeed;

	[Tooltip("After the jump, run this far past the player's position at jump start, then chase again.")]
	public float OvershootDistance;

	public EnemyMovement EnemyMovement;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame.")]
	[SerializeField]
	private float RangeCheckInterval;

	private const float NavMeshSampleRadius = 1.5f;

	private const int DisplaceSampleSteps = 5;

	private const float TargetMoveThresholdSqr = 4f;

	private const float FollowThroughStoppingDistance = 0.4f;

	private const float FollowThroughTimeout = 2f;

	private const float FollowThroughReachDistance = 0.75f;

	private const float AttackCooldown = 0.7f;

	private const float SpawnAttackDelay = 4f;

	private static readonly int AttackState;

	private bool _attacking;

	private bool _displaced;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceToAttackSqr;

	private bool _followThroughActive;

	private bool _hasSavedStoppingDistance;

	private float _savedStoppingDistance;

	private Vector3 _jumpLockedPlayerPosition;

	private Vector3 _jumpForward;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private bool ShouldEvaluateRangeToTarget()
	{
		return false;
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void InterruptAttack()
	{
	}

	private void CleanupAttack()
	{
	}

	private bool AbortAttackIfDead()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CDelayFirstAttack_003Ed__35))]
	private IEnumerator DelayFirstAttack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__36))]
	private IEnumerator Attacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDisplace_003Ed__37))]
	private IEnumerator Displace()
	{
		return null;
	}

	private void CacheJumpTarget()
	{
	}

	private bool TryGetDisplacePosition(out Vector3 displacePosition)
	{
		displacePosition = default;
		return false;
	}

	private bool TryGetFollowThroughPosition(out Vector3 followPosition)
	{
		followPosition = default;
		return false;
	}

	[IteratorStateMachine(typeof(_003CRunFollowThrough_003Ed__41))]
	private IEnumerator RunFollowThrough(Vector3 followPosition)
	{
		return null;
	}

	private void ResumeAgentAtCurrentPosition()
	{
	}

	private void EndFollowThrough()
	{
	}
}
