using System.Collections.Generic;

public static class TagOfferAffinityCollector
{
	public static bool TryCollect(int typeId, int itemId, RobotParts robotParts, List<GameTag> affinityTags)
	{
		return false;
	}

	private static bool TryCollectWeapon(int weaponId, RobotParts robotParts, List<GameTag> affinityTags)
	{
		return false;
	}

	private static bool TryCollectMicrochip(int microchipId, RobotParts robotParts, List<GameTag> affinityTags)
	{
		return false;
	}

	private static bool TryCollectDrone(int droneId, RobotParts robotParts, List<GameTag> affinityTags)
	{
		return false;
	}

	private static bool TryCollectOverload(int overloadId, RobotParts robotParts, List<GameTag> affinityTags)
	{
		return false;
	}

	private static void AddExtraAndGateTags(List<GameTag> extraTags, TagRequirements tagGate, List<GameTag> affinityTags)
	{
	}
}
