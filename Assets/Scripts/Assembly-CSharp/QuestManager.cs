using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
	public delegate void UpdateQuest();

	public List<int> StarterQuestOnThisMap;

	public List<int> ValidQuestOnThisMap;

	public bool CanStartNewQuest;

	public int CompletedQuests;

	public QuestData QuestData;

	public QuestDb QuestDb;

	public ItemDb ItemDb;

	public RandomPositionOnMapItemSpawn RandomPositionOnMapItemSpawn;

	public List<int> _origianlQuestPool;

	public static QuestManager QuestManagerInstance;

	[CompilerGenerated]
	private static UpdateQuest m_UpdateQuestEvent;

	public static event UpdateQuest UpdateQuestEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void AllowToStartNextQuest()
	{
	}

	private void ResetQuestPool()
	{
	}

	private void StartQuests()
	{
	}

	public void AcceptQuest(int questId)
	{
	}

	public void CancelQuest(int questIndex)
	{
	}

	public void UpdateQuestMonsterId(int monsterId, int monsterQuantity, EnemyData.EnemyType type)
	{
	}

	public void UpdateQuestByItem(int itemId, int itemQuantity)
	{
	}

	public void RemoveFinishQuest()
	{
	}

	private void SetEnemyQuestOnMap(List<MonsterQuestNeed> monsterToSpam, out bool success)
	{
		success = default;
	}

	private void CheckForQuestCompletion()
	{
	}

	private void RemoveQuest(int questIndex)
	{
	}

	public void NextQuest()
	{
	}

	public void RequestFirstQuest()
	{
	}

	private void InitQuestData()
	{
	}
}
