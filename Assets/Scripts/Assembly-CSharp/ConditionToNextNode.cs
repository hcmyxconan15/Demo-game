using System;
using UnityEngine;

[Serializable]
public class ConditionToNextNode
{
	public enum PassNodeType
	{
		Timer = 0,
		KillEnemy = 1,
		KillElite = 2,
		KillMercenary = 3,
		KillBoss = 4,
		SpecialEvent = 5,
		OptionalHunt = 6
	}

	public string ConditionName;

	public string ConditionNameKey;

	public int ConditionLevel;

	public PassNodeType Condition;

	public float Value;

	public float MaxValue;

	public float MaxTimeForThisNode;

	public Sprite ConditionIcon;
}
