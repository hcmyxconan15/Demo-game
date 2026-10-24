using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class PillarComponent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPilarLifeTime_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PillarComponent _003C_003E4__this;

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
		public _003CPilarLifeTime_003Ed__9(int _003C_003E1__state)
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

	public Transform PillarTransform;

	public DOTweenAnimation DoTweenAnimation;

	public List<ParticleSystem> ParticleSystemsToLoop;

	public GameObject GameObjectCollider;

	private Vector3 _initialPosition;

	private void Awake()
	{
	}

	[ContextMenu("Active pillar")]
	public void ActivePillar()
	{
	}

	[ContextMenu("DisablePillar pillar")]
	public void DisablePillar()
	{
	}

	[IteratorStateMachine(typeof(_003CPilarLifeTime_003Ed__9))]
	private IEnumerator PilarLifeTime()
	{
		return null;
	}
}
