using System.Collections.Generic;

public static class LevelUpOfferEligibility
{
	public static List<BlockedLevelUpOffer> CollectBlockedOffers(LevelUpOfferEligibilityContext context)
	{
		return null;
	}

	public static bool TryGetMicrochipBlockReason(Microchip microchip, LevelUpOfferEligibilityContext context, out string reason)
	{
		reason = null;
		return false;
	}

	public static bool TryGetWeaponBlockReason(Weapon weapon, LevelUpOfferEligibilityContext context, out string reason)
	{
		reason = null;
		return false;
	}

	public static bool TryGetDroneBlockReason(DroneStats drone, LevelUpOfferEligibilityContext context, out string reason)
	{
		reason = null;
		return false;
	}

	public static bool TryGetOverloadBlockReason(Overload overload, LevelUpOfferEligibilityContext context, out string reason)
	{
		reason = null;
		return false;
	}

	private static void CollectBlockedMicrochips(LevelUpOfferEligibilityContext context, List<BlockedLevelUpOffer> blocked)
	{
	}

	private static void CollectBlockedWeapons(LevelUpOfferEligibilityContext context, List<BlockedLevelUpOffer> blocked)
	{
	}

	private static void CollectBlockedDrones(LevelUpOfferEligibilityContext context, List<BlockedLevelUpOffer> blocked)
	{
	}

	private static void CollectBlockedOverloads(LevelUpOfferEligibilityContext context, List<BlockedLevelUpOffer> blocked)
	{
	}

	private static bool MeetsMicrochipRequirements(RobotParts robotParts, Microchip microchip)
	{
		return false;
	}

	private static bool MeetsWeaponRequirements(RobotParts robotParts, Weapon weapon)
	{
		return false;
	}

	private static bool MeetsOverloadRequirements(RobotParts robotParts, Overload overload)
	{
		return false;
	}

	private static bool ListContains(List<int> list, int id)
	{
		return false;
	}

	private static bool IsMicrochipInstalled(RobotParts robotParts, int chipId)
	{
		return false;
	}

	private static int GetInstalledMicrochipLevel(RobotParts robotParts, int chipId)
	{
		return 0;
	}

	private static bool IsWeaponInstalled(RobotParts robotParts, int weaponId)
	{
		return false;
	}

	private static int GetInstalledWeaponLevel(RobotParts robotParts, int weaponId)
	{
		return 0;
	}

	private static bool IsDroneInstalled(RobotParts robotParts, int droneId)
	{
		return false;
	}

	private static int GetInstalledDroneLevel(RobotParts robotParts, int droneId)
	{
		return 0;
	}

	private static bool IsOverloadInstalled(RobotParts robotParts, int overloadId)
	{
		return false;
	}

	private static int GetInstalledOverloadLevel(RobotParts robotParts, int overloadId)
	{
		return 0;
	}
}
