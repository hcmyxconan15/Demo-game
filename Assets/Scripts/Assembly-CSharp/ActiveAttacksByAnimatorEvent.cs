using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActiveAttacksByAnimatorEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveDamageCollider_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActiveAttacksByAnimatorEvent _003C_003E4__this;

		public int index;

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
		public _003CActiveDamageCollider_003Ed__8(int _003C_003E1__state)
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

	public List<AttackSetting> AttackSetting;

	private BarsAlertComponent _attackAlertComponent;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void ForceHideAlertsAndDamageColliders()
	{
	}

	public void ShowAttackAlert(int index)
	{
	}

	public void DamagePlayer(int index)
	{
	}

	public void ParticleEffect(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveDamageCollider_003Ed__8))]
	private IEnumerator ActiveDamageCollider(int index)
	{
		return null;
	}

	private void EnableDamageCollider(bool enable, int index)
	{
	}
}
