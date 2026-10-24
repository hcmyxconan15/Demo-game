using System;
using UnityEngine;

[Serializable]
public class PowerUpData
{
	public string PowerUpDescriptionName;

	public string NameKey;

	public PowerUpType Type;

	public Sprite Icon;

	public int Id;

	public float Value;

	public int Max;

	public int SkillPointsPrice;

	public int SkillPointsPriceUpgradeMultiplier;
}
