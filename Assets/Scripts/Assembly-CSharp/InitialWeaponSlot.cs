using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InitialWeaponSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public bool Unlocked;

	public bool IsEquipped;

	public int WeaponId;

	public int DroneId;

	public bool IsDroneOption;

	public GameObject NewAlert;

	public Button SlotButton;

	public Image WeaponIcon;

	public Image WeaponSlot;

	public TextMeshProUGUI SlotType;

	public Sprite WeaponSlotEquip;

	public Sprite WeaponSlotNormal;

	public Sprite WeaponSlotLocked;

	private Weapon _weapon;

	private DroneStats _drone;

	public void SetInfo(Weapon weapon, bool equip, bool unlocked)
	{
	}

	public void SetDroneInfo(DroneStats drone, bool equip, bool unlocked)
	{
	}

	public void SetThisWeapon()
	{
	}

	private void CheckAlertStatus()
	{
	}

	public void InfoOnPointEnter()
	{
	}

	public void InfoOnPointerExit()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
