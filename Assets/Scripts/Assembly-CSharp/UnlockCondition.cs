using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class UnlockCondition
{
	public int UnlockValue;

	public AchievementsDatabase.StatsApiName StatsApiName;

	[Tooltip("Per-item / per-mecha / per-planet / per-enemy id. Required for mecha, planet, and enemy stats (0 is a valid mecha, planet, or enemy Id). For weapon/chip stats, non-zero overrides unlock ItemId.")]
	public int ExtraId;

	[Multiline(2)]
	[Tooltip("Menu localization key. Set automatically from StatsApiName.")]
	public string Description;

	[FormerlySerializedAs("NotAccumulated")]
	[Tooltip("Hides the progress slider in hangar UI (peak / one-shot style conditions).")]
	public bool HideProgressSlider;

	public string GetDescriptionKey()
	{
		return null;
	}

	public void SyncDescriptionFromStatsApiName()
	{
	}

	public static string GetDescriptionKey(AchievementsDatabase.StatsApiName statsApiName)
	{
		return null;
	}

	public static string GetDescriptionKey(AchievementsDatabase.StatsApiName statsApiName, int unlockValue)
	{
		return null;
	}

	public int ResolveStatsExtraId(int unlockItemId)
	{
		return 0;
	}

	public static bool UsesConditionExtraId(AchievementsDatabase.StatsApiName statsApiName)
	{
		return false;
	}

	public static bool UsesPlanetExtraId(AchievementsDatabase.StatsApiName statsApiName)
	{
		return false;
	}

	public static bool UsesEnemyExtraId(AchievementsDatabase.StatsApiName statsApiName)
	{
		return false;
	}
}
