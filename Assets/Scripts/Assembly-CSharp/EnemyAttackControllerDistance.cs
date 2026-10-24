using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyAttackControllerDistance : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerDistance _003C_003E4__this;

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
	private sealed class _003CHandleAttackDisplacement_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerDistance _003C_003E4__this;

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
		public _003CHandleAttackDisplacement_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CInitComponent_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerDistance _003C_003E4__this;

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
		public _003CInitComponent_003Ed__40(int _003C_003E1__state)
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

	public float AnimationTime;

	public float ContinueAfterAttackTime;

	public bool AttackingPlayer;

	public int AttackVariant;

	public bool DisplaceOnAttack;

	public float DisplaceDistance;

	public float DisplaceSpeed;

	public ParticleSystem ActiveTrailOnAttack;

	public bool ActiveAttackOnDash;

	public GameObject AttackGameObject;

	[Header("Attack Alert")]
	public bool UseAttackAlert;

	public float AlertTime;

	[Header("Attack Alert line")]
	public bool UseAttackAlertLine;

	public int AlertLineId;

	public EnemyMovement EnemyMovement;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame (no overshoot).")]
	[SerializeField]
	private float RangeCheckInterval;

	private const float NavMeshSampleRadius = 1.5f;

	private const int DisplaceSampleSteps = 5;

	private const float TargetMoveThresholdSqr = 4f;

	private int _attackVariant;

	private BarsAlertComponent _barsAlertComponent;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceToAttackSqr;

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

	private void InterruptAttack()
	{
	}

	private void CleanupAttackState()
	{
	}

	private void HideAlert()
	{
	}

	private bool AbortAttackIfDead()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__37))]
	private IEnumerator Attacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHandleAttackDisplacement_003Ed__38))]
	private IEnumerator HandleAttackDisplacement()
	{
		return null;
	}

	private bool TryGetDisplacePosition(out Vector3 displacePosition)
	{
		displacePosition = default;
		return false;
	}

	[IteratorStateMachine(typeof(_003CInitComponent_003Ed__40))]
	private IEnumerator InitComponent()
	{
		return null;
	}
}
