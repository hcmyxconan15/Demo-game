using System;
using UnityEngine;

[Serializable]
public class Achievement
{
	public AchievementsDatabase.AchievementApiName AchievementApiName;

	public AchievementsDatabase.StatsApiName StatsApiName;

	public int MinValue;

	public int MaxValue;

	public string Name;

	public string Description;

	public Sprite Icon;

	public Sprite IconOf;
}
