using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CopterFighter : DamageBase
{
	[CompilerGenerated]
	private sealed class _003CEndCopterAttacks_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public CopterFighter _003C_003E4__this;

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
		public _003CEndCopterAttacks_003Ed__23(int _003C_003E1__state)
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

	public bool Active;

	public bool Elevate;

	public bool Shot;

	public float LiveTime;

	public float Speed;

	public float DistanceAboveFloor;

	public LayerMask GroundLayer;

	public List<WeaponJoin> WeaponJoins;

	public List<Transform> TurretStartPosition;

	public MechPlayerController MechPlayerController;

	public Transform DistanceCheck;

	public Weapon Weapon;

	private float _initialDistance;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ActiveCopter()
	{
	}

	private void ActiveCopter(Weapon weapon)
	{
	}

	private void ConfigureCopter(Weapon weapon, int level)
	{
	}

	private void ShotCopterWeapons()
	{
	}

	private void KeepCopterOnGround()
	{
	}

	private void DisableCopter()
	{
	}

	[IteratorStateMachine(typeof(_003CEndCopterAttacks_003Ed__23))]
	private IEnumerator EndCopterAttacks(float seconds)
	{
		return null;
	}
}
