using System.Collections.Generic;
using UnityEngine;

public class BoomerangBullet : DamageBase
{
	public enum BoomerangPhase
	{
		TowardsEnemy = 0,
		CurveAround = 1,
		ReturnToPlayer = 2
	}

	[Header("Boomerang Settings")]
	public bool Active;

	public bool TurnLeftDirection;

	public float Speed;

	public float TurnSpeed;

	public float CurveRadius;

	public float LifeTime;

	public float PassEnemyDistance;

	public float HitPauseDuration;

	public float HitSlowSpeedMultiplier;

	[Header("Debug")]
	public BoomerangPhase CurrentPhase;

	private float _lifeTimer;

	private float _hitPauseTimer;

	private Vector3 _targetPosition;

	private Vector3 _curveCenter;

	private float _curveAngle;

	private float _curveAngleTarget;

	private float _initialCurveRadius;

	private Vector3 _initialCurveOffset;

	private float _curvePhaseTimer;

	private const float MaxCurvePhaseTime = 3f;

	private Transform _playerTransform;

	private readonly HashSet<StatsBase> _hitEnemiesThisPass;

	private readonly List<StatsBase> _deadHitBuffer;

	private void OnEnable()
	{
	}

	private void InitBullet()
	{
	}

	private void Update()
	{
	}

	private void MoveTowardsEnemy()
	{
	}

	private void StartCurvePhase()
	{
	}

	private void CurveAroundEnemy()
	{
	}

	private void ReturnToPlayer()
	{
	}

	private float GetCurrentSpeed()
	{
		return 0f;
	}

	private float GetAdaptiveTurnSpeed(float distanceToTarget)
	{
		return 0f;
	}

	private void BeginReturnToPlayer()
	{
	}

	private void RemoveDeadHits()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void DisableBullet()
	{
	}

	private void ReturningBullet()
	{
	}
}
