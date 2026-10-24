using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BossKingSpawn : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossKingSpawn _003C_003E4__this;

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
		public _003CAttacking_003Ed__17(int _003C_003E1__state)
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

	public bool AttackingPlayer;

	public float DistanceToAttackToMeleeAttack;

	public float AnimationTime;

	public int AttackVariant;

	public BossKingSpawnSimpleAttack BossKingSpawnSimpleAttack;

	public AudioClip AudioClipRoar;

	public EnemyMovement EnemyMovement;

	public StatsEnemy StatsEnemy;

	private BarsAlertComponent _attackAlertComponent;

	private float _timerCooldown;

	private int _attackVariant;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void StopAttackMarks()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void Attack()
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__17))]
	private IEnumerator Attacking()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
