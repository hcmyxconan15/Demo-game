using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnlockItemReveal : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Image ItemIcon;

	public Image SlotIcon;

	private ItemToUnlock.UnlockType _unlockType;

	private int _itemId;

	public void SetItem(Sprite sprite, Sprite slotIcon, ItemToUnlock.UnlockType unlockType, int itemId)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
