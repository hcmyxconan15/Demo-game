public class EnemyDamageOnExplode : EnemyBulletBase
{
	public float Damage;

	public float DamageRadius;

	public short EffectId;

	public MechPlayerController MechPlayerController;

	private void OnEnable()
	{
	}

	protected override void OnBulletDisabled()
	{
	}

	private void ApplyExpandDamage(int damage)
	{
	}

	internal override void DeactivateBullet()
	{
	}
}
