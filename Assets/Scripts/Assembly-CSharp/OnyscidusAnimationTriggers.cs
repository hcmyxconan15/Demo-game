using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnyscidusAnimationTriggers : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveDamageCollider_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnyscidusAnimationTriggers _003C_003E4__this;

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
		public _003CActiveDamageCollider_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CActiveJumpDamageCollider_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnyscidusAnimationTriggers _003C_003E4__this;

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
		public _003CActiveJumpDamageCollider_003Ed__11(int _003C_003E1__state)
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

	public EnemyOnyscidus EnemyOnyscidus;

	public GameObject AttackCollider;

	public GameObject AttackCollider1;

	public GameObject BigAttackCollider;

	private void OnEnable()
	{
	}

	public void CancelAttack()
	{
	}

	public void StartCharge()
	{
	}

	public void EndJumping()
	{
	}

	public void JumpAttackLand()
	{
	}

	public void DamagePlayer(int damageColliderToActivate)
	{
	}

	public void ParticleEffect(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveJumpDamageCollider_003Ed__11))]
	private IEnumerator ActiveJumpDamageCollider()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CActiveDamageCollider_003Ed__12))]
	private IEnumerator ActiveDamageCollider(int damageColliderToActivate)
	{
		return null;
	}

	private void EnableDamageCollider(bool enable, int damageColliderToActivate)
	{
	}
}
