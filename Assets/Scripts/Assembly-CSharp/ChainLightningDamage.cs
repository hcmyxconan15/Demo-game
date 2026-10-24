using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChainLightningDamage : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CChainLightningDamageEnemies_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainLightningDamage _003C_003E4__this;

		private EnemyBase _003Cenemy_003E5__2;

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
		public _003CChainLightningDamageEnemies_003Ed__13(int _003C_003E1__state)
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

	public int BounceCount;

	public int MinDistance;

	public int MaxDistance;

	public LightningSystemChainCustom LightningSystemChain;

	private int _bounceCount;

	private Transform _initialTransform;

	private EnemyBase _initialEnemy;

	private EnemyBase _lastChainedEnemy;

	private HashSet<EnemyBase> _visitedEnemies;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void RestartComponent()
	{
	}

	private void DisableBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CChainLightningDamageEnemies_003Ed__13))]
	private IEnumerator ChainLightningDamageEnemies()
	{
		return null;
	}
}
