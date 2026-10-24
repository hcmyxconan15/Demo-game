using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaDamageLeftOnGround : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CManageLifeTime_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AreaDamageLeftOnGround _003C_003E4__this;

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
		public _003CManageLifeTime_003Ed__11(int _003C_003E1__state)
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

	public float DelayDamage;

	public int DamageTicks;

	public float DamageTimeActive;

	public float DamageTimeBetweenTicks;

	public float DamageRadius;

	public LayerMask RayCasterLayer;

	public ParticleSystem ParticleSystem;

	public float LifeTime;

	private int _damageTick;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifeTime_003Ed__11))]
	private IEnumerator ManageLifeTime()
	{
		return null;
	}

	public override void ApplyExpandDamage()
	{
	}
}
