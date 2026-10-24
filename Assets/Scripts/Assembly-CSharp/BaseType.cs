using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BaseType
{
	public string BaseDescriptionName;

	public string BodyName;

	public bool NotAvailable;

	public Sprite Icon;

	public GameObject BasePrefab;

	public ushort BaseId;

	public float Speed;

	public int DashCharges;

	public int DashCooldown;

	public int UnlockPrice;

	public PartStats PartStats;

	public List<GameTag> ExtraTags;

	public List<BuildArchetype> Archetypes;

	public int LevelGrowthMaxTimes;

	public int LevelGrowthLevelInterval;

	public List<StatToIncrease> LevelGrowthStats;

	public int GetResolvedDashCharges()
	{
		return 0;
	}

	public float GetResolvedDashCooldown()
	{
		return 0f;
	}
}
