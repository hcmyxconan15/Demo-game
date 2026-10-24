using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMantis : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyMantis _003C_003E4__this;

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
		public _003CAttacking_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CHeavyAttacking_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyMantis _003C_003E4__this;

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
		public _003CHeavyAttacking_003Ed__25(int _003C_003E1__state)
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

	public bool AttackingPlayer;

	[Header("Attack simple")]
	public float DistanceToAttack;

	public float AnimationTime;

	public Transform AttackTriggerPosition;

	[Header("Attack Heavy")]
	public float HeavyAttackCooldown;

	public float DistanceToHeavyAttack;

	public float HeavyAnimationTime;

	public Transform HeavyAttackTriggerPosition;

	public EnemyMovement EnemyMovement;

	public StatsEnemy StatsEnemy;

	public MantisAttackTriggers MantisAttackTriggers;

	private BarsAlertComponent _attackAlertComponent;

	private float _heavyAttackCooldown;

	private int _attackVariant;

	private void Awake()
	{
	}

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

	public void StopAttackMarks()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void OnDead()
	{
	}

	private void Attack()
	{
	}

	private void HeavyAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__24))]
	private IEnumerator Attacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHeavyAttacking_003Ed__25))]
	private IEnumerator HeavyAttacking()
	{
		return null;
	}
}
