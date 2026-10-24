using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyAttackControllerRange : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyAttackControllerRange _003C_003E4__this;

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
		public _003CAttacking_003Ed__19(int _003C_003E1__state)
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

	public float AttackTimeCooldown;

	public float DistanceToAttack;

	public float AnimationTime;

	public float AlertTime;

	public string AttackName;

	public EnemyAttackControllerDistance EnemyAttackControllerDistance;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame (no overshoot).")]
	[SerializeField]
	private float RangeCheckInterval;

	private BarsAlertComponent _barsAlertComponent;

	private const float TargetMoveThresholdSqr = 4f;

	private int _attackVariant;

	private float _attackTimeCooldown;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceToAttackSqr;

	private void Awake()
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

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__19))]
	private IEnumerator Attacking()
	{
		return null;
	}
}
