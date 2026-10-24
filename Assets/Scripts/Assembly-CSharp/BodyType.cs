using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BodyType
{
	public string BodyDescriptionName;

	public string BodyName;

	public bool NotAvailable;

	public Sprite Icon;

	public ushort BodyId;

	public int MagnetSize;

	public int UnlockPrice;

	public BodyJoin BodyJoin;

	public PartStats PartStats;

	public List<GameTag> ExtraTags;

	public List<BuildArchetype> Archetypes;

	public int LevelGrowthMaxTimes;

	public int LevelGrowthLevelInterval;

	public List<StatToIncrease> LevelGrowthStats;

	public List<BodySpecialSkill> SpecialSkills;
}
