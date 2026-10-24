using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FIMSpace.FSpine;
using UnityEngine;

[DefaultExecutionOrder(-20)]
public class SpinalAnimationTool : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnableAfterDelay_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpinalAnimationTool _003C_003E4__this;

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
		public _003CEnableAfterDelay_003Ed__6(int _003C_003E1__state)
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

	public List<FSpineAnimator> SpinalParts;

	public float EnableDelay;

	private Coroutine _enableRoutine;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableAfterDelay_003Ed__6))]
	private IEnumerator EnableAfterDelay()
	{
		return null;
	}

	private void SetSpinalPartsEnabled(bool enabled)
	{
	}
}
