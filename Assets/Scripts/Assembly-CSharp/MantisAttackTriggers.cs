using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MantisAttackTriggers : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveDamageCollider_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MantisAttackTriggers _003C_003E4__this;

		public int damageColliderToActivate;

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
		public _003CActiveDamageCollider_003Ed__18(int _003C_003E1__state)
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

	public EnemyMantis EnemyMantis;

	public GameObject AttackCollider;

	public GameObject AttackCollider1;

	public int RockAttackId;

	public float MinLaunchRadius;

	public float MaxLaunchRadius;

	public float MinRockSeparation;

	public int RockCount;

	public GameObject AttackCollider2;

	private void OnEnable()
	{
	}

	public void CancelAttack()
	{
	}

	public void DamagePlayer(int damageColliderToActivate)
	{
	}

	public void LaunchRocks()
	{
	}

	private Vector3 PickRockTarget(Vector3 center, List<Vector3> placed, float minSeparationSqr)
	{
		return default;
	}

	private Vector3 GetRandomRockTarget(Vector3 center)
	{
		return default;
	}

	private static bool IsFarEnough(Vector3 candidate, List<Vector3> placed, float minSeparationSqr)
	{
		return false;
	}

	private static float GetMinDistanceSqr(Vector3 candidate, List<Vector3> placed)
	{
		return 0f;
	}

	private void EnableDamageCollider(bool enable, int damageColliderToActivate)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveDamageCollider_003Ed__18))]
	private IEnumerator ActiveDamageCollider(int damageColliderToActivate)
	{
		return null;
	}
}
