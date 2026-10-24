using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBulletLighting : EnemyBulletBase
{
	[CompilerGenerated]
	private sealed class _003CApplyImpact_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBulletLighting _003C_003E4__this;

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
		public _003CApplyImpact_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CLiveThenDisable_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBulletLighting _003C_003E4__this;

		private float _003Ctime_003E5__2;

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
		public _003CLiveThenDisable_003Ed__14(int _003C_003E1__state)
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

	public LightningSystemChainCustom LightningSystemChain;

	public int PlusDamage;

	public float DamageRadius;

	public float ImpactDelay;

	public int EffectId;

	public int EffectId2;

	public float Duration;

	public float FadeOut;

	private Transform _launchPosition;

	private Vector3 _impactPosition;

	private Vector3 _lockedEnd;

	private Coroutine _lifeRoutine;

	private Coroutine _lifeApplyImpact;

	internal override void Shot(Transform launchPosition, Vector3 targetPosition)
	{
	}

	[IteratorStateMachine(typeof(_003CLiveThenDisable_003Ed__14))]
	private IEnumerator LiveThenDisable()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CApplyImpact_003Ed__15))]
	private IEnumerator ApplyImpact()
	{
		return null;
	}

	protected override void OnBulletDisabled()
	{
	}

	internal override void DeactivateBullet()
	{
	}
}
