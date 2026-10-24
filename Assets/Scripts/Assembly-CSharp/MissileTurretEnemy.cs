using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MissileTurretEnemy : EnemyTurret
{
	[CompilerGenerated]
	private sealed class _003CStartAttackCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MissileTurretEnemy _003C_003E4__this;

		private int _003ClaunchPosition_003E5__2;

		private int _003CmissileCount_003E5__3;

		private int _003Cindex_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CStartAttackCoroutine_003Ed__6(int _003C_003E1__state)
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

	public List<MissileSettings> MissileSettingsList;

	public List<Transform> TurretLaunchTransforms;

	private List<BarsAlertComponent> _attackAlertComponents;

	private void Awake()
	{
	}

	public override void LaunchAttack(bool useAlert)
	{
	}

	public override void CancelAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAttackCoroutine_003Ed__6))]
	private IEnumerator StartAttackCoroutine()
	{
		return null;
	}

	private Vector3 GetRandomPointInCircle(Vector3 center, float radius)
	{
		return default;
	}

	private void OnDisable()
	{
	}
}
