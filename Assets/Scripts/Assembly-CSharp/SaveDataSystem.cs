using UnityEngine;

public class SaveDataSystem : MonoBehaviour
{
	private const string FileName = "IronHunter";

	public static DataUser DataUser;

	private static float _playTimeSessionStart;

	private static bool _playTimeSessionStarted;

	public static bool ExistSaved()
	{
		return false;
	}

	public static void DeleteSaveFile()
	{
	}

	public static void LoadData()
	{
	}

	public static void Save()
	{
	}

	public static void StartPlayTimeSession()
	{
	}

	public static float GetTotalPlayTimeSeconds()
	{
		return 0f;
	}

	private static void FlushPlayTime()
	{
	}

	public static int GetCurrentBuildNumber()
	{
		return 0;
	}

	private static void ReportSaveLoadFailed(string operation, string message)
	{
	}

	public static void EnsureCollections(DataUser data)
	{
	}

	public static int GetStatsExtraId(AchievementsDatabase.StatsApiName statsApiName, int itemId)
	{
		return 0;
	}
}
