using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBulletDamageOnPlayerPosition : EnemyBulletBase
{
	[CompilerGenerated]
	private sealed class _003CManageLifeTime_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBulletDamageOnPlayerPosition _003C_003E4__this;

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
		public _003CManageLifeTime_003Ed__15(int _003C_003E1__state)
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

	public int Damage;

	public float DamageRadius;

	public bool OnPredictedPosition;

	public float AlertTime;

	public float DelayDamage;

	public int ExplosionSoundId;

	public int LifeTime;

	public short EffectId;

	public int AlertType;

	public ParticleSystem ParticleSystem;

	public MechPlayerController MechPlayerController;

	private BarsAlertComponent _attackAlertComponent;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	internal override void DeactivateBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifeTime_003Ed__15))]
	private IEnumerator ManageLifeTime()
	{
		return null;
	}

	private void ApplyExpandDamage(int damage)
	{
	}
}
