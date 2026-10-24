using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InitialBaseSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
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

	[HideInInspector]
	public BaseType BaseType;

	public void SetBaseInfo(BaseType baseType, bool equip, bool unlocked)
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
}
