using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BulletTurret : EnemyTurret
{
	[CompilerGenerated]
	private sealed class _003CStartAttackCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BulletTurret _003C_003E4__this;

		private int _003CturretIndex_003E5__2;

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
		public _003CStartAttackCoroutine_003Ed__11(int _003C_003E1__state)
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

	public int BulletRounds;

	public float TargetAngleX;

	public float RotationTime;

	public List<Transform> TurretLaunchTransforms;

	public Animator TurretAnimator;

	public List<ParticleSystem> ParticleEffects;

	public List<BarsAlertComponent> _attackAlertComponents;

	private static readonly int Shoot;

	private void Awake()
	{
	}

	public override void LaunchAttack(bool useAlert)
	{
	}

	public override void CancelAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAttackCoroutine_003Ed__11))]
	private IEnumerator StartAttackCoroutine()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
