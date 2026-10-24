using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class NewWeaponsTutorial : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartWeaponTutorialCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NewWeaponsTutorial _003C_003E4__this;

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
		public _003CStartWeaponTutorialCoroutine_003Ed__6(int _003C_003E1__state)
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

	public int LevelToTriggerWeaponTutorial;

	public List<Button> SkillsButtons;

	public List<GameObject> GameObjectsToDisable;

	private bool _canContinue;

	public void ShowNewWeaponTutorial()
	{
	}

	public void CloseNewWeaponTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CStartWeaponTutorialCoroutine_003Ed__6))]
	private IEnumerator StartWeaponTutorialCoroutine()
	{
		return null;
	}
}
