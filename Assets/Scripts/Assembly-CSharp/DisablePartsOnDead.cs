using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DisablePartsOnDead : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDetachPartsOnDead_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisablePartsOnDead _003C_003E4__this;

		private List<DetachableParts>.Enumerator _003C_003E7__wrap1;

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
		public _003CDetachPartsOnDead_003Ed__3(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public List<DetachableParts> DetachableParts;

	private void OnEnable()
	{
	}

	public void DisableParts()
	{
	}

	[IteratorStateMachine(typeof(_003CDetachPartsOnDead_003Ed__3))]
	private IEnumerator DetachPartsOnDead()
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
