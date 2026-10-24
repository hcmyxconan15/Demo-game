using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletsController : MonoBehaviour
{
	public Transform EnemyBulletParent;

	public List<EnemyBulletBase> EnemyBulletPool;

	public EnemiesBulletsDb EnemiesBulletsDb;

	public EnemyBase Gaia;

	public static EnemyBulletsController Instance;

	private readonly Dictionary<int, Stack<EnemyBulletBase>> _bulletPoolById;

	private readonly Dictionary<int, List<EnemyBulletBase>> _allBulletsById;

	private bool _suppressBulletRelease;

	private void Awake()
	{
	}

	private void EnsurePoolCollections(int bulletId)
	{
	}

	private EnemyBulletBase CreateBulletInstance(int id)
	{
		return null;
	}

	private EnemyBulletBase FindInactivePooledBullet(int id)
	{
		return null;
	}

	private EnemyBulletBase RentBullet(int id, Transform launchPosition)
	{
		return null;
	}

	public void ReleaseBullet(EnemyBulletBase bullet)
	{
	}

	public void LaunchAttack(EnemyBase enemyBase, int id, Transform launchPosition)
	{
	}

	public void LaunchMissileAttack(EnemyBase enemyBase, int id, Transform launchPosition, Transform target)
	{
	}

	public void LaunchBallisticAttack(EnemyBase enemyBase, int id, Transform launchPosition, Vector3 targetPosition)
	{
	}

	public EnemyBulletBase GetPermanentBullet(EnemyBase enemyBase, int id, Transform launchPosition)
	{
		return null;
	}

	public void GaiaSkill(int id, Transform launchPosition)
	{
	}
}
