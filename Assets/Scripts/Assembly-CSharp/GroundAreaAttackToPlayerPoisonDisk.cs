using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GroundAreaAttackToPlayerPoisonDisk : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLaunchSingleAttack_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector3 attackPosition;

		public GroundAreaAttackToPlayerPoisonDisk _003C_003E4__this;

		private BarsAlertComponent _003CattackAlertComponent_003E5__2;

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
		public _003CLaunchSingleAttack_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CLaunchingAttack_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GroundAreaAttackToPlayerPoisonDisk _003C_003E4__this;

		private Vector3[] _003Cpositions_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CLaunchingAttack_003Ed__11(int _003C_003E1__state)
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

	public int AlertId;

	public int BulletId;

	public int RepeatTimes;

	public float AlertTime;

	public float TimeBetweenAttacks;

	public float Radius;

	public float MinDistanceBetweenDisks;

	public float MinDistanceFromLauncher;

	public EnemyBase EnemyBase;

	private const int RelocateRingAttempts = 8;

	public void StartAttack(EnemyBase enemyBase)
	{
	}

	[IteratorStateMachine(typeof(_003CLaunchingAttack_003Ed__11))]
	private IEnumerator LaunchingAttack()
	{
		return null;
	}

	private void RelocatePositionsOffLauncher(Vector3[] positions)
	{
	}

	private Vector3 RelocateAwayFromLauncher(Vector3 original, Vector3 launcherPosition, int index, Vector3[] acceptedPositions)
	{
		return default;
	}

	private static bool OverlapsAcceptedDisk(Vector3 candidate, Vector3[] positions, int currentIndex, float minDistanceSq)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CLaunchSingleAttack_003Ed__15))]
	private IEnumerator LaunchSingleAttack(Vector3 attackPosition)
	{
		return null;
	}
}
