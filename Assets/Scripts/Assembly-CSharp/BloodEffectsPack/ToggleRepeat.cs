using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BloodEffectsPack
{
	public class ToggleRepeat : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CToggle_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ToggleRepeat _003C_003E4__this;

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
			public _003CToggle_003Ed__4(int _003C_003E1__state)
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

		public float toggleDuration;

		public GameObject[] targetGameObjects;

		private Coroutine toggleCoroutine;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CToggle_003Ed__4))]
		private IEnumerator Toggle()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
