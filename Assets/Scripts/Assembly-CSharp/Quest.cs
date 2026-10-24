using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Quest
{
	public string QuestName;

	public int QuestId;

	public string QuestDescription;

	public int CoinsRewards;

	public List<int> QuestIdNeeds;

	public List<ItemsQuestNeed> ItemsNeeds;

	public bool ForceMonsterOnMap;

	public List<MonsterQuestNeed> MonstersNeeds;

	[Header("By enemyType")]
	public bool ByEnemyType;

	public EnemyData.EnemyType EnemyType;

	public int Quantity;

	public int QuantityCurrent;
}
