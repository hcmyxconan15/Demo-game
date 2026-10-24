using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RumbleManager : MonoBehaviour
{
	public enum RumbleType
	{
		Weak = 0,
		Middle = 1,
		Strong = 2,
		LongStrong = 3
	}

	[CompilerGenerated]
	private sealed class _003CRumbleCoroutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float low;

		public float high;

		public float time;

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
		public _003CRumbleCoroutine_003Ed__5(int _003C_003E1__state)
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

	public List<RumbleSettings> RumbleSettings;

	public static RumbleManager Instance;

	private void Awake()
	{
	}

	public void Rumble(RumbleType rumbleType)
	{
	}

	[IteratorStateMachine(typeof(_003CRumbleCoroutine_003Ed__5))]
	private IEnumerator RumbleCoroutine(float low, float high, float time)
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
