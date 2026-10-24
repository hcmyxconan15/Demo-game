using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;

public class PartsUiController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHideUiCoroutine_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartsUiController _003C_003E4__this;

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
		public _003CHideUiCoroutine_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CRestoreEquippedPartsPreviewAfterDelay_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartsUiController _003C_003E4__this;

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
		public _003CRestoreEquippedPartsPreviewAfterDelay_003Ed__53(int _003C_003E1__state)
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
	private sealed class _003CShowPartsUiCoroutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartsUiController _003C_003E4__this;

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
		public _003CShowPartsUiCoroutine_003Ed__69(int _003C_003E1__state)
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

	public CanvasGroup PartsCanvas;

	public CinemachineVirtualCamera PartsVirtualCamera;

	public MechPlayerController MechPlayerController;

	public PartSelection PartSelection;

	public bool UseFullChassis;

	[Header("Full Chassis")]
	public TextMeshProUGUI HeaderCoreText;

	public TextMeshProUGUI HeaderBaseText;

	public GameObject ChassisButtons;

	public MechFullChassisController MechFullChassisController;

	[Header("Weapons")]
	public InitialWeaponController InitialWeaponController;

	[Header("Body parts")]
	public GameObject WeaponsText;

	public GameObject WeaponsSlotsParent;

	public BodySelectionController BodySelectionController;

	public PartInfoSlot BodyPartInfoSlot;

	[Header("Base parts")]
	public BaseSelectionController BaseSelectionController;

	public PartInfoSlot BasePartInfoSlot;

	public InfoHelper InfoHelper;

	public GameObject StatsText;

	public List<StatPreviewText> StatPreviewTexts;

	public List<SlotInfoPart> WeaponsSlotInfoPart;

	public GameObject AlertOnButton;

	[Header("Menu navigation")]
	public MenuNavigation MenuNavigation;

	public List<NavigableButton> NavigableButtonsFullChassis;

	public List<NavigableButton> NavigableButtonsEndGameFlow;

	public NavigableButton NavigableButtonNormalSlot;

	public NavigableButton NavigableButtonNormalSlot1;

	public NavigableButton NavigableButtonNormalSlot2;

	public NavigableButton NavigableButtonFullChassisSlot;

	public NavigableButton NavigableButtonFullChassisSlot1;

	public NavigableButton NavigableButtonFullChassisSlot2;

	private const float EquippedPreviewRestoreDelay = 0.25f;

	private Coroutine _restoreEquippedPreviewCoroutine;

	public void OpenPartsUi()
	{
	}

	public void ClosePartsUi()
	{
	}

	public void SetStatsPreviewTexts(PartStats partStats, PartPreviewCategory category, float speed = 0f, int magnetSize = 0, BodyType bodyType = null, bool isEquippedSelection = false, int dashCharges = 0, float dashCooldown = 0f, BaseType baseType = null)
	{
	}

	public void SetStatsPreviewTexts(BaseType baseType, BodyType bodyType, bool isEquippedSelection = false)
	{
	}

	public void SetWeaponPreview(Weapon weaponReference)
	{
	}

	public void SetDronePreview(DroneStats droneReference)
	{
	}

	public bool ShouldShowFirstTimeHangarAlert()
	{
		return false;
	}

	public void RefreshFirstTimeHangarAlert()
	{
	}

	private void MarkHangarPartsOpened()
	{
	}

	private void GetEquippedPartStats(PartPreviewCategory category, out PartStats equippedStats, out float equippedSpeed, out int equippedMagnet, out int equippedDashCharges, out float equippedDashCooldown)
	{
		equippedStats = null;
		equippedSpeed = default;
		equippedMagnet = default;
		equippedDashCharges = default;
		equippedDashCooldown = default;
	}

	public void ClearStatsPreviewTexts()
	{
	}

	private void SetBodySpecialPropertyText(BodyType bodyType)
	{
	}

	private void SetBaseSpecialPropertyText(BaseType baseType)
	{
	}

	private void ClearSpecialPropertyTexts()
	{
	}

	private void ClearWeaponsSlotInfoParts()
	{
	}

	private void SetWeaponsSlotPreview(BodyType selectedBody, bool isEquippedSelection)
	{
	}

	private void TryShowSlotCount(ref int slotIndex, Weapon.SlotType slotType, int count)
	{
	}

	public void ShowEquippedPartsPreview()
	{
	}

	public void ShowLockedPartPreview()
	{
	}

	public void ScheduleEquippedPartsPreview()
	{
	}

	public void CancelScheduledEquippedPartsPreview()
	{
	}

	[IteratorStateMachine(typeof(_003CRestoreEquippedPartsPreviewAfterDelay_003Ed__53))]
	private IEnumerator RestoreEquippedPartsPreviewAfterDelay()
	{
		return null;
	}

	private bool IsPointerOverHangarPartSlot()
	{
		return false;
	}

	private static bool IsPointerOverAnySlot<T>(List<T> slots, Vector2 pointer, Camera cam) where T : Component
	{
		return false;
	}

	private BodyType GetEquippedBody()
	{
		return null;
	}

	private BaseType GetEquippedBase()
	{
		return null;
	}

	private static void GetWeaponSlotCounts(BodyType body, out int slotA, out int slotB, out int slotC, out int slotD)
	{
		slotA = default;
		slotB = default;
		slotC = default;
		slotD = default;
	}

	private void TryShowSlotChange(ref int slotIndex, Weapon.SlotType slotType, int selectedCount, int equippedCount)
	{
	}

	private void UpdatePreviewHeaders()
	{
	}

	private bool HasActiveStatPreview()
	{
		return false;
	}

	private bool HasActiveWeaponSlotPreview()
	{
		return false;
	}

	private static PartStats CombinePartStats(PartStats first, PartStats second)
	{
		return null;
	}

	private void TryShowStat(ref int statIndex, string statNameKey, float selectedValue, float equippedValue, bool isPercent, bool isEquippedSelection)
	{
	}

	private void CheckForAlerts()
	{
	}

	public void SetupCurrentWeaponsAndParts()
	{
	}

	private void SetFullChassisStatus(MechData mechData)
	{
	}

	private void EnableSlotsButtons(bool enable)
	{
	}

	[IteratorStateMachine(typeof(_003CShowPartsUiCoroutine_003Ed__69))]
	private IEnumerator ShowPartsUiCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CHideUiCoroutine_003Ed__70))]
	private IEnumerator HideUiCoroutine()
	{
		return null;
	}
}
