using Missiles;
using UnityEngine;

public abstract class EnemyBulletBase : MonoBehaviour
{
	public int Id;

	public int SoundId;

	public Transform TargetBase;

	public EnemyBase EnemyBase;

	public BaseMissile BaseMissile;

	[HideInInspector]
	public bool InPool;

	[HideInInspector]
	public bool IsPooledInstance;

	private void OnDisable()
	{
	}

	protected virtual void OnBulletDisabled()
	{
	}

	public void ReturnToPoolIfNeeded()
	{
	}

	internal virtual void Shot(Transform launchPosition, Vector3 targetPosition)
	{
	}

	internal abstract void DeactivateBullet();
}
