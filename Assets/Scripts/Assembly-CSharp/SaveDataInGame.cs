using System.Collections.Generic;
using UnityEngine;

public class SaveDataInGame : MonoBehaviour
{
	public enum GameBuildChannel
	{
		Release = 0,
		Demo = 1,
		Playtest = 2
	}

	public bool InitialLoadDone;

	public bool UsingJoystick;

	public bool DoNotUseSteamApi;

	[Tooltip("Player builds quit if Steam is missing or the account does not own this app. Uncheck to let anyone open the game. Steam APIs still initialize unless DoNotUseSteamApi is on.")]
	public bool RequireSteamOwnership;

	public GameBuildChannel BuildChannel;

	public LeaderboardManager.LeaderboardType Leaderboard;

	[Tooltip("Main menu Hunt Score (points) leaderboard. Planet hunt-time boards ignore this.")]
	public bool ShowHuntScoreLeaderboard;

	[SerializeField]
	private bool KeepDataBetweenScenes;

	[SerializeField]
	private string MainMenuSceneName;

	[SerializeField]
	private DataUser DataUser;

	[Tooltip("Starting player data template asset. Edit via Tools > Content Availability Manager.")]
	public InitialDataConfig InitialDataConfig;

	public static SaveDataInGame Instance;

	public MechaDataBase MechDataBase;

	public PlanetQuestDb PlanetQuestDb;

	[Tooltip("Used by testing unlock helpers when UnlockItemsController is not in the scene.")]
	[SerializeField]
	private UnlockDb _unlockDb;

	[Tooltip("Saves written with a build number lower than this are wiped and re-initialized on load.")]
	[SerializeField]
	private int _resetVersionCap;

	private const int TestPlanetIdUpperExclusive = 8;

	public DataUser InitialDataUser => null;

	public bool AllowSteamApi => false;

	public bool IsLimitedBuild => false;

	public string VersionLabelPrefix => null;

	public string NotAvailableLocalizationKey => null;

	public string LockedForBuildLocalizationKey => null;

	private DataUser ActiveDataUser => null;

	public static bool ShouldUseSteamApi()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void InitPlayerData()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public static void ClearPlayerPrefsIfAny()
	{
	}

	public void ResetPlayerDataAndReloadFromMainMenu()
	{
	}

	private void ResetSettingsToDefault()
	{
	}

	public void ResetGeneralSettings()
	{
	}

	public void ResetGraphicSettings()
	{
	}

	public void ResetSoundSettings()
	{
	}

	private void ResetAchievements()
	{
	}

	private void ResetStats()
	{
	}

	private void ResetHuntsData()
	{
	}

	[ContextMenu("Save data on play helper")]
	public void SaveDataHelper()
	{
	}

	[ContextMenu("UnlockAll")]
	public void UnlockAll()
	{
	}

	[ContextMenu("MaxAllWeaponProficiency")]
	public void MaxAllWeaponProficiency()
	{
	}

	[ContextMenu("ClearAllWeaponProficiency")]
	public void ClearAllWeaponProficiency()
	{
	}

	[ContextMenu("SetInitialDataItemsAsPurchase")]
	public void SetInitialDataItemsAsPurchase()
	{
	}

	[ContextMenu("Mark all current unlock items as already seen")]
	public void MarkAllCurrentUnlockItemsAsSeen()
	{
	}

	[ContextMenu("UnlockPilots")]
	public void UnlockPilots()
	{
	}

	[ContextMenu("UnlockPlanets")]
	public void UnlockPlanets()
	{
	}

	[ContextMenu("UnlockAllMecha")]
	public void UnlockAllMecha()
	{
	}

	[ContextMenu("UnlockMechaParts")]
	public void UnlockMechaParts()
	{
	}

	[ContextMenu("Unlock weapons, microchips & overloads (Unlock DB)")]
	public void UnlockWeaponsMicrochipsAndOverloadsFromDb()
	{
	}

	private void ApplyUnlockAllPilots(DataUser user)
	{
	}

	private void ApplyUnlockAllMecha(DataUser user)
	{
	}

	private void ApplyUnlockMechaParts(DataUser user)
	{
	}

	private UnlockDb ResolveUnlockDb()
	{
		return null;
	}

	private WeaponsDb ResolveWeaponsDb()
	{
		return null;
	}

	private int GrantEligibleEvolutionUnlocks(DataUser user, bool markAsNew = true)
	{
		return 0;
	}

	private bool ApplyUnlockLoadoutItemsFromUnlockDb(DataUser user)
	{
		return false;
	}

	private void MarkStarterMechLoadoutPartsAsSeen(DataUser user)
	{
	}

	private static void ClearUnlockListRowsSeen(List<UnlockItemData> list)
	{
	}

	private static void MarkUnlockItemSeen(List<UnlockItemData> list, int id)
	{
	}

	private static void MarkAllUnlockItemRowsSeen(DataUser user)
	{
	}

	private static void MarkAllUnlockItemRowsPurchased(DataUser user)
	{
	}

	private static void MarkUnlockListRowsSeen(List<UnlockItemData> list)
	{
	}

	private static void MarkUnlockListRowsPurchased(List<UnlockItemData> list)
	{
	}

	private static void MarkPurchasedFromTemplate(List<UnlockItemData> destination, List<UnlockItemData> template)
	{
	}

	private bool TryGetDataUserForTesting(out DataUser user)
	{
		user = null;
		return false;
	}

	private void PersistTestingChanges(DataUser user)
	{
	}
}
