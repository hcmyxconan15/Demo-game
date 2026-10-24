using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InitialMechChassisSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public int Id;

	public bool Unlocked;

	public bool IsEquipped;

	public InitialBodySlot InitialBodySlot;

	public InitialBaseSlot InitialBaseSlot;

	public Button ChassisButton;

	public Image SlotImage;

	public Sprite SlotEquipSprite;

	public Sprite SlotNormalSprite;

	public Sprite SlotLockedSprite;

	public void SetChassisInfo(bool equip)
	{
	}

	public void EquipThisChassis()
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
