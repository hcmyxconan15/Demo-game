using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChainLightning : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CJumpAround_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainLightning _003C_003E4__this;

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
		public _003CJumpAround_003Ed__8(int _003C_003E1__state)
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

	[Header("Bullet to shot")]
	public int BulletToTrowId;

	public int BounceCount;

	public int MinDistance;

	public int MaxDistance;

	private int _bounceCount;

	private EnemyBase _initialEnemy;

	private void OnEnable()
	{
	}

	private void SetDamageStats(DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount)
	{
	}

	[IteratorStateMachine(typeof(_003CJumpAround_003Ed__8))]
	private IEnumerator JumpAround()
	{
		return null;
	}
}
