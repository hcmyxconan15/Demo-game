using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPilot : MonoBehaviour
{
	public Image PilotImage;

	public HorizontalLayoutGroup PilotLayout;

	public List<MicrochipSlotUi> PilotMicrochipSlots;

	public List<OverloadSlotUi> PilotOverloadSlots;

	public void SetCurrentPilot()
	{
	}

	private void SetOverloadSlot(RobotParts robotParts, Pilot pilot)
	{
	}

	private void TryShowPilotOverload(RobotParts robotParts, Pilot pilot, int overloadId, ref int slotIndex)
	{
	}

	private void SetMicrochipSlot(RobotParts robotParts, Pilot pilot)
	{
	}

	private void TryShowPilotMicrochip(RobotParts robotParts, Pilot pilot, int chipId, ref int slotIndex)
	{
	}

	private static void HideSlots<T>(List<T> slots) where T : MonoBehaviour
	{
	}

	private void LayoutSetup()
	{
	}
}
