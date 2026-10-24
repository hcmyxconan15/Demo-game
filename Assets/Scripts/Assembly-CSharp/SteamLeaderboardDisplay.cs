using System;
using System.Collections.Generic;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SteamLeaderboardDisplay : MonoBehaviour
{
	public TextMeshProUGUI Info;

	public TextMeshProUGUI Scores;

	public int MaxResultsCount;

	[HideInInspector]
	public SteamLeaderboardEntries_t m_SteamLeaderboardEntries;

	private static readonly CallResult<LeaderboardScoresDownloaded_t> m_scoresDownloadedResult;

	private static readonly CallResult<LeaderboardScoresDownloaded_t> m_scoresDownloadedResultFriends;

	private static readonly CallResult<LeaderboardScoresDownloaded_t> m_planetScoresDownloadedResult;

	private int _planetDownloadToken;

	private Action<int, List<RankPlayer>, RankPlayer> _planetDownloadCallback;

	public List<RankPlayer> RankPlayersData;

	public UnityEvent<List<RankPlayer>> LeaderBoardLoaded;

	private bool _hasLoggedNotReadyGlobal;

	private bool _hasLoggedNotReadyFriends;

	public RankPlayer CurrentPlayerData;

	private void OnEnable()
	{
	}

	public void GetScoresGlobal()
	{
	}

	public void GetScoresFriends()
	{
	}

	public void DownloadPlanetScores(SteamLeaderboard_t board, bool friends, int requestToken, Action<int, List<RankPlayer>, RankPlayer> onLoaded)
	{
	}

	private void OnLeaderboardScoresDownloadedGlobal(LeaderboardScoresDownloaded_t pCallback, bool bIOFailure)
	{
	}

	private void OnPlanetScoresDownloaded(LeaderboardScoresDownloaded_t pCallback, bool bIOFailure)
	{
	}

	private void ProcessDownloadedScoresGlobal(LeaderboardScoresDownloaded_t pCallback)
	{
	}

	private bool TryBuildRankPlayers(LeaderboardScoresDownloaded_t pCallback, bool updateDebugUi, out List<RankPlayer> ranks, out RankPlayer currentPlayer)
	{
		ranks = null;
		currentPlayer = null;
		return false;
	}
}
