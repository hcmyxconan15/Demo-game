using System.Collections.Generic;
using UnityEngine;

public class LaserBeam : DamageBase
{
	public Collider DamageCollider;

	public ParticleSystem BulletParticleSystem;

	public DamageBase DamageBase;

	public LayerMask RayCollisionLayerMask;

	public LayerMask RayCollisionLayerMaskWalls;

	public GameObject HitEffect;

	public float HitOffset;

	public bool useLaserRotation;

	public float MaxLength;

	[SerializeField]
	private LineRenderer Laser;

	public float MainTextureLength;

	public float NoiseTextureLength;

	public AudioSource AudioSource;

	private Vector4 Length;

	[SerializeField]
	private bool LaserSaver;

	[SerializeField]
	private bool UpdateSaver;

	[SerializeField]
	private List<ParticleSystem> Hit;

	private static readonly int MainTex;

	private static readonly int Noise;

	private float _hitOffset;

	private Material _laserMaterial;

	private void Awake()
	{
	}

	public override void DeactivateBullet()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void DisablePrepare()
	{
	}
}
