using UnityEngine;

public class AchievementsManage : MonoBehaviour
{
	public AchievementsDatabase AchievementsDatabase;

	public static AchievementsManage Instance;

	public bool SteamStatsDirty;

	private void Awake()
	{
	}

	public void SetBestValueStat(AchievementsDatabase.StatsApiName statsApiName, int value)
	{
	}

	public void IncreaseStat(AchievementsDatabase.StatsApiName statsApiName, int value)
	{
	}

	public void SetAchievementCompleted(AchievementsDatabase.AchievementApiName achievementApiName, AchievementsDatabase.StatsApiName statsApiName)
	{
	}

	public void FlushSteamStats()
	{
	}

	private void CheckAchievementsCompletion()
	{
	}

	private void MarkSteamStatsDirty()
	{
	}

	[ContextMenu("DEBUG/Reset All Stats")]
	public void DebugResetAllStats()
	{
	}

	public void ReconcileStatsWithSteam()
	{
	}
}
