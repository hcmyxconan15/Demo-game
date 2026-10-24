using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MultipleBulletPlayerPosition : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CInstantiateBullets_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultipleBulletPlayerPosition _003C_003E4__this;

		private List<Transform>.Enumerator _003C_003E7__wrap1;

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
		public _003CInstantiateBullets_003Ed__4(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int BulletShotgunToTrowId;

	public float TimerBetweenBullets;

	public List<Transform> LaunchPointPositions;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CInstantiateBullets_003Ed__4))]
	private IEnumerator InstantiateBullets()
	{
		return null;
	}

	private void SetDamageStats(DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount)
	{
	}
}
