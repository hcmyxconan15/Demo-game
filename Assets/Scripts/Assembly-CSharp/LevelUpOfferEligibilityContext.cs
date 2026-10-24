using System.Collections.Generic;

public sealed class LevelUpOfferEligibilityContext
{
	public RobotParts RobotParts;

	public bool ShouldIgnoreWeaponsThisLevel;

	public List<int> MicrochipsBanished;

	public List<int> WeaponsBanished;

	public List<int> WeaponsBanishedByUpgrade;

	public List<int> DroneBanished;

	public List<int> OverloadBanished;
}
