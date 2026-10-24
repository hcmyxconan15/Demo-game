using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeteorFall : EnemyBulletBase
{
	[CompilerGenerated]
	private sealed class _003CLaunchSingleAttack_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vector3 attackPosition;

		public MeteorFall _003C_003E4__this;

		private BarsAlertComponent _003CalertComponent_003E5__2;

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
		public _003CLaunchSingleAttack_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CLaunchingAttack_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeteorFall _003C_003E4__this;

		private Vector3 _003CfuturePosition_003E5__2;

		private List<Vector3> _003CusedPositions_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CLaunchingAttack_003Ed__17(int _003C_003E1__state)
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

	public int AttacksAtOnce;

	public float MinSpreadDistance;

	public float MaxSpreadDistance;

	public float MinDistanceBetweenMeteors;

	public float DelayBetweenSameTimeAttacks;

	public float AlertTime;

	public float TimeBetweenAttacks;

	private int _repeatTimes;

	private int _pendingAttacks;

	private readonly List<BarsAlertComponent> _activeAlerts;

	private void OnEnable()
	{
	}

	internal override void DeactivateBullet()
	{
	}

	protected override void OnBulletDisabled()
	{
	}

	private void ClearActiveAlerts()
	{
	}

	[IteratorStateMachine(typeof(_003CLaunchingAttack_003Ed__17))]
	private IEnumerator LaunchingAttack()
	{
		return null;
	}

	private Vector3 GetValidRandomPosition(Vector3 center, List<Vector3> usedPositions)
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CLaunchSingleAttack_003Ed__19))]
	private IEnumerator LaunchSingleAttack(Vector3 attackPosition)
	{
		return null;
	}
}
