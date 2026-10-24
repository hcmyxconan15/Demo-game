using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveGameOverPanelCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverUi _003C_003E4__this;

		public bool win;

		public float delayTime;

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
		public _003CActiveGameOverPanelCoroutine_003Ed__8(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CActiveGameWinPanelCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameOverUi _003C_003E4__this;

		public float delayTime;

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
		public _003CActiveGameWinPanelCoroutine_003Ed__9(int _003C_003E1__state)
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

	[SerializeField]
	private CanvasGroup WinGamePanel;

	[SerializeField]
	private CanvasGroup CanvasGroupGameOverPanel;

	public WeaponDamageResult WeaponDamageResultPanel;

	public EndPanelResult EndPanelResult;

	public GameControllers GameControllers;

	public void ActiveWinGamePanel(float delayTime)
	{
	}

	public void ActiveGameOverPanel(float delayTime)
	{
	}

	private void ActiveCanvasGroup(CanvasGroup canvasGroup, bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CActiveGameOverPanelCoroutine_003Ed__8))]
	private IEnumerator ActiveGameOverPanelCoroutine(float delayTime, bool win)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CActiveGameWinPanelCoroutine_003Ed__9))]
	private IEnumerator ActiveGameWinPanelCoroutine(float delayTime)
	{
		return null;
	}
}
