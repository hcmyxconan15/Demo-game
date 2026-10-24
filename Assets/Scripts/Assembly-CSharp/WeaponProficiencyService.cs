using System.Collections.Generic;

public static class WeaponProficiencyService
{
	public static WeaponProficiencyBonuses GetBonuses(WeaponsDb weaponsDb, int weaponId)
	{
		return default;
	}

	public static List<WeaponProficiencyGain> BuildGains(IReadOnlyDictionary<int, int> killsByBaseWeaponId, WeaponsDb weaponsDb)
	{
		return null;
	}

	public static List<ItemToUnlock> ApplyEndOfRun(IReadOnlyDictionary<int, int> killsByBaseWeaponId, WeaponsDb weaponsDb)
	{
		return null;
	}

	public static void SetProficiency(DataUser user, WeaponProficiencyConfig config, int baseWeaponId, int level, int progress = 0)
	{
	}

	public static void MaxAllProficiency(DataUser user, WeaponsDb weaponsDb, bool grantEvolutions)
	{
	}

	public static void ClearAllProficiency(DataUser user)
	{
	}

	public static int GrantEvolutionUnlocksForEligible(DataUser user, WeaponsDb weaponsDb, List<ItemToUnlock> newlyUnlocked = null)
	{
		return 0;
	}

	public static void TryUnlockEvolutionsForBaseWeapon(WeaponsDb weaponsDb, Weapon baseWeapon, List<ItemToUnlock> newlyUnlocked = null)
	{
	}

	public static void TryUnlockEvolutionsForBaseWeapon(DataUser user, WeaponsDb weaponsDb, Weapon baseWeapon, List<ItemToUnlock> newlyUnlocked = null)
	{
	}

	private static void ApplyXp(int baseWeaponId, int xpToAdd, WeaponProficiencyConfig config, WeaponsDb weaponsDb, List<ItemToUnlock> newlyUnlocked)
	{
	}
}
