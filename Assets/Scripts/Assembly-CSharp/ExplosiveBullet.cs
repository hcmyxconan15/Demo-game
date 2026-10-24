using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ExplosiveBullet : DamageBase, IProjectileLifetimeTick
{
	[CompilerGenerated]
	private sealed class _003CRicochet_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExplosiveBullet _003C_003E4__this;

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
		public _003CRicochet_003Ed__35(int _003C_003E1__state)
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

	private const float HitLingerTime = 3f;

	public float DamageRadius;

	public LayerMask RayCasterLayer;

	public bool PerpendicularToFloor;

	public short EffectId;

	public short EffectIdNotDecay;

	public Rigidbody RigidBody;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	public bool InstantDestroy;

	public bool UsePhysicsMovement;

	public ManageTrails ManageTrails;

	public float LifeTime;

	private float _lifeTime;

	private bool _hit;

	private bool _waitingDisable;

	private float _disableTimer;

	private Collider[] _colliders;

	private Vector3 _moveDirection;

	private bool _movementActive;

	private float _currentSpeed;

	[SerializeField]
	private float RicochetAngle;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void TickProjectileLifetime(float deltaTime)
	{
	}

	private void SetCollidersEnabled(bool value)
	{
	}

	private void InitBullet(float speed)
	{
	}

	private void LaunchWithPhysics(float speed)
	{
	}

	private void StopPhysicsMovement()
	{
	}

	private void DeactivateByTime()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public override void ApplyExpandDamage()
	{
	}

	public void ApplyExpandDamageAirEffect()
	{
	}

	private void DisableBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CRicochet_003Ed__35))]
	private IEnumerator Ricochet()
	{
		return null;
	}
}
