using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyBulletBallistics : EnemyBulletBase
{
	[CompilerGenerated]
	private sealed class _003CSimulateProjectile_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBulletBallistics _003C_003E4__this;

		public Vector3 target;

		public Transform launchTransform;

		public float launchAngle;

		private Vector3 _003CtargetPos_003E5__2;

		private float _003Cg_003E5__3;

		private float _003Ct_003E5__4;

		private Vector3 _003Cpos_003E5__5;

		private Vector3 _003Cvel_003E5__6;

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
		public _003CSimulateProjectile_003Ed__17(int _003C_003E1__state)
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

	public int EffectId;

	public int EffectIdOnRobot;

	public int PlusDamage;

	public int RicochetCount;

	public float LaunchAngle;

	public float LaunchAngleMax;

	public float DamageRadius;

	public int MarkId;

	public Transform Projectile;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	private int _ricochetCount;

	public MechPlayerController MechPlayerController;

	private BarsAlertComponent _attackAlertComponent;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	internal override void Shot(Transform launchTransform, Vector3 target)
	{
	}

	[IteratorStateMachine(typeof(_003CSimulateProjectile_003Ed__17))]
	private IEnumerator SimulateProjectile(Transform launchTransform, Vector3 target, float launchAngle = 45f)
	{
		return null;
	}

	internal override void DeactivateBullet()
	{
	}

	private void ApplyExpandDamage(int damage)
	{
	}
}
