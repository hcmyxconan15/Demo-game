using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeScene_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadScene _003C_003E4__this;

		public string sceneName;

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
		public _003CFadeScene_003Ed__8(int _003C_003E1__state)
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

	public Texture2D FadingTexture;

	public float FadeTime;

	private int drawDepth;

	private float _alpha;

	private int _fadeDirection;

	public void LoadNewScene(string sceneName)
	{
	}

	private void OnGUI()
	{
	}

	public void BeginFade(int direction)
	{
	}

	[IteratorStateMachine(typeof(_003CFadeScene_003Ed__8))]
	public IEnumerator FadeScene(string sceneName)
	{
		return null;
	}
}
