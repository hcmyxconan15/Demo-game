using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMarkOnGround : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnableWithDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public EnemyMarkOnGround _003C_003E4__this;

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
		public _003CEnableWithDelay_003Ed__8(int _003C_003E1__state)
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

	public Vector3 Offset;

	public Transform TransformToFollow;

	public Transform TransformToToMove;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void EnableComponent()
	{
	}

	public void DisableComponent()
	{
	}

	private void FollowTargetTransformPosition()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableWithDelay_003Ed__8))]
	private IEnumerator EnableWithDelay(float delay)
	{
		return null;
	}
}
