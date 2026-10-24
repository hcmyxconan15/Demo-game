using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyOnyscidus : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyOnyscidus _003C_003E4__this;

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
		public _003CAttacking_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CChargingToForward_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyOnyscidus _003C_003E4__this;

		public Vector3 direction;

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
		public _003CChargingToForward_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CJumpForwardAttack_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyOnyscidus _003C_003E4__this;

		public Vector3 direction;

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
		public _003CJumpForwardAttack_003Ed__55(int _003C_003E1__state)
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

	public bool CanUseChargeAttack;

	public float ChargeCoolDown;

	public bool InCharge;

	public bool AttackingPlayer;

	public bool Charging;

	public bool StartCharging;

	public float AnimationTime;

	public float DistanceCharge;

	public float DistanceToAttack;

	public float ChargeSpeed;

	public float ChargeTime;

	public int AttackVariant;

	[Header("Jump attack")]
	public bool CanUseJumpAttack;

	public float JumpCoolDown;

	public bool InJump;

	public bool Jumping;

	public bool StartJumping;

	public float JumpAttackTime;

	public float JumpSpeed;

	public float JumpDistanceToAttack;

	public Transform JumpTriggerPosition;

	public EnemyMovement EnemyMovement;

	public StatsEnemy StatsEnemy;

	public SphereCollider AttackCollider;

	public Transform AlertBarPosition;

	public Transform AttackTriggerPosition;

	public AudioClip AudioClipRoar;

	public OnyscidusAnimationTriggers OnyscidusAnimationTriggers;

	private BarsAlertComponent _barsAlertComponent;

	private BarsAlertComponent _attackAlertComponent;

	private float _pushStartTime;

	private Vector3 _pushDirection;

	private int _attackVariant;

	private bool _deathHandled;

	private static readonly int Charging1;

	private static readonly int Release;

	private static readonly int Dead0;

	private static readonly int Dead1;

	private float _chargeCoolDown;

	private float _jumpCoolDown;

	private void Awake()
	{
	}

	private void Start()
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

	private void LateUpdate()
	{
	}

	private static bool IsDeathState(Animator animator)
	{
		return false;
	}

	public void StopAttackMarks()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void ForceEndCharge()
	{
	}

	private void ChargeToPosition(Vector3 direction)
	{
	}

	[IteratorStateMachine(typeof(_003CChargingToForward_003Ed__51))]
	private IEnumerator ChargingToForward(Vector3 direction)
	{
		return null;
	}

	private void Attack()
	{
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__53))]
	private IEnumerator Attacking()
	{
		return null;
	}

	private void JumpAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CJumpForwardAttack_003Ed__55))]
	private IEnumerator JumpForwardAttack(Vector3 direction)
	{
		return null;
	}

	private bool IsDead()
	{
		return false;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DetectRotationDirection(Quaternion beforeRotation, Quaternion afterRotation)
	{
	}
}
