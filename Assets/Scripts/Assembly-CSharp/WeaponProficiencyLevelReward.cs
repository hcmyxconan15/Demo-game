using System;
using UnityEngine;

[Serializable]
public class WeaponProficiencyLevelReward
{
	[Tooltip("1-based proficiency level that grants this reward.")]
	public int Level;

	public WeaponProficiencyStat Stat;

	public float BonusValue;
}
