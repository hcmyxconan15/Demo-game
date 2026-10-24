using UnityEngine;

public class EnemyTurretSkyAttack : EnemyBase
{
	[Header("Sky attack")]
	public int LifePercentTrigger;

	public int BulletId;

	public float CooldownSkyAttack;

	public float DistanceToAttackToSkyAttack;

	private float _cooldownSkyAttack;

	public override void ActiveEnemy(Vector3 position)
	{
	}

	private void Update()
	{
	}

	private void StartSkyAttack()
	{
	}
}
