using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PilotSkillsUi : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateLayoutGroups_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PilotSkillsUi _003C_003E4__this;

		private List<LayoutGroup>.Enumerator _003C_003E7__wrap1;

		private LayoutGroup _003ClayoutGroup_003E5__3;

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
		public _003CUpdateLayoutGroups_003Ed__31(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public int PointsToSpend;

	public NotCurrencyFeedback NotCurrencyFeedback;

	public TextMeshProUGUI SkillPointsToSpend;

	public List<PilotSkillSlot> PilotSkillSlots;

	public PilotSkillSlot MicroChipSlot;

	public PilotSkillSlot MicroChipSlot2;

	public PilotSkillSlot SkillSlot;

	public PilotSkillSlot SkillSlot2;

	public List<LayoutGroup> LayoutGroups;

	public GameObject ResetButton;

	[Header("Slot item info")]
	public GameObject ItemPanel;

	public OverloadSlotUi OverloadSlotUi;

	public MicrochipSlotUi MicrochipSlotUi;

	[FormerlySerializedAs("OverloadName")]
	public TextMeshProUGUI ItemName;

	[FormerlySerializedAs("OverloadDescription")]
	public TextMeshProUGUI ItemDescription;

	public StatPreviewText StatPreviewText;

	public InOutFromLeft InOutFromLeft;

	private bool _open;

	private Pilot _pilot;

	private void Awake()
	{
	}

	public void ResetPilotSkillTree(int pilotId)
	{
	}

	public bool UnlockPilotSlot(int pilotId, int skillId, SkillsUnlockedPilot.PilotSkillSlotType type)
	{
		return false;
	}

	public void SetPilotSkillsTree(Pilot pilot)
	{
	}

	public void OpenPilotSkillPanel(bool open)
	{
	}

	public void ShowSkillInfo(int overloadId)
	{
	}

	public void ShowSMicrochipInfo(int chipId)
	{
	}

	public void ShowStatPilotInfo(int statId)
	{
	}

	public void HideInfo()
	{
	}

	public void ShowSlotInfoOnSwitchPilots()
	{
	}

	private void SetAvailableSkillsToUnlock()
	{
	}

	public int GetPointsToSpend(int pilotId)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CUpdateLayoutGroups_003Ed__31))]
	private IEnumerator UpdateLayoutGroups()
	{
		return null;
	}

	private bool CanShowResetButton()
	{
		return false;
	}

	private bool HasPilotSkillResetPowerUp()
	{
		return false;
	}
}
