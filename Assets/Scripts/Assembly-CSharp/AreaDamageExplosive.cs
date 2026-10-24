using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class AreaDamageExplosive : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CApplyExpandDamageCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AreaDamageExplosive _003C_003E4__this;

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
		public _003CApplyExpandDamageCoroutine_003Ed__8(int _003C_003E1__state)
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

	public float DamageRadius;

	public float DamageDelay;

	[FormerlySerializedAs("ShowDamageText")]
	public bool DontShowDamageText;

	public LayerMask RayCasterLayer;

	public ParticleSystem BulletParticleSystem;

	private static readonly WaitForSeconds _waitForDisable;

	private void OnEnable()
	{
	}

	private void DisableBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CApplyExpandDamageCoroutine_003Ed__8))]
	private IEnumerator ApplyExpandDamageCoroutine()
	{
		return null;
	}
}
