using System.Collections.Generic;

public static class OverloadDeploySlotTracker
{
	private static readonly Dictionary<int, HashSet<int>> OccupiedSlotsByOverloadId;

	public static bool IsAtMaxCapacity(int overloadId, int maxSlots)
	{
		return false;
	}

	public static bool TryReserveSlot(int overloadId, int maxSlots, out int slotIndex)
	{
		slotIndex = default;
		return false;
	}

	public static void ReleaseSlot(int overloadId, int slotIndex)
	{
	}

	public static void Reset()
	{
	}
}
