using UnityEngine;

public class EnemyDamageArea : EnemyBulletBase
{
	public int DamagePlus;

	[SerializeField]
	private int EffectId;

	private void OnTriggerEnter(Collider other)
	{
	}

	internal override void DeactivateBullet()
	{
	}
}
