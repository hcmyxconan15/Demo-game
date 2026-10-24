using System.Collections.Generic;
using UnityEngine;

public class EnemySpatialGrid
{
	private readonly float _cellSize;

	private readonly float _invCellSize;

	private readonly Dictionary<long, List<EnemyBase>> _cells;

	private readonly Dictionary<EnemyBase, long> _enemyCellKeys;

	public EnemySpatialGrid(float cellSize)
	{
	}

	public void RefreshEnemy(EnemyBase enemy)
	{
	}

	public void RemoveEnemy(EnemyBase enemy)
	{
	}

	public void CollectInRadius(Vector3 center, float maxDistance, List<EnemyBase> results)
	{
	}

	public void CollectInRadius(Vector3 center, float maxDistance, List<EnemyBase> results, bool horizontalOnly)
	{
	}

	private static float HorizontalSqrDistance(float ax, float az, float bx, float bz)
	{
		return 0f;
	}

	private int WorldToCell(float worldCoord)
	{
		return 0;
	}

	private static long CellKey(int cellX, int cellZ)
	{
		return 0L;
	}

	private void AddToCell(EnemyBase enemy, long key)
	{
	}

	private void RemoveFromCell(EnemyBase enemy, long key)
	{
	}
}
