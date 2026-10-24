using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UiRobotStats : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateLayoutGroups_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiRobotStats _003C_003E4__this;

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
		public _003CUpdateLayoutGroups_003Ed__41(int _003C_003E1__state)
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

	[SerializeField]
	private CanvasGroup UiRobotStatsCanvas;

	public Transform PanelTransform;

	public StatPreviewText Life;

	public StatPreviewText Shield;

	public StatPreviewText Speed;

	public StatPreviewText DashRCharges;

	public StatPreviewText DashReloadTime;

	public StatPreviewText CriticalChancePercent;

	public StatPreviewText CriticalDamagePercent;

	public StatPreviewText DamageIncreasePercent;

	public StatPreviewText ReloadTimePercent;

	public StatPreviewText FireRatePercent;

	public StatPreviewText MagazinePercent;

	public StatPreviewText MagazineIncrease;

	public StatPreviewText MagnetArea;

	public GameObject WeaponsTextHeader;

	public List<SlotInfo> SlotInfoComponents;

	public GameObject MicrochipsTextHeader;

	public List<MicrochipSlotUi> SlotInfoMicrochipsComponents;

	public GameObject OverloadTextHeader;

	public List<OverloadSlotUi> SlotInfoOverloadComponents;

	public GameObject DroneTextHeader;

	public List<SlotInfo> SlotDroneInfoComponents;

	public PartInfoSlot BodyPartInfoSlot;

	public PartInfoSlot BasePartInfoSlot;

	public List<LayoutGroup> LayoutGroups;

	public InOutFromRight InOutFromRight;

	private bool _open;

	public void OpenStatsPanel(bool open)
	{
	}

	public void UpdateStatsPanel(Stats stats, bool revealValues = true)
	{
	}

	public void ShowSlotAvailableForThisWeapon(Weapon.SlotType weaponSlotType, int id)
	{
	}

	public void ShowSlotAvailableForMicrochip(int id)
	{
	}

	public void ShowSlotAvailableForOverload(int id)
	{
	}

	public void ShowSlotAvailableForDrone(int id)
	{
	}

	public void ShowSlotAvailableReset()
	{
	}

	private void SetStats(Stats stats)
	{
	}

	private void SetStatsHidden()
	{
	}

	private void SetPartsSpecialPropertyTexts(Stats stats)
	{
	}

	private void ClearAllSlotInfo()
	{
	}

	private void SetSlotInfo(Stats stats)
	{
	}

	private void ActiveUiStatsCanvas(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateLayoutGroups_003Ed__41))]
	private IEnumerator UpdateLayoutGroups()
	{
		return null;
	}
}
