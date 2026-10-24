using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
	public enum ButtonToSelectType
	{
		Weapon = 0,
		Stats = 1,
		Gold = 2,
		Drone = 3,
		Overload = 4
	}

	public ButtonToSelectType ButtonType;

	public int Id;

	public int ItemLevel;

	public int BasePrice;

	public int CurrentPrice;

	public Image SkillIcon;

	public Image SkillBackground;

	public GameObject LevelUpImage;

	public GameObject BanishImage;

	public Button Button;

	public TextMeshProUGUI SlotType;

	public TextMeshProUGUI SkillName;

	public TextMeshProUGUI SkillInfo;

	public TextMeshProUGUI SkillLevel;

	public TextMeshProUGUI SkillNew;

	[Header("Weapon settings")]
	public TextMeshProUGUI WeaponPower;

	public TextMeshProUGUI WeaponMagazine;

	public TextMeshProUGUI WeaponReloadTime;

	public TextMeshProUGUI WeaponFireRate;

	public TextMeshProUGUI WeaponActiveTime;

	public List<TextMeshProUGUI> StatusToApply;

	[Header("Gold")]
	public int GoldValue;

	public Sprite GoldIcon;

	public Color ColorPlus;

	public Color ColorPhysical;

	public Color ColorEnergy;

	public Color ColorStatusWeak;

	public Color ColorStatusBurn;

	public Color ColorStatusShock;

	public Color ColorStatusMark;

	public Sprite BackgroundChip;

	public Sprite BackgroundWeapon;

	public Sprite BackgroundOverload;

	public Sprite BackgroundGold;

	public Sprite BackgroundUpgradeFull;

	[Header("Shop item")]
	public TextMeshProUGUI NotMoreSlotText;

	public TextMeshProUGUI CoinsValue;

	public Color CanBuyColor;

	public Color CantBuyColor;

	public Weapon.SlotType WeaponSlotType;

	[Header("Level")]
	public ManageLevelSlots ManageLevelSlots;

	private string _tempString;

	public void SetupButton(Weapon weapon, int weaponLevel, bool active = true)
	{
	}

	public void SetupButtonStat(Microchip microchip, int chipLevel)
	{
	}

	public void SetupButtonDrone(DroneStats drone, int droneLevel)
	{
	}

	private void SetupButtonCollectorDrone(DroneStats drone, int droneLevel)
	{
	}

	public void SetupButtonOverload(Overload overload, int overloadLevel)
	{
	}

	public void SetupButtonGold(int goldValue)
	{
	}

	private void SetStatusToApply(float onWeak, float onShock, float onFire, float onMark, int onMarkCriticalChanceBonus)
	{
	}

	private void HideStatusToApply()
	{
	}

	private static void SetStatusSlot(TextMeshProUGUI slot, bool active, Color color, string wordKey, string valueText, string infoKey)
	{
	}

	public void SelectThisOption()
	{
	}

	public void PlayIconFlightToCurrentWeaponsUi()
	{
	}

	public void SetupItemPrice()
	{
	}

	public void ShowSlotOnStatForThis(bool show)
	{
	}
}
