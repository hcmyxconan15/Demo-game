using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;

public class KeyboardRebindController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CClearInputBlockAfterKeyRelease_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeyboardRebindController _003C_003E4__this;

		private Keyboard _003Ckeyboard_003E5__2;

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
		public _003CClearInputBlockAfterKeyRelease_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CStartListeningDelayed_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KeyboardRebindSlot slot;

		public KeyboardRebindController _003C_003E4__this;

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
		public _003CStartListeningDelayed_003Ed__21(int _003C_003E1__state)
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

	public MenuNavigation MenuNavigation;

	public List<KeyboardRebindSlot> Slots;

	private readonly InputMapper _inputMapper;

	private KeyboardRebindSlot _listeningSlot;

	private Coroutine _listenCoroutine;

	private Coroutine _releaseBlockCoroutine;

	private bool _menuNavigationWasActive;

	private bool _suppressStoppedHandling;

	public bool IsListening { get; private set; }

	public bool BlocksMenuInput { get; private set; }

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RefreshAll()
	{
	}

	public void BeginRebind(KeyboardRebindSlot slot)
	{
	}

	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__21))]
	private IEnumerator StartListeningDelayed(KeyboardRebindSlot slot)
	{
		return null;
	}

	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	public void CancelListening()
	{
	}

	public void RestoreDefaults()
	{
	}

	private void StopListening()
	{
	}

	private void ClearListeningSlotVisual()
	{
	}

	private void StartReleaseInputBlock()
	{
	}

	private void ClearReleaseInputBlock()
	{
	}

	[IteratorStateMachine(typeof(_003CClearInputBlockAfterKeyRelease_003Ed__30))]
	private IEnumerator ClearInputBlockAfterKeyRelease()
	{
		return null;
	}

	private void PauseMenuNavigation()
	{
	}

	private void ResumeMenuNavigation()
	{
	}

	private void SyncAllCompanions()
	{
	}

	private static void SyncCompanionAction(KeyboardRebindSlot slot, ControllerMap keyboardMap)
	{
	}
}
