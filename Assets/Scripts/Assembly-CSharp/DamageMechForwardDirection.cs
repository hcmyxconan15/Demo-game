using UnityEngine;

public class DamageMechForwardDirection : DamageBase, IProjectileLifetimeTick
{
	public bool PerpendicularToFloor;

	public short EffectId;

	public Rigidbody RigidBody;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	public float LifeTime;

	private float _lifeTime;

	private bool _hit;

	private Vector3 _moveDirection;

	private bool _movementActive;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void TickProjectileLifetime(float deltaTime)
	{
	}

	private void DeactivateByTime()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DisableBullet()
	{
	}
}
