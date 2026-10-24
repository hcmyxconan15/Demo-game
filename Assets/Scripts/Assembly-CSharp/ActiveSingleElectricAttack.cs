using System.Collections.Generic;
using UnityEngine;

public class ActiveSingleElectricAttack : MonoBehaviour
{
	public int BulletId;

	public EnemyBase EnemyBase;

	public List<Transform> MuzzleParticlePosition;

	public int MarkId;

	public float ScatterRadius;

	public float MinSeparation;

	private Vector3 _lockedTargetPosition;

	private readonly List<Vector3> _impactPositions;

	private readonly List<BarsAlertComponent> _attackAlertComponents;

	private StatsEnemy _statsEnemy;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	public void RangeAttackEffect()
	{
	}

	public void LaunchRangeAttack()
	{
	}

	private void BuildImpactPositions()
	{
	}

	private void OnDisable()
	{
	}

	private void HideAlerts()
	{
	}
}
