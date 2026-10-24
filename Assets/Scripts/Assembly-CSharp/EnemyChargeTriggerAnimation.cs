using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyChargeTriggerAnimation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveDamageCollider_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyChargeTriggerAnimation _003C_003E4__this;

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
		public _003CActiveDamageCollider_003Ed__6(int _003C_003E1__state)
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

	public EnemyChargeOnRange EnemyChargeOnRange;

	public GameObject AttackCollider;

	private void OnEnable()
	{
	}

	public void StartCharge()
	{
	}

	public void DamagePlayer()
	{
	}

	public void ParticleEffect(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveDamageCollider_003Ed__6))]
	private IEnumerator ActiveDamageCollider()
	{
		return null;
	}

	private void EnableDamageCollider(bool enable)
	{
	}
}
