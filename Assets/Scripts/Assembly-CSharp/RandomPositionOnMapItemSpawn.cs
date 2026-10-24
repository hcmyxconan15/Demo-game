using System.Collections.Generic;
using UnityEngine;

public class RandomPositionOnMapItemSpawn : MonoBehaviour
{
	public int MinimumDistanceToPlayer;

	public MapPositions MapPositions;

	public List<QuestItemOnMap> QuestItemsToSpawn;

	public List<QuestItemOnMap> SmallItemsToSpawn;

	public List<QuestItemOnMap> BigItemsToSpawn;

	public List<QuestItemOnMap> QuestItemsOnMap;

	public List<QuestItemOnMap> SmallItemsOnMap;

	public List<QuestItemOnMap> BigItemsOnMap;

	public List<int> IndexUsed;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void RemoveIndexUsed(int index)
	{
	}

	public void InitialItemsSpawn()
	{
	}

	public void SpawnItemForSmallItems()
	{
	}

	public void SpawnItemForBigItems()
	{
	}

	public void SpawnItemForQuest(List<ItemsQuestNeed> itemsQuestNeed)
	{
	}

	public void SpawnItemById(int itemId, int quantity)
	{
	}

	public PointOnMap GetValidTransformToAddItem()
	{
		return null;
	}

	private bool FarAwayFromPlayer(Transform selectedPosition)
	{
		return false;
	}

	public Vector3 GetPointAroundPosition(int radius, Transform transformPosition)
	{
		return default;
	}
}
