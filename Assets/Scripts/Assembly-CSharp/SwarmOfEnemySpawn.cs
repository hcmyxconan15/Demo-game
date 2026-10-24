using UnityEngine;

public class SwarmOfEnemySpawn : EnemyBase
{
	[Header("Swarm properties")]
	public int SwarmSize;

	public int SwarmRadius;

	public EnemyBase SwarmEnemy;

	public override void ActiveEnemy(Vector3 position)
	{
	}
}
