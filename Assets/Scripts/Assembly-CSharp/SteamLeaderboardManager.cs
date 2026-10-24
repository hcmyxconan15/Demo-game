using System;
using System.Collections.Generic;
using Steamworks;
using UnityEngine;

public class SteamLeaderboardManager : MonoBehaviour
{
	private const string s_leaderboardName = "Hunt Score";

	private static readonly string[] PlanetLeaderboardNames;

	public SteamLeaderboardDisplay SteamLeaderboardDisplay;

	public bool s_initialized;

	private const ELeaderboardSortMethod s_sortMethod = ELeaderboardSortMethod.k_ELeaderboardSortMethodDescending;

	private const ELeaderboardDisplayType s_displayType = ELeaderboardDisplayType.k_ELeaderboardDisplayTypeNumeric;

	private const ELeaderboardSortMethod s_planetSortMethod = ELeaderboardSortMethod.k_ELeaderboardSortMethodAscending;

	private const ELeaderboardDisplayType s_planetDisplayType = ELeaderboardDisplayType.k_ELeaderboardDisplayTypeTimeSeconds;

	public SteamLeaderboard_t s_currentLeaderboard;

	private static readonly CallResult<LeaderboardFindResult_t> m_findResult;

	private static readonly CallResult<LeaderboardScoreUploaded_t> m_uploadResult;

	private static readonly CallResult<LeaderboardFindResult_t> m_planetFindResult;

	private static readonly CallResult<LeaderboardScoreUploaded_t> m_planetUploadResult;

	private const ELeaderboardUploadScoreMethod s_leaderboardMethod = ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest;

	private bool _hasPendingScoreUpload;

	private int _pendingScore;

	private readonly Dictionary<int, SteamLeaderboard_t> _planetBoards;

	private bool _planetFindInFlight;

	private int _findingPlanetId;

	private Action<bool> _planetFindCallback;

	private int _queuedFindPlanetId;

	private Action<bool> _queuedFindCallback;

	private bool _hasPendingPlanetTimeUpload;

	private int _pendingPlanetId;

	private int _pendingPlanetTime;

	private int _planetDownloadToken;

	public bool getScores;

	public static SteamLeaderboardManager Instance;

	private void Awake()
	{
	}

	public static bool HasPlanetLeaderboard(int planetId)
	{
		return false;
	}

	public static bool TryGetPlanetLeaderboardName(int planetId, out string name)
	{
		name = null;
		return false;
	}

	public void Init()
	{
	}

	public void FakeUpdateScore()
	{
	}

	public void UpdateScore(int score)
	{
	}

	public void UpdatePlanetTime(int planetId, int timeSeconds)
	{
	}

	public void FindPlanetLeaderboard(int planetId, Action<bool> onComplete)
	{
	}

	public void DownloadPlanetScores(int planetId, bool friends, Action<List<RankPlayer>, RankPlayer> onLoaded)
	{
	}

	private void StartPlanetFind(int planetId, Action<bool> onComplete)
	{
	}

	private void OnLeaderboardFindResult(LeaderboardFindResult_t pCallback, bool failure)
	{
	}

	private void OnPlanetLeaderboardFindResult(LeaderboardFindResult_t pCallback, bool failure)
	{
	}

	private void FlushQueuedPlanetFind()
	{
	}

	private void OnLeaderboardUploadResult(LeaderboardScoreUploaded_t pCallback, bool failure)
	{
	}

	private void OnPlanetLeaderboardUploadResult(LeaderboardScoreUploaded_t pCallback, bool failure)
	{
	}

	private void UploadScore(int score)
	{
	}

	private void UploadPlanetTime(SteamLeaderboard_t board, int timeSeconds)
	{
	}
}
