using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class HealPlayerInArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CManageLifeTime_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HealPlayerInArea _003C_003E4__this;

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
		public _003CManageLifeTime_003Ed__10(int _003C_003E1__state)
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

	public float HealValue;

	public float HealTimeActive;

	public float HealTicks;

	public float HealRadius;

	public ParticleSystem HealEffect;

	public MechPlayerController MechPlayerController;

	private float _healTimeBetweenTicks;

	private float _healTicks;

	public UnityEvent EndHealing;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifeTime_003Ed__10))]
	private IEnumerator ManageLifeTime()
	{
		return null;
	}

	private void HealPlayer(int healAmount)
	{
	}

	private void DeactivateHealing()
	{
	}
}
