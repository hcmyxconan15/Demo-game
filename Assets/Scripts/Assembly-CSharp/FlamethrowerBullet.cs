using UnityEngine;

public class FlamethrowerBullet : DamageBase
{
	public Collider DamageCollider;

	public ParticleSystem BulletParticleSystem;

	public AudioSource AudioSource;

	private float _baseVolume;

	private void Awake()
	{
	}

	public override void DeactivateBullet()
	{
	}

	private void OnEnable()
	{
	}
}
