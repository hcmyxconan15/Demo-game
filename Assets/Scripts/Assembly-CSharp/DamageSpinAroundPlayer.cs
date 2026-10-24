using System.Collections.Generic;
using UnityEngine;

public class DamageSpinAroundPlayer : DamageBase
{
	public short EffectId;

	public MechPlayerController MechPlayerController;

	public float RotationSpeed;

	public float Radius;

	public float RadiusMax;

	public float LifeTime;

	public List<DetachablePart> DetachableParts;

	private float _lifeTime;

	private float _angle;

	private float _dpsTime;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DisableBullet()
	{
	}
}
