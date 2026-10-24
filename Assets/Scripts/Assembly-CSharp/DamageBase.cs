using System.Collections.Generic;
using UnityEngine;

public class DamageBase : MonoBehaviour
{
	protected static readonly Collider[] SharedColliderBuffer;

	private List<StatsBase> _overlapStatsSnapshot;

	protected static readonly WaitForSeconds Wait01;

	protected static readonly WaitForSeconds Wait02;

	protected static readonly WaitForSeconds Wait05;

	protected static readonly WaitForSeconds Wait1;

	protected static readonly WaitForSeconds Wait2;

	public bool IsOverload;

	public int BulletId;

	public int WeaponId;

	public int DroneId;

	public int Damage;

	public bool IsCritical;

	public float OnFiredTime;

	public int TickNeedForAccumulatedFirePotencyUp;

	public float OnShockTime;

	public float OnWeakTime;

	public float OnMarkTime;

	public int OnMarkCriticalChanceBonus;

	public int CriticalRollDamage;

	public float StackDamage;

	public float PushBack;

	public bool DontReduceDamageOnPassEnemy;

	public int PassEnemyCount;

	public int RicochetCount;

	public int AngleOffset;

	[HideInInspector]
	public int BulletSoundId;

	public BulletType.BulletClassType Type;

	public BulletType.TypeOfBullet TypeBullet;

	[HideInInspector]
	public int ChainBulletId;

	[HideInInspector]
	public int ChainDamagePercent;

	[HideInInspector]
	public int ChainActivationPercent;

	[HideInInspector]
	public bool ChainSpawnOnGround;

	[HideInInspector]
	public bool IsChainSpawned;

	[HideInInspector]
	public Collider ColliderToIgnore;

	[HideInInspector]
	public StatsBase _statsBase;

	[HideInInspector]
	public bool InPool;

	[HideInInspector]
	public bool IsPooledInstance;

	public void ReturnToPool()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void DeactivateBullet()
	{
	}

	public virtual void ApplyExpandDamage()
	{
	}

	protected List<StatsBase> SnapshotOverlapStats(int count)
	{
		return null;
	}

	public void ReduceDamageAfterPierce()
	{
	}

	public void TryChainBulletOnHit(Collider hitCollider = null)
	{
	}

	public void SpawnChainBullet(int chainBulletId, int chainDamagePercent, int chainActivationPercent, bool spawnOnGround, Collider hitCollider = null)
	{
	}
}
