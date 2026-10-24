using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PilotStatsUi : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateLayoutGroups_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PilotStatsUi _003C_003E4__this;

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
		public _003CUpdateLayoutGroups_003Ed__20(int _003C_003E1__state)
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

	public Image AvatarImage;

	public TextMeshProUGUI PilotName;

	public TextMeshProUGUI PilotLevel;

	public TextMeshProUGUI PilotDescription;

	[Header("Pilot overload")]
	public GameObject OverloadPanel;

	public OverloadSlotUi OverloadSlotUi;

	public OverloadSlotUi OverloadSlotUi2;

	public GameObject MicrochipPanel;

	[Header("Pilot microchip")]
	public MicrochipSlotUi MicrochipSlotUi;

	[Header("Pilot microchip 2")]
	public MicrochipSlotUi MicrochipSlotUi2;

	[Header("Pilot Level info")]
	public TextMeshProUGUI NextLevelStatus;

	public Slider PilotLevelSlider;

	public List<StatPreviewText> StatPreviewText;

	public List<LayoutGroup> LayoutGroups;

	public InOutFromRight InOutFromRight;

	private bool _open;

	public void SetPilotStats(Pilot pilot)
	{
	}

	private static void SetPilotOverloadPanel(Pilot pilot, int overloadId, OverloadSlotUi slotUi, out bool active)
	{
		active = default;
	}

	private static void SetPilotMicrochipPanel(Pilot pilot, int chipId, MicrochipSlotUi slotUi, out bool active)
	{
		active = default;
	}

	public void OpenPilotStatsPanel(bool open)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateLayoutGroups_003Ed__20))]
	private IEnumerator UpdateLayoutGroups()
	{
		return null;
	}
}
