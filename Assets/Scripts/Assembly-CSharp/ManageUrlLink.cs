using UnityEngine;

public class ManageUrlLink : MonoBehaviour
{
	public enum StorePlatform
	{
		Steam = 0,
		Epic = 1,
		GooglePlay = 2
	}

	private const string SteamStoreBaseUrl = "https://store.steampowered.com/app/2773630/";

	private const string DiscordInviteURL = "https://discord.gg/ryHwCnRvTC";

	private const string UtmSource = "ironhunters_paytest";

	private const string UtmMedium = "ingame";

	public void WishlistSteam()
	{
	}

	public void WishlistSteamMainMenu()
	{
	}

	public void WishlistSteamGameCompletion()
	{
	}

	public void WishlistSteamExitGame()
	{
	}

	public void OpenDiscordInvite()
	{
	}

	public void OpenStore(StorePlatform platform)
	{
	}

	public void OpenSurvey()
	{
	}

	private static void OpenSteamStoreWithUtm(string campaign)
	{
	}
}
