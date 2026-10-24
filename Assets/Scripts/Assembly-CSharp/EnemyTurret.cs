using UnityEngine;

public abstract class EnemyTurret : MonoBehaviour
{
	public bool UsingTurret;

	public bool StartShooting;

	public bool Shooting;

	public int BulletId;

	public float AttackAlertTime;

	public float AttackTime;

	public int AlertType;

	public EnemyBase EnemyBase;

	public abstract void LaunchAttack(bool useAlert);

	public abstract void CancelAttack();
}
