using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UnknownEventController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTextAnimation_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnknownEventController _003C_003E4__this;

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
		public _003CTextAnimation_003Ed__28(int _003C_003E1__state)
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

	public int EventSelected;

	public TextMeshProUGUI TitleText;

	public AnimateWriterText AnimateWriterTitleText;

	public TextMeshProUGUI DescriptionText;

	public AnimateWriterText DescriptionAnimateWriterText;

	public CanvasGroup EventPanel;

	public GameObject ContinueButton;

	public TextMeshProUGUI ContinueButtonText;

	public GameObject PositiveButton;

	public TextMeshProUGUI PositiveButtonText;

	public GameObject NegativeButton;

	public TextMeshProUGUI NegativeButtonText;

	[Header("Event settings")]
	public UnknownEventsDb UnknownEventsDb;

	[SerializeField]
	private List<int> EventToSelect;

	private int _nodeLevel;

	public bool BlocksRewardPanels { get; private set; }

	private void Awake()
	{
	}

	private void InitializedEventList()
	{
	}

	public void OpenEventPanel(int nodeLevel)
	{
	}

	private List<int> CollectEligibleEvents(List<int> eventIds, int nodeLevel)
	{
		return null;
	}

	private int GetUnknownMercenaryStep()
	{
		return 0;
	}

	public void ContinueGameAfterEvent()
	{
	}

	public void PositiveResponse()
	{
	}

	public void NegativeResponse()
	{
	}

	private void SelectEvent()
	{
	}

	[IteratorStateMachine(typeof(_003CTextAnimation_003Ed__28))]
	private IEnumerator TextAnimation()
	{
		return null;
	}

	private void ApplyEventEffectResponse0()
	{
	}

	private void ApplyEventEffectResponse1()
	{
	}

	private void FormatResponseTextForTheEventAndSetAlert(string responseKey, AlertComponent.AlertType alertType)
	{
	}

	private void CloseEventPanel()
	{
	}

	private void LaunchInfoPanel()
	{
	}
}
