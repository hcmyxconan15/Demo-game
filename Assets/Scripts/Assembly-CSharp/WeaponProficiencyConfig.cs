using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponProficiencyConfig", menuName = "GameData/Weapon/Weapon Proficiency Config")]
public class WeaponProficiencyConfig : ScriptableObject
{
	public const string EvolutionUnlockDescriptionKey = "NeedsWeaponProficiency";

	public const int EvolutionUnlockFromStartOverride = -1;

	[Tooltip("Round(BaseXp * level^GrowthFactor).")]
	public float BaseXp;

	[Tooltip("Growth factor.")]
	public float GrowthFactor;

	[Tooltip("Default proficiency level that unlocks a base weapon's evolutions. Per-weapon override: Weapon.EvolutionUnlockProficiencyLevel. -1 on the weapon = available from the start.")]
	public int EvolutionUnlockLevel;

	[Tooltip("Hard cap for proficiency leveling. Can rise later for extra rewards.")]
	public int MaxProficiencyLevel;

	[Tooltip("One reward per level. Do not assign a reward on the evolution unlock level.")]
	public List<WeaponProficiencyLevelReward> LevelRewards;

	private void Reset()
	{
	}

	public static List<WeaponProficiencyLevelReward> CreateDefaultLevelRewards()
	{
		return null;
	}

	public int GetXpForLevel(int level)
	{
		return 0;
	}

	public int GetEvolutionUnlockLevel(Weapon baseWeapon)
	{
		return 0;
	}

	public List<WeaponProficiencyLevelReward> GetLevelRewards(Weapon baseWeapon)
	{
		return null;
	}

	public void SetEvolutionUnlockShiftingRewards(Weapon weapon, int newUnlockOverride)
	{
	}

	private static List<WeaponProficiencyLevelReward> CloneRewardsList(List<WeaponProficiencyLevelReward> source)
	{
		return null;
	}

	public WeaponProficiencyBonuses GetCumulativeBonuses(Weapon baseWeapon, int proficiencyLevel)
	{
		return default;
	}
}
