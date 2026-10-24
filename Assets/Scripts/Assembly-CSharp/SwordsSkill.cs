using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SwordsSkill : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CAttackingEnemy_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SwordsSkill _003C_003E4__this;

		private bool _003CrandomSwingDirection_003E5__2;

		private Vector3 _003CeffectPosition_003E5__3;

		private Quaternion _003CeffectRotation_003E5__4;

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
		public _003CAttackingEnemy_003Ed__35(int _003C_003E1__state)
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

	public bool Attacking;

	public float SwordFollowSpeed;

	public float SwordTargetRadius;

	public MechPlayerController MechPlayerController;

	public PositionToFollow PositionToFollow;

	public Transform SwordLaser;

	public ParticleSystem SwordParticle;

	public BoxCollider Collider;

	public Transform SwordTransform;

	public float MoveDuration;

	public float SwingDuration;

	public float ReturnDuration;

	public float SwingAngle;

	public List<DetachablePart> DetachableParts;

	[Header("Enemies")]
	public EnemyBase SelectedNearestTarget;

	private Vector3 _difference;

	private EnemyBase _nearestTarget;

	private Vector3 _originalRotation;

	private float _searchTimer;

	private float _distance;

	private float _distanceToRobot;

	private float _changeFollowSpeed;

	private bool _swingStart;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void AttackTarget()
	{
	}

	private void GetPositionToFollow()
	{
	}

	private void KeepSwordCloseToRobot()
	{
	}

	private EnemyBase GetMoreCloseEnemy(float minDistance, float maxDistance)
	{
		return null;
	}

	private void ActivateSword()
	{
	}

	private void DeActivateSword()
	{
	}

	private void ActivateCollider(bool activate)
	{
	}

	private void DisableBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CAttackingEnemy_003Ed__35))]
	private IEnumerator AttackingEnemy()
	{
		return null;
	}
}
