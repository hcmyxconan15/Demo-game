using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotInfoPart : MonoBehaviour
{
	public enum Action
	{
		Hide = 0,
		New = 1,
		Remove = 2,
		NotIndicator = 3
	}

	public TextMeshProUGUI SlotType;

	public Image Slot;

	public GameObject AddImage;

	public GameObject RemoveImage;

	public Sprite AddSlotSprite;

	public Sprite LoseSlotSprite;

	public void ShowSloInfo(Action action, Weapon.SlotType slotType)
	{
	}
}
