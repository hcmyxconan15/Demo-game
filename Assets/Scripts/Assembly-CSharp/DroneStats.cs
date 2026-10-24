using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DroneStats
{
	public string DroneDescriptionName;

	public string DroneName;

	public DroneRole Role;

	[Tooltip("If true, this drone is excluded from the game entirely (level-up, shop, hub unlocks, unlock lists). Treat as if it does not exist.")]
	public bool NotInclude;

	public bool NotAvailable;

	public bool NotFoundByLevelUp;

	public Sprite Icon;

	public int DroneId;

	public int DroneWeaponId;

	public int DroneMaxLevel;

	[Tooltip("Every N levels, spawn another copy on the same mech slot. Never at level 1. 0 = never. Example: 3 → at levels 3, 6, 9; 1 → each level-up (2, 3, 4…).")]
	public int DuplicateEveryNLevels;

	[Tooltip("MAX hunt range from the player. Drone only targets XP/coins inside this circle.")]
	public float CollectRadius;

	[Tooltip("Player easy-pickup dead zone. Prefer loot in [this → Collect Radius]. While sucking, items closer than this to the player are ignored. Falls back to closer loot only if the outer ring is empty.")]
	public float CollectPreferMinRadius;

	[Tooltip("How many XP/coin pickups the drone banks before returning to deposit.")]
	public int CollectCapacity;

	public int BasePrice;

	public int UnlockPrice;

	public Drone DronePrefab;

	public List<BuildArchetype> Archetypes;

	public int GetDesiredInstanceCount(int level)
	{
		return 0;
	}

	public int GetNextDuplicateLevel(int currentLevel)
	{
		return 0;
	}

	private int GetFirstDuplicateLevel()
	{
		return 0;
	}
}
