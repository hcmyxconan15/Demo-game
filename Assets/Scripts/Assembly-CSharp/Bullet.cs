using UnityEngine;

public class Bullet : DamageBase, IProjectileLifetimeTick
{
	private const float HitLingerTime = 3f;

	public bool PerpendicularToFloor;

	public short EffectId;

	public Rigidbody RigidBody;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	public float LifeTime;

	public bool InstantDestroy;

	private float _lifeTime;

	private bool _hit;

	private bool _waitingDisable;

	private float _disableTimer;

	private Collider[] _colliders;

	private Vector3 _moveDirection;

	private bool _movementActive;

	[SerializeField]
	private float RicochetAngle;

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

	private void SetCollidersEnabled(bool value)
	{
	}

	private void InitBullet()
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

	private void Ricochet()
	{
	}
}
