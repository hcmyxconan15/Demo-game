using UnityEngine;

public class EnemyBullet : EnemyBulletBase, IProjectileLifetimeTick
{
	private const float HitLingerTime = 3f;

	private const float ImpactRayBackDistance = 1f;

	private const float ImpactRayMaxDistance = 4f;

	private const float ImpactSurfaceOffset = 0.1f;

	public int PlusDamage;

	public bool PerpendicularToFloor;

	[Tooltip("Place the ground/rock impact mark on the hit surface via raycast and align it to the surface (Ground faces up).")]
	public bool AlignImpactEffectToSurface;

	public short EffectId;

	public short EffectIdOnRobot;

	public Rigidbody RigidBody;

	public float Speed;

	public ParticleSystem BulletParticleSystem;

	public float LifeTime;

	private float _lifeTime;

	private bool _hit;

	private bool _waitingDisable;

	private float _disableTimer;

	private Collider[] _colliders;

	[Header("EnemyBulletsBody")]
	public bool UseBody;

	public GameObject BodyComponent;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnBulletDisabled()
	{
	}

	public void TickProjectileLifetime(float deltaTime)
	{
	}

	private void SetCollidersEnabled(bool value)
	{
	}

	private void DeactivateByTime()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void PlayAlignedImpactEffect(Collider other)
	{
	}

	internal override void DeactivateBullet()
	{
	}
}
