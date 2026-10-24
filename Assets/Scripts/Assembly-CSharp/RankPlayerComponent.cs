using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RankPlayerComponent : MonoBehaviour
{
	public string PlayerName;

	public int Rank;

	public Image AvatarSprite;

	public List<GameObject> AvatarSlots;

	public TextMeshProUGUI RankText;

	public TextMeshProUGUI PlayerNameText;

	public TextMeshProUGUI PlayerPointsText;

	private ulong _currentSteamId;

	private int _avatarRequestVersion;

	private Texture2D _appliedTexture;

	public static string FormatScore(int value, LeaderboardScoreFormat format)
	{
		return null;
	}

	public void Setup(RankPlayer rankPlayersData, LeaderboardScoreFormat scoreFormat = LeaderboardScoreFormat.Points)
	{
	}

	private void SetAvatar(RankPlayer rankPlayer)
	{
	}

	private void ApplyAvatarSprite(Sprite sprite)
	{
	}

	private void ApplyAvatarTexture(Texture2D avatarTexture)
	{
	}
}
