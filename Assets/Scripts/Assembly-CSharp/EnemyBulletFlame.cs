using UnityEngine;

public class EnemyBulletFlame : EnemyBulletBase
{
	public int PlusDamage;

	public float TicksTime;

	public int EffectIdOnRobot;

	public Collider DamageCollider;

	public ParticleSystem BulletParticleSystem;

	public AudioSource AudioSource;

	public string RequiredTag;

	private float _ticksTime;

	private bool _playerInside;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void ActivateBullet()
	{
	}

	internal override void DeactivateBullet()
	{
	}

	private void DisableAfterDelay()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void ApplyDamage()
	{
	}

	protected override void OnBulletDisabled()
	{
	}
}
