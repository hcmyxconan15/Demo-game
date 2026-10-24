using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ThrowSimulation : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSimulateProjectile_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ThrowSimulation _003C_003E4__this;

		private Vector3 _003Cvelocity_003E5__2;

		private float _003Cg_003E5__3;

		private float _003Ctime_003E5__4;

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
		public _003CSimulateProjectile_003Ed__7(int _003C_003E1__state)
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

	public Transform Projectile;

	public Transform Target;

	public Transform Launcher;

	public float LaunchAngle;

	public float Speed;

	public bool UseHighArc;

	[ContextMenu("Test Shot")]
	private void TestShot()
	{
	}

	[IteratorStateMachine(typeof(_003CSimulateProjectile_003Ed__7))]
	private IEnumerator SimulateProjectile()
	{
		return null;
	}

	public static bool SolveBallisticArcFixedAngle(Vector3 start, Vector3 end, float launchAngleDegrees, out Vector3 resultVelocity, out float requiredSpeed)
	{
		resultVelocity = default;
		requiredSpeed = default;
		return false;
	}

	public static bool SolveBallisticArcFixedAngleAndSpeed(Vector3 start, Vector3 end, float speed, float launchAngleDegrees, out Vector3 resultVelocity)
	{
		resultVelocity = default;
		return false;
	}
}
