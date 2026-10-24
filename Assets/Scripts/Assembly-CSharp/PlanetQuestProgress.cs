using System.Collections.Generic;

public static class PlanetQuestProgress
{
	public static PlanetQuestDb Db => null;

	public static List<PlanetQuest> GetQuests(int planetId)
	{
		return null;
	}

	public static bool IsQuestUnlocked(int planetId, int questIndex)
	{
		return false;
	}

	public static int GetUnlockedQuestCount(int planetId)
	{
		return 0;
	}

	public static bool IsPlanetNotAvailable(int planetId)
	{
		return false;
	}

	public static bool MeetsPlanetUnlockRequirement(int planetId)
	{
		return false;
	}

	public static void EvaluateUnlocks()
	{
	}

	public static int GetFirstUnlockedIncompleteQuest(int planetId)
	{
		return 0;
	}
}
