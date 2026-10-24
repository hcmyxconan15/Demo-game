using System.Collections.Generic;
using UnityEngine;

public class MapPositions : MonoBehaviour
{
	public List<PointOnMap> PositionsToSpawn;

	public List<PointOnMap> PositionsToSpawnSmallItems;

	public List<PointOnMap> PositionsToSpawnBigItems;

	[ContextMenu("Set Index and Transform")]
	public void SetIndexAndTransform()
	{
	}
}
