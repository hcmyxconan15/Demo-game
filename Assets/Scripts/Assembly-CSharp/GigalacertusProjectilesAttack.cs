using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GigalacertusProjectilesAttack : EnemyTurret
{
	[CompilerGenerated]
	private sealed class _003CStartAttackCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GigalacertusProjectilesAttack _003C_003E4__this;

		private int _003Cloop_003E5__2;

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
		public _003CStartAttackCoroutine_003Ed__12(int _003C_003E1__state)
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

	private const float LandingGroundY = 0.3f;

	public bool LaunchTheProjectiles;

	public int MuzzlesEffectId;

	public List<Transform> TurretLaunchTransforms;

	public int ProjectileLoops;

	public float TimeBetweenLoops;

	public float MinLandingRadius;

	public float MaxLandingRadius;

	public float MinLandingSeparation;

	private readonly List<Vector3> _landingPositions;

	public override void LaunchAttack(bool useAlert)
	{
	}

	public override void CancelAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CStartAttackCoroutine_003Ed__12))]
	private IEnumerator StartAttackCoroutine()
	{
		return null;
	}

	private void LaunchVolley()
	{
	}
}
