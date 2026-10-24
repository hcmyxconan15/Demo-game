using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpiderRobotAttackController : EnemyRobotAttackController
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpiderRobotAttackController _003C_003E4__this;

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
		public _003CAttacking_003Ed__12(int _003C_003E1__state)
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

	[Tooltip("When true, turret keeps rotating toward target while shooting (like Boss). When false, turret is locked during shoot.")]
	[SerializeField]
	private bool FollowDuringShootTime;

	[SerializeField]
	private bool UseIndividualTurretAlert;

	public bool TriggerTurretAlert;

	public int AlertId;

	private BarsAlertComponent _barsAlertComponent;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	protected override void RotateTurretIfNeeded()
	{
	}

	protected override void Attack()
	{
	}

	protected override void ForceStopAttacking()
	{
	}

	protected override bool UsingTurrets()
	{
		return false;
	}

	private bool EffectiveShootingTurrets()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__12))]
	private IEnumerator Attacking()
	{
		return null;
	}
}
