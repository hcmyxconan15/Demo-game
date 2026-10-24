using System.Collections.Generic;
using UnityEngine;

public class PoissonDiskSpawner : EnemyBase
{
	[Header("PoissonDiskSpawner Properties")]
	public int EnemyIdToSpawn;

	public float Radius;

	public float MinDistance;

	public int MaxAttempts;

	public float NavMeshSampleDistance;

	public LayerMask NavMeshAreaMask;

	public Vector3 OffsetUpPosition;

	private List<Vector2> _samples;

	public override void ActiveEnemy(Vector3 position)
	{
	}

	public void LookAtWithHorizontalOffset(Transform self, Transform target, float distance)
	{
	}

	private void Spawn()
	{
	}

	private List<Vector2> GeneratePoints(float minDist, float radius, int attempts)
	{
		return null;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
