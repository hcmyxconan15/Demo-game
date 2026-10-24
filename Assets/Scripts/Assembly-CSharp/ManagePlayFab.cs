using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class ManagePlayFab : MonoBehaviour
{
	public static ManagePlayFab Instance;

	public bool PlayFabLoaded;

	public bool LoginAttemptCompleted;

	private string _nameToAdd;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void LoginToPlayFabWithDeviceID()
	{
	}

	private void OnSuccess(LoginResult result)
	{
	}

	private void OnError(PlayFabError error)
	{
	}

	private void GetPlayerProfile(string playFabId)
	{
	}

	private void LoginToPlayFab(GetPlayerProfileResult result)
	{
	}

	public void SubmitScore(int playerScore, string leaderBoardName)
	{
	}

	private void OnStatisticsUpdated(UpdatePlayerStatisticsResult updateResult)
	{
	}

	private void FailureCallback(PlayFabError error)
	{
	}

	public void GetPlayerPosition(string leaderBoardName)
	{
	}

	private void DisplayUserRank(GetLeaderboardAroundPlayerResult result)
	{
	}

	private void FailedToDisplayUserRank(PlayFabError error)
	{
	}

	public void RequestInitialLeaderBoard(string leaderBoardName, int startPosition, int endPosition)
	{
	}

	public void RequestLeaderBoardExtended(string leaderBoardName, int startPosition, int endPosition)
	{
	}

	private void DisplayLeaderBoard(GetLeaderboardResult result)
	{
	}

	private void FailToRequestLeaderBoard(PlayFabError error)
	{
	}

	private void DisplayExtendedLeaderBoard(GetLeaderboardResult result)
	{
	}

	public void UpdateDisplayName(string displayName)
	{
	}

	private void OnDataSend(UpdateUserTitleDisplayNameResult result)
	{
	}

	private void OnSaveNickError(PlayFabError error)
	{
	}

	private bool CheckIfIsClientLoggedIn()
	{
		return false;
	}
}
