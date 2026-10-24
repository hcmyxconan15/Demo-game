using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GigalacertusAttackTriggers : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveDamageCollider_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GigalacertusAttackTriggers _003C_003E4__this;

		public int damageColliderToActivate;

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

	[CompilerGenerated]
	private sealed class _003CActiveParticles_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GigalacertusAttackTriggers _003C_003E4__this;

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
		public _003CActiveParticles_003Ed__10(int _003C_003E1__state)
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

	public BossGigalacertus BossGigalacertus;

	public Transform ParticlePosition;

	public Transform ParticlePosition1;

	public Transform ParticlePosition2;

	public GameObject AttackCollider;

	private void OnEnable()
	{
	}

	public void DamagePlayer(int damageColliderToActivate)
	{
	}

	public void LaunchRangeSpitAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CActiveDamageCollider_003Ed__8))]
	private IEnumerator ActiveDamageCollider(int damageColliderToActivate)
	{
		return null;
	}

	private void EnableDamageCollider(bool enable, int damageColliderToActivate)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveParticles_003Ed__10))]
	private IEnumerator ActiveParticles()
	{
		return null;
	}
}
