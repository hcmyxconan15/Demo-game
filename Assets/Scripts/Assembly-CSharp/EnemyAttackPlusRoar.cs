using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttackPlusRoar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackPlusRoar _003C_003E4__this;

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
		public _003CAttacking_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CInitComponent_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackPlusRoar _003C_003E4__this;

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
		public _003CInitComponent_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CRoarThenIncreaseSpeed_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackPlusRoar _003C_003E4__this;

		private NavMeshAgent _003Cagent_003E5__2;

		private float _003Cremaining_003E5__3;

		private float _003CrecoverRemaining_003E5__4;

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
		public _003CRoarThenIncreaseSpeed_003Ed__38(int _003C_003E1__state)
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

	public float ContinueAfterAttackTime;

	public bool AttackingPlayer;

	public int AttackVariant;

	[Header("Attack Alert")]
	public bool UseAttackAlert;

	public float AlertTime;

	public EnemyMovement EnemyMovement;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame (no overshoot).")]
	[SerializeField]
	private float RangeCheckInterval;

	[Header("Roar")]
	public float RoarInterval;

	public float RoarTime;

	public int RoarSound;

	[Header("Speed increase")]
	public float SpeedIncreaseStarDistance;

	public float SpeedIncreaseValue;

	public float SpeedIncreaseTime;

	public float RecoverTime;

	public CanvasGroup SpeedBarCanvasGroup;

	public CanvasGroup FullCanvasGroup;

	public ProgressBarPro SpeedBar;

	public ActiveAttacksByAnimatorEvent ActiveAttacksByAnimatorEvent;

	private const float TargetMoveThresholdSqr = 4f;

	private static readonly int Run;

	private int _attackVariant;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceToAttackSqr;

	private float _speedIncreaseStarDistanceSqr;

	private float _baseSpeed;

	private float _roarTimer;

	private bool _roarCycleActive;

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

	private void Attack()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__37))]
	private IEnumerator Attacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRoarThenIncreaseSpeed_003Ed__38))]
	private IEnumerator RoarThenIncreaseSpeed()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitComponent_003Ed__39))]
	private IEnumerator InitComponent()
	{
		return null;
	}

	private bool CanStartRoar()
	{
		return false;
	}

	private bool ShouldInterrupt()
	{
		return false;
	}

	private bool IsPlayerInRange()
	{
		return false;
	}

	private void EndRoarCycle()
	{
	}

	private void RestoreMovementState()
	{
	}

	private void SetSpeedBarActive(bool active)
	{
	}

	private void SetRun(bool running)
	{
	}
}
