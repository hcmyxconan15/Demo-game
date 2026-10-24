using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : EnemyBase
{
	[CompilerGenerated]
	private sealed class _003CSpawnNewEnemy_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemySpawner _003C_003E4__this;

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
		public _003CSpawnNewEnemy_003Ed__17(int _003C_003E1__state)
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

	public bool Active;

	public int EnemyToSpawn;

	public float SpawnTimeInterval;

	public int SpawnActiveEnemy;

	public int SpawnActiveMax;

	public Transform PositionToSpawn;

	public Transform DeadBody;

	public Transform NormalBody;

	public List<ParticleSystem> ParticleSystemList;

	private static readonly int Spawn1;

	private float _spawnTimeInterval;

	private void Update()
	{
	}

	public override void ActiveEnemy(Vector3 position)
	{
	}

	public void ChangeModelOnDead()
	{
	}

	private void CheckCurrentEnemyActive()
	{
	}

	private int GetActiveEnemyOfId()
	{
		return 0;
	}

	private void Spawn(int enemyId)
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnNewEnemy_003Ed__17))]
	private IEnumerator SpawnNewEnemy()
	{
		return null;
	}
}
