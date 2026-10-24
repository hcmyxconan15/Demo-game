using UnityEngine;

public class DamageTrails : DamageBase
{
	public int BulletToInstantiateId;

	[SerializeField]
	private float spawnDistance;

	private Vector3 lastSpawnPos;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void SpawnFire()
	{
	}

	private void SetDamageStatsToNewSkill(DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount)
	{
	}

	public override void DeactivateBullet()
	{
	}
}
