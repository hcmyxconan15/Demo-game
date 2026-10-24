using System.Collections.Generic;
using UnityEngine;

public class PlayerBuffStatusUi : MonoBehaviour
{
	public ProgressBarPro LifeSlider;

	public CanvasGroup ShieldCanvasGroup;

	public ProgressBarPro ShieldSlider;

	public List<StatusSlot> StatusSlots;

	public StatusSlot StatusSlotPrefab;

	public StatusSlot DamageIncreaseSlot;

	public StatusSlot SpeedIncreaseSlot;

	private MechPlayerController _mechPlayerController;

	private readonly Dictionary<int, StatusSlot> _overloadSlotById;

	private readonly HashSet<int> _previouslyVisibleOverloadIds;

	private bool _damageSlotWasActive;

	private bool _speedSlotWasActive;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RefreshStatusSlots()
	{
	}

	private void RefreshTimedBuffSlots(Stats stats)
	{
	}

	private StatusSlot AcquireOverloadSlot(int overloadId)
	{
		return null;
	}

	private bool IsSpecialSlot(StatusSlot slot)
	{
		return false;
	}

	private bool IsSlotAssignedToOtherOverload(StatusSlot slot, int exceptOverloadId)
	{
		return false;
	}

	private Transform GetSlotsParent()
	{
		return null;
	}

	private static void MoveToLastSibling(StatusSlot slot)
	{
	}

	private void ApplySlot(StatusSlot slot, OverloadInstalled overloadInstalled)
	{
	}

	private void SetSlotHidden(StatusSlot slot)
	{
	}

	private void SetSlotActive(StatusSlot slot, bool active)
	{
	}

	private void HideAllSlots()
	{
	}

	public bool TryGetActiveStatusSlot(OverloadInstalled overloadInstalled, out StatusSlot statusSlot)
	{
		statusSlot = null;
		return false;
	}

	private bool IsSlotVisible(StatusSlot slot)
	{
		return false;
	}
}
