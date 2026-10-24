using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialControllerMainMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEnableCloseButtonAfterDelay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialControllerMainMenu _003C_003E4__this;

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
		public _003CEnableCloseButtonAfterDelay_003Ed__10(int _003C_003E1__state)
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

	public static TutorialControllerMainMenu Instance;

	public bool TutorialActive;

	public TutorialController.Tutorials TutorialRunning;

	public MainMenuJoystick MainMenuJoystick;

	[Header("Tutorial HowToEvolveWeapons")]
	public HowToEvolveWeaponsTutorial HowToEvolveWeaponsTutorial;

	public float MinSecondsBeforeClose;

	private float _canCloseAtUnscaledTime;

	private void Awake()
	{
	}

	public void ShowHowToEvolveWeaponsTutorial()
	{
	}

	public void CloseHowToEvolveWeaponsTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableCloseButtonAfterDelay_003Ed__10))]
	private IEnumerator EnableCloseButtonAfterDelay()
	{
		return null;
	}
}
