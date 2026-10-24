using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PlayFabLeaderboardDisplay : MonoBehaviour
{
	private const string s_leaderboardName = "HighScore";

	public TextMeshProUGUI Info;

	public TextMeshProUGUI Scores;

	public List<RankPlayer> RankPlayersData;

	public UnityEvent<List<RankPlayer>> LeaderBoardLoaded;

	private void OnEnable()
	{
	}

	public void GetScoresGlobal()
	{
	}

	public void GetScoresFriends()
	{
	}

	private void OnLeaderboardDownloaded(GetLeaderboardResult result)
	{
	}

	private void OnLeaderboardAroundPlayerDownloaded(GetLeaderboardAroundPlayerResult result)
	{
	}

	private void OnLeaderboardDownloadError(PlayFabError error)
	{
	}

	private void ProcessDownloadedScores(List<PlayerLeaderboardEntry> leaderboard)
	{
	}
}
