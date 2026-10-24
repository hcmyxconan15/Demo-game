using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BasicTurret : EnemyTurret
{
	[CompilerGenerated]
	private sealed class _003CStartAttackCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BasicTurret _003C_003E4__this;

		public bool useAlert;

		private int _003CturretIndex_003E5__2;

		private BarsAlertComponent _003CalertComponent_003E5__3;

		private float _003Celapsed_003E5__4;

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
		public _003CStartAttackCoroutine_003Ed__13(int _003C_003E1__state)
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

	public bool UsePitchSweep;

	public float TargetAngleX;

	public float RotationTime;

	public List<Transform> TurretLaunchTransforms;

	public Animator TurretAnimator;

	public List<ParticleSystem> ParticleEffects;

	public Transform AlertTransformParent;

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

	[IteratorStateMachine(typeof(_003CStartAttackCoroutine_003Ed__13))]
	private IEnumerator StartAttackCoroutine(bool useAlert)
	{
		return null;
	}

	private void ResetPitchSweep()
	{
	}

	private void OnDisable()
	{
	}
}
