using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Microchip
{
	public string ChipDescriptionName;

	public string RealName;

	[Tooltip("If true, this microchip is excluded from the game entirely (level-up, shop, hub unlocks, unlock lists). Treat as if it does not exist.")]
	public bool NotInclude;

	public bool NotAvailable;

	public bool NotFoundByLevelUp;

	[Tooltip("Show a floating icon over the player when this microchip triggers a runtime effect. Passive stat chips never show it.")]
	public bool ShowActivationPopup;

	public Sprite Icon;

	public int Id;

	public int MaxLevel;

	public int BasePrice;

	public int UnlockPrice;

	public List<StatToIncrease> StatToIncreases;

	public List<GameTag> ResolvedTags;

	public List<GameTag> ExtraTags;

	public TagRequirements TagGate;

	public List<BuildArchetype> Archetypes;

	public List<int> RequiredWeaponsId;

	[Tooltip("OR list — the player needs any one of these drone ids installed.")]
	public List<int> RequiredDronesId;

	public List<int> RequiredOverloadId;

	public List<int> RequiredChipsId;

	public List<int> IncompatibleChipsId;

	public void SetDescriptionName(string unlockCondition)
	{
	}

	public void RefreshResolvedTags()
	{
	}

	public void IsolateTagGate()
	{
	}
}
