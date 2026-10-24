using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AreaDamageRandomTargetOnRange : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CManageLifeTime_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AreaDamageRandomTargetOnRange _003C_003E4__this;

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

	public float DelayDamage;

	public float DamageRadius;

	public float SearchRadius;

	public float ForwardOffset;

	public LayerMask RayCasterLayer;

	public ParticleSystem ParticleSystem;

	public float LifeTime;

	[Tooltip("Use this to avoid search enemy, instantiate the ray on the activation position")]
	public bool UseActivationPosition;

	[Header("Explosion sound")]
	public int ExplosionSoundId;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifeTime_003Ed__10))]
	private IEnumerator ManageLifeTime()
	{
		return null;
	}

	public override void ApplyExpandDamage()
	{
	}
}
