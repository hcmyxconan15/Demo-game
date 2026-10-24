using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InitialBodySlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public bool Unlocked;

	public bool IsEquipped;

	public int Id;

	public GameObject NewAlert;

	public Button SlotButton;

	public Image Icon;

	public Image SlotImage;

	public TextMeshProUGUI SlotType;

	public Sprite SlotEquipSprite;

	public Sprite SlotNormalSprite;

	public Sprite SlotLockedSprite;

	public int SlotTypeA;

	public int SlotTypeB;

	public int SlotTypeC;

	public int SlotTypeD;

	[HideInInspector]
	public BodyType BodyType;

	public void SetBodyInfo(BodyType bodyPart, bool equip, bool unlocked)
	{
	}

	public void EquipThis()
	{
	}

	private void ClearNewUnlockAlert()
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

	private void UpdateFreeSlotsCount(BodyType bodyPart)
	{
	}
}
