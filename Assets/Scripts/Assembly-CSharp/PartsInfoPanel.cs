using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartsInfoPanel : MonoBehaviour
{
	public TextMeshProUGUI TextSimpleName;

	public GameObject StatsText;

	public GameObject WeaponsText;

	public CanvasGroup CanvasGroup;

	public List<StatPreviewText> StatPreviewTexts;

	public List<SlotInfoPart> WeaponsSlotInfoPart;

	public TextMeshProUGUI PartInfoSkillText;

	public void ActiveInfo(bool active)
	{
	}

	public void SetStatsPreviewTexts(PartStats partStats, PartPreviewCategory category, float speed = 0f, int magnetSize = 0, BodyType bodyType = null, BaseType baseType = null)
	{
	}

	public void ClearStatsPreviewTexts()
	{
	}

	private void ClearWeaponsSlotInfoParts()
	{
	}

	private void SetPartInfoSkillText(PartPreviewCategory category, BodyType bodyType, BaseType baseType)
	{
	}

	private void SetWeaponsSlotPreview(BodyType selectedBody)
	{
	}

	private static void GetWeaponSlotCounts(BodyType body, out int slotA, out int slotB, out int slotC, out int slotD)
	{
		slotA = default;
		slotB = default;
		slotC = default;
		slotD = default;
	}

	private void TryShowStat(ref int statIndex, string statNameKey, float selectedValue, bool isPercent)
	{
	}

	private void TryShowSlotChange(ref int slotIndex, Weapon.SlotType slotType, int selectedCount)
	{
	}

	private void ActiveCanvas(bool active)
	{
	}
}
