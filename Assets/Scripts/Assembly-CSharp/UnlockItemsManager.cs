using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnlockItemsManager : MonoBehaviour
{
	public enum TabActive
	{
		Weapons = 0,
		Chips = 1,
		Overloads = 2,
		Evolutions = 3,
		Parts = 4
	}

	public bool Open;

	public bool SomeAlertActive;

	public CanvasGroup CanvasGroupPanel;

	public GameObject Panel;

	public List<ItemInfoMain> ItemInfoMainList;

	public int GridColumns;

	public TabActive CurrentTabActive;

	public List<TabButtonItems> TabButtons;

	[Header("Alerts")]
	public GameObject NewItemAlert;

	public GameObject NewWeaponAlert;

	public GameObject NewMicrochipAlert;

	public GameObject NewOverloadAlert;

	public GameObject NewPartAlert;

	public GameObject NewEvolutionAlert;

	[Header("Items info")]
	public InfoHelper InfoHelper;

	public TextMeshProUGUI TextSimpleName;

	public InfoHelperSimple InfoHelperSimple;

	public GameObject SliderFullComponent;

	public Slider SliderComponent;

	public TextMeshProUGUI StatusValue;

	public ProficiencyStatus ProficiencyStatus;

	[Header("Parts info")]
	public PartsInfoPanel PartsInfoPanel;

	[Header("Evolution info")]
	public EvolutionsInfoPanel EvolutionsInfoPanel;

	public PlaySoundButton UnlockPlaySoundButtonComponent;

	public Button UnlockButton;

	public TextMeshProUGUI ItemPriceText;

	public UnlockDb UnlockDb;

	private ItemInfoMain _selectedItemToPurchase;

	public Color NotEnoughColor;

	private Color _originalTextColor;

	private Color _originalImageColor;

	[Header("Tab input (Joystick)")]
	public List<MainMenuJoystickBase.PanelActive> UseOnPanelActive;

	public string ButtonNameLeft;

	public string SpriteId;

	public Image ButtonSpriteLeft;

	public string ButtonNameRight;

	public string SpriteIdRight;

	public Image ButtonSpriteRight;

	public MainMenuJoystickBase MainMenuJoystick;

	public MenuNavigation MenuNavigation;

	private bool _buttonLeft;

	private bool _buttonRight;

	private void Awake()
	{
	}

	public void OpenUnlockItemsPanel()
	{
	}

	public void CloseUnlockItemsPanel()
	{
	}

	public void SetWeaponList()
	{
	}

	public void SetChipList()
	{
	}

	public void SetOverloadList()
	{
	}

	public void SetPartList()
	{
	}

	public void SetEvolutionList()
	{
	}

	public void CheckForAlerts()
	{
	}

	private bool HasNewUnlock(ItemToUnlock.UnlockType unlockType)
	{
		return false;
	}

	private bool HasNewUnlockForWeaponType(bool evolutionOnly)
	{
		return false;
	}

	private bool HasAffordableNewUnlockForWeaponType(bool evolutionOnly)
	{
		return false;
	}

	private bool HasAffordableNewUnlock(ItemToUnlock.UnlockType unlockType)
	{
		return false;
	}

	private List<UnlockItemData> GetUnlockList(ItemToUnlock.UnlockType unlockType)
	{
		return null;
	}

	private bool IsConditionMet(ItemToUnlock itemToUnlock)
	{
		return false;
	}

	private int GetUnlockPrice(ItemToUnlock.UnlockType unlockType, int itemId)
	{
		return 0;
	}

	public void DeselectAllItems()
	{
	}

	public void HideProficiencyStatus()
	{
	}

	public void ShowProficiencyStatusForWeapon(Weapon weapon)
	{
	}

	private void RefreshActiveTabItems()
	{
	}

	public void SetItemPurchasedButton(ItemInfoMain itemInfoMain)
	{
	}

	public void PurchasedItem()
	{
	}

	private static string UnlockTypeToKey(ItemToUnlock.UnlockType type)
	{
		return null;
	}

	private void HideAllItems()
	{
	}

	private void SetTabStatus(int selectedIndex)
	{
	}

	private void SelectFirstOnList()
	{
	}

	public void ShowEvolutionRequirements(Weapon evolutionWeapon)
	{
	}

	public void SetUnlockInfo(int id, ItemToUnlock.UnlockType typeOfItem)
	{
	}

	private void SetEvolutionProficiencyUnlockInfo(int evolutionWeaponId, WeaponsDb weaponsDb)
	{
	}

	private string GetFormatedString(string text, float value, int extraId, AchievementsDatabase.StatsApiName statsApiName)
	{
		return null;
	}

	private string ResolveExtraIdDisplayName(AchievementsDatabase.StatsApiName statsApiName, int extraId)
	{
		return null;
	}

	private string ResolveMechDisplayName(int mechId)
	{
		return null;
	}

	[ContextMenu("Add button flow")]
	public void AddButtonFlow()
	{
	}

	private void SetItemsNavigation()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void GoNextTab()
	{
	}

	private void GoBackTab()
	{
	}

	private void UpdateButtonSprite()
	{
	}
}
