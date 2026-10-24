using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PilotSkillSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public int Id;

	public int PilotId;

	public bool Unlocked;

	public bool CanBeUnlocked;

	public bool HasPointsToUnlocked;

	public SkillsUnlockedPilot.PilotSkillSlotType Type;

	public Image Icon;

	public Image ButtonImage;

	public Sprite NormalIconSprite;

	public Sprite FullIconSprite;

	public Sprite LockedIconSprite;

	public Sprite UnlockedIconSprite;

	public GameObject SelectedImage;

	public GameObject CanBeUpgradeGameObject;

	public List<PilotSkillSlot> AdjacentSkillSlots;

	public void SetupSkill(int id, int pilotId, bool unlocked, Sprite iconSprite, SkillsUnlockedPilot.PilotSkillSlotType pilotSkillSlotType)
	{
	}

	public void SetReadyToUnlock(bool hasPoint)
	{
	}

	public void SelectThis()
	{
	}

	public void ShowSlotUpInfo()
	{
	}

	public bool AdjacentSkillUnlocked()
	{
		return false;
	}

	private void HideSlotInfo()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
