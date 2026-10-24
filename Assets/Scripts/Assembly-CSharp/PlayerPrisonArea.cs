using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerPrisonArea : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActivePrison_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerPrisonArea _003C_003E4__this;

		public float prisonTime;

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
		public _003CActivePrison_003Ed__15(int _003C_003E1__state)
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

	public int Id;

	public float ActiveTime;

	public float HideTimeAnimation;

	public float UpValue;

	public Transform PrisonTransform;

	public List<ParticleSystem> ParticleSystems;

	public List<Transform> WallsTransforms;

	public List<Collider> WallsCollider;

	public List<Vector3> WallRotation;

	private void Awake()
	{
	}

	public void PrisonPlayerByTime(float time)
	{
	}

	private void ActivePrison()
	{
	}

	private void InitPrison()
	{
	}

	private void EndPrison()
	{
	}

	private void ActiveWallColliders(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CActivePrison_003Ed__15))]
	private IEnumerator ActivePrison(float prisonTime)
	{
		return null;
	}
}
