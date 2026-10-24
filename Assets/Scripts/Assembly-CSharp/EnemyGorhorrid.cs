using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyGorhorrid : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyGorhorrid _003C_003E4__this;

		public string animationName;

		public float animationTime;

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
	private sealed class _003CRangeAttacking_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyGorhorrid _003C_003E4__this;

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
		public _003CRangeAttacking_003Ed__25(int _003C_003E1__state)
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

	[Header("Attack_0")]
	public float Attack0MinDistance;

	public float Attack0MaxDistance;

	public float Attack0AnimationTime;

	[Header("Attack_1")]
	public float Attack1MinDistance;

	public float Attack1MaxDistance;

	public float Attack1AnimationTime;

	[Header("Attack range")]
	public float DistanceToRangeAttack;

	public float RangeAttackCooldown;

	public float RangeAnimationTime;

	public float RangeAlertTime;

	public EnemyMovement EnemyMovement;

	public StatsEnemy StatsEnemy;

	public ActiveAttacksByAnimatorEvent ActiveAttacksByAnimatorEvent;

	private float _rangeAttackCooldown;

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

	private static bool IsInDistanceRange(float distance, float minDistance, float maxDistance)
	{
		return false;
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void CancelAttack()
	{
	}

	private void Attack(string animationName, float animationTime)
	{
	}

	private void RangeAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__24))]
	private IEnumerator Attacking(string animationName, float animationTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRangeAttacking_003Ed__25))]
	private IEnumerator RangeAttacking()
	{
		return null;
	}
}
