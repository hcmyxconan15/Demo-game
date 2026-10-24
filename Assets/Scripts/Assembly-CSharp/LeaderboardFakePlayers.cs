using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LeaderboardFakePlayers", menuName = "GameData/Leaderboard Fake Players")]
public class LeaderboardFakePlayers : ScriptableObject
{
	public int MinDisplayedPlayers;

	public List<FakeLeaderboardPlayer> Players;

	public void Pad(List<RankPlayer> players, LeaderboardScoreFormat format, int planetId = 0)
	{
	}

	private void Reset()
	{
	}

	private static FakeLeaderboardPlayer CreateDefault(string name, int huntScore, int thalassiaSeconds, int pyrosiaSeconds, int aureglaceSeconds, int mirevaSeconds)
	{
		return null;
	}
}
