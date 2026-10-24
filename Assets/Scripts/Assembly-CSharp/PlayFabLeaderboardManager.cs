using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayFabLeaderboardManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForPlayFabLogin_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayFabLeaderboardManager _003C_003E4__this;

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
		public _003CWaitForPlayFabLogin_003Ed__7(int _003C_003E1__state)
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

	private const string s_leaderboardName = "HighScore";

	public PlayFabLeaderboardDisplay PlayFabLeaderboardDisplay;

	public bool s_initialized;

	public bool InitAttemptCompleted;

	public static PlayFabLeaderboardManager Instance;

	private void Awake()
	{
	}

	public void Init()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForPlayFabLogin_003Ed__7))]
	private IEnumerator WaitForPlayFabLogin()
	{
		return null;
	}

	public void UpdateScore(int score)
	{
	}
}
