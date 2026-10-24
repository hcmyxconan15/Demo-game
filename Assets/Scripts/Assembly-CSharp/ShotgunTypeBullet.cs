using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShotgunTypeBullet : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CInstantiateBullets_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShotgunTypeBullet _003C_003E4__this;

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
		public _003CInstantiateBullets_003Ed__4(int _003C_003E1__state)
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
	private sealed class _003CInstantiateIgnoreCollidersBullets_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShotgunTypeBullet _003C_003E4__this;

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
		public _003CInstantiateIgnoreCollidersBullets_003Ed__5(int _003C_003E1__state)
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

	public int BulletShotgunToTrowId;

	public List<Transform> LaunchPointPositions;

	public bool UseIgnoreTypeBullets;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CInstantiateBullets_003Ed__4))]
	private IEnumerator InstantiateBullets()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInstantiateIgnoreCollidersBullets_003Ed__5))]
	private IEnumerator InstantiateIgnoreCollidersBullets()
	{
		return null;
	}

	private void SetDamageStats(DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount, int ricochetCount)
	{
	}
}
