using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class HowToAddSkillsTutorial : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowChipsTutorial_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HowToAddSkillsTutorial _003C_003E4__this;

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
		public _003CShowChipsTutorial_003Ed__15(int _003C_003E1__state)
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

	public CanvasGroup CanvasGroup;

	public RectTransform TutorialPanel;

	public GameObject SkillsUiToFocus;

	public GameObject StatUiToFocus;

	public List<Button> SkillsButtons;

	public List<GameObject> GameObjectsToDisable;

	private bool _canContinue;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void StartHowToAddChipTutorial()
	{
	}

	public void Continue()
	{
	}

	private void HideHowToAddSkillsTutorial()
	{
	}

	private void FocusSkillsArea()
	{
	}

	public void RestoreFocusSkillArea()
	{
	}

	private static void RestorePanelAfterChipTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CShowChipsTutorial_003Ed__15))]
	private IEnumerator ShowChipsTutorial()
	{
		return null;
	}
}
