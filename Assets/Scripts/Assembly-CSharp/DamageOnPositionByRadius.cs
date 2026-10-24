using UnityEngine;

public class DamageOnPositionByRadius : DamageBase
{
	public float DelayDamage;

	public float DamageTimeBetweenTicks;

	public float DamageRadius;

	public LayerMask RayCasterLayer;

	public ParticleSystem ParticleSystem;

	private float _damageTimeBetweenTicks;

	private EnemyBase _initialEnemy;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public override void ApplyExpandDamage()
	{
	}
}
