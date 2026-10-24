using System.Collections.Generic;
using UnityEngine;

public class EnemyUpperTurretController : MonoBehaviour
{
	public bool Active;

	public bool CanRotate;

	public float RotationSpeed;

	public Transform Target;

	public List<BallisticTurret> EnemyTurrets;

	public Transform BaseTransform;

	[SerializeField]
	private Transform TurretTransform;

	private void Update()
	{
	}

	private void RotateTurret()
	{
	}

	public void ActiveAttacksTurrets(EnemyMovement enemyMovement)
	{
	}
}
