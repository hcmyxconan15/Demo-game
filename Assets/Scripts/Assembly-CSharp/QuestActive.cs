using System;
using System.Collections.Generic;

[Serializable]
public class QuestActive
{
	public enum QuestStatus
	{
		Accepted = 0,
		Complete = 1,
		Finish = 2
	}

	public int QuestId;

	public QuestStatus Status;

	public string QuestName;

	public string QuestDescription;

	public int CoinsRewards;

	public List<ItemsQuestActive> ItemsIdNeeds;

	public List<MonsterQuesActive> MonsterIdNeeds;

	public bool ByEnemyType;

	public EnemyData.EnemyType EnemyType;

	public int Quantity;

	public int QuantityCurrent;
}
