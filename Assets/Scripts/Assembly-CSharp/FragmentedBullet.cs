using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FragmentedBullet : DamageBase, IProjectileLifetimeTick
{
	[CompilerGenerated]
	private sealed class _003CSkillOnImpact_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FragmentedBullet _003C_003E4__this;

		public Collider impactCollider;

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
		public _003CSkillOnImpact_003Ed__24(int _003C_003E1__state)
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

	public bool PerpendicularToFloor;

	public short EffectId;

	public Rigidbody RigidBody;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	public float LifeTime;

	private float _lifeTime;

	private bool _hit;

	private bool _waitingDisable;

	private float _disableTimer;

	private Collider[] _colliders;

	private Vector3 _moveDirection;

	private bool _movementActive;

	[Header("Skill on impact")]
	public bool UseSkillOnImpact;

	public int SkillId;

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

	private void InitBullet()
	{
	}

	private void DeactivateByTime()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[IteratorStateMachine(typeof(_003CSkillOnImpact_003Ed__24))]
	private IEnumerator SkillOnImpact(Collider impactCollider)
	{
		return null;
	}

	private void SetDamageStatsToNewSkill(DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount)
	{
	}

	private void DisableBullet()
	{
	}
}
