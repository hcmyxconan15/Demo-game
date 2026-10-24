using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PilotUiController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PilotUiController _003C_003E4__this;

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
		public _003CStart_003Ed__15(int _003C_003E1__state)
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

	public int PilotSelected;

	public CanvasGroup PilotCanvas;

	public CanvasGroup SelectorCanvasGroup;

	public GameObject LockedAlert;

	public GameObject SkillPilotAlert;

	public TextMeshProUGUI PilotName;

	public PilotStatsUi PilotStatsUi;

	public PilotSkillsUi PilotSkillsUi;

	public Transform PilotParent;

	public List<PilotComponent> PilotComponents;

	public PilotDb PilotDb;

	public Vector3 MainRotation;

	public Vector3 SelectionRotation;

	private static readonly int InSelection;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__15))]
	private IEnumerator Start()
	{
		return null;
	}

	private void InitPilots()
	{
	}

	private PilotComponent GetPilotComponent(int pilotId)
	{
		return null;
	}

	private int ResolveUsablePilotId(int pilotId)
	{
		return 0;
	}

	public void ResetPilotSkills()
	{
	}

	public void OpenPilotUi()
	{
	}

	public void NextPilot()
	{
	}

	public void PreviousPilot()
	{
	}

	public void SetPilot(int pilotId, bool notUpdatePilot = false)
	{
	}

	public void ClosePilotUi()
	{
	}

	public void CheckForAlerts()
	{
	}
}
