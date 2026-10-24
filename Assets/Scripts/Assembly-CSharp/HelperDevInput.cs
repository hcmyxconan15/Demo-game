using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelperDevInput : MonoBehaviour
{
	public enum TypeButton
	{
		Weapon = 0,
		Chip = 1,
		Overload = 2,
		Drones = 3
	}

	public enum DevModeScene
	{
		MainMenu = 0,
		GameScene = 1
	}

	public bool IgnoreDevMode;

	public bool DevMode;

	public bool ForceAllItems;

	public DevModeScene DevModeSceneActive;

	public int DiamondsToAdd;

	public int SkillPointsToAdd;

	public Transform ParentTransformWeapons;

	public AddWeaponHelperButton AddWeaponHelperButtonPrefab;

	public AddChipHelperButton AddChipHelperButtonPrefab;

	public AddMonsterHelperButton AddMonsterHelperButtonPrefab;

	public GameObject Components;

	public TextMeshProUGUI EnemiesSpamStatus;

	public List<GameObject> CurrentButtons;

	public List<CanvasGroup> CanvasGroups;

	public GameObject DevModeActiveInfo;

	public List<GameObject> ItemsButtons;

	public GameObject DevModeInfoToOpen;

	public static HelperDevInput Instance;

	private const string DevModePlayerPrefsKey = "HelperDevMode";

	private bool _devPanelOpen;

	private bool _pausedGameByThis;

	private bool _pausedGameByDevModeAlert;

	private readonly string _devModeMatchNumbers;

	private string _devModeInputBuffer;

	private int _devModeMatchCount;

	public static bool IsDevModeActive => false;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateDevModeUnlock()
	{
	}

	private void ActivateDevMode()
	{
	}

	public void AcceptDevMode()
	{
	}

	public void DisableDevMode()
	{
	}

	private void DeActivateDevModeAlertPanel()
	{
	}

	private void ResetDevModeUnlock()
	{
	}

	public void Hide(bool hide)
	{
	}

	public void HideCanvasGroup(bool hide)
	{
	}

	private void SetDevPanelPause(bool showPanel)
	{
	}

	public void SetupWeaponsToAdd()
	{
	}

	public void SetupChipsToAdd()
	{
	}

	public void SetupDronesToAdd()
	{
	}

	public void SetupOverloadToAdd()
	{
	}

	public void SetupMonstersToAdd()
	{
	}

	public void SetupItemsGenericToAdd()
	{
	}

	public void AddWeapon(int id)
	{
	}

	public void AddChip(int id)
	{
	}

	public void AddOverload(int id)
	{
	}

	public void AddDrone(int id)
	{
	}

	public void SpawnItemOnMap()
	{
	}

	public void SpawnBoxNotFreeOnMap()
	{
	}

	public void SpawnxSelectSimpleUpgradeBoxMap()
	{
	}

	public void SpawnCoinsOnMap(int type)
	{
	}

	public void SpawnXpOnMap()
	{
	}

	public void StopContinueEnemiesInstance()
	{
	}

	public void UnlockAll()
	{
	}

	public void UnlockPilots()
	{
	}

	public void SetPilotsToMax()
	{
	}

	public void UnlockPlanets()
	{
	}

	public void UnlockAllMecha()
	{
	}

	public void UnlockMechaParts()
	{
	}

	public void UnlockAllWeapons()
	{
	}

	public void UnlockWeaponsMicrochipsAndOverloadsFromDb()
	{
	}

	public void SetInitialDataItemsAsPurchase()
	{
	}

	public void MarkAllCurrentUnlockItemsAsSeen()
	{
	}

	public void AddDiamondsPoints()
	{
	}

	public void AddSkillPoints()
	{
	}

	public void WinTheHunt()
	{
	}

	private void ApplyWinTheHuntRunStats(GameControllers gameControllers)
	{
	}

	private void ApplyWinTheHuntNodeClimb(MapSelectorManager mapSelector)
	{
	}

	private List<NodeTypeComponent> FindPathToBoss(MapSelectorManager mapSelector)
	{
		return null;
	}

	private List<NodeTypeComponent> BuildPathToBossFromCurrent(NodeTypeComponent current, NodeTypeComponent boss)
	{
		return null;
	}

	private void RefreshMainMenuCurrencyUi()
	{
	}

	private void PauseGame(bool pause)
	{
	}

	private void CleanButtons()
	{
	}

	private void ManageTimeScale()
	{
	}

	private void ManageMapStatus()
	{
	}
}
