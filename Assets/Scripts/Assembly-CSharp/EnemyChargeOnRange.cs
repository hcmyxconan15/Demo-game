using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyChargeOnRange : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyChargeOnRange _003C_003E4__this;

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
		public _003CAttacking_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CChargingToForward_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyChargeOnRange _003C_003E4__this;

		public Vector3 direction;

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
		public _003CChargingToForward_003Ed__33(int _003C_003E1__state)
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

	public bool InCharge;

	public bool AttackingPlayer;

	public bool Charging;

	public bool StartCharging;

	public float AnimationTime;

	public float DistanceCharge;

	public float DistanceToAttack;

	public float ChargeSpeed;

	public float ChargeTime;

	public EnemyMovement EnemyMovement;

	public StatsEnemy StatsEnemy;

	public GameObject AttackCollider;

	public Transform AlertBarPosition;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame (no overshoot).")]
	[SerializeField]
	private float RangeCheckInterval;

	private const float TargetMoveThresholdSqr = 4f;

	private const float ChargeMinDistanceSqr = 4f;

	private BarsAlertComponent _barsAlertComponent;

	private float _pushStartTime;

	private Vector3 _pushDirection;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceChargeSqr;

	private float _distanceToAttackSqr;

	private static readonly int Charging1;

	private void Start()
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

	private void ForceEndCharge()
	{
	}

	private void ChargeToPosition(Vector3 direction)
	{
	}

	[IteratorStateMachine(typeof(_003CChargingToForward_003Ed__33))]
	private IEnumerator ChargingToForward(Vector3 direction)
	{
		return null;
	}

	private void Attack()
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__35))]
	private IEnumerator Attacking()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
