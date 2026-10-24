using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyRobotAttackController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBulletsAttacking_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyRobotAttackController _003C_003E4__this;

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
		public _003CBulletsAttacking_003Ed__32(int _003C_003E1__state)
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

	public bool ActivePart;

	public bool AttackingPlayer;

	public bool CanRotate;

	public float DistanceToAttack;

	public float RotationSpeed;

	public float RotationSpeedDuringAttack;

	public float AttackTelegrafTime;

	public Transform TurretTransform;

	public EnemyMovement EnemyMovement;

	public List<EnemyTurret> EnemyTurrets;

	protected static readonly WaitForSeconds WaitAfterAttack;

	protected static readonly WaitForSeconds WaitBeforeResume;

	protected static readonly WaitForSeconds WaitTurretCheck;

	protected static readonly WaitForSeconds WaitShort;

	protected WaitForSeconds _waitTelegraf;

	protected float _distanceToAttackSqr;

	[Header("Range check")]
	[Tooltip("Seconds between range evaluations. 0 = every frame (no overshoot).")]
	[SerializeField]
	private float RangeCheckInterval;

	private const float TargetMoveThresholdSqr = 4f;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	protected void ResetRangeEvaluationThrottle()
	{
	}

	protected bool ShouldEvaluateRangeToTarget()
	{
		return false;
	}

	protected virtual void RotateTurretIfNeeded()
	{
	}

	public void ActiveAttacksTurrets(EnemyMovement enemyMovement)
	{
	}

	protected virtual void Attack()
	{
	}

	protected bool HandleAttackPositioning(float sqrDist)
	{
		return false;
	}

	protected virtual void ForceStopAttacking()
	{
	}

	protected virtual bool UsingTurrets()
	{
		return false;
	}

	protected virtual bool FirstShot()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CBulletsAttacking_003Ed__32))]
	protected virtual IEnumerator BulletsAttacking()
	{
		return null;
	}
}
