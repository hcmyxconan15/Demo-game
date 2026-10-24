using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundAreaAttackToPlayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLaunchingAttack_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GroundAreaAttackToPlayer _003C_003E4__this;

		private BarsAlertComponent _003CattackAlertComponent_003E5__2;

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
		public _003CLaunchingAttack_003Ed__8(int _003C_003E1__state)
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

	public int AlertId;

	public int BulletId;

	public int RepeatTimes;

	public float AlertTime;

	public float TimeBetweenAttacks;

	public EnemyBase EnemyBase;

	private int _repeatTimes;

	public void StartAttack(EnemyBase enemyBase)
	{
	}

	[IteratorStateMachine(typeof(_003CLaunchingAttack_003Ed__8))]
	private IEnumerator LaunchingAttack()
	{
		return null;
	}
}
