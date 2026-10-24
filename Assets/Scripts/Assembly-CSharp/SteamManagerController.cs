using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using TMPro;
using UnityEngine;

public class SteamManagerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamManagerController _003C_003E4__this;

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
		public _003CStart_003Ed__5(int _003C_003E1__state)
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

	public string SteamUserName;

	public TextMeshProUGUI SteamUserNameText;

	protected Callback<GameOverlayActivated_t> m_GameOverlayActivated;

	private void OnEnable()
	{
	}

	private void OnGameOverlayActivated(GameOverlayActivated_t pCallback)
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__5))]
	private IEnumerator Start()
	{
		return null;
	}
}
