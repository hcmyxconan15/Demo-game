using UnityEngine;

public class LineMovementEnemy : EnemyMovement
{
	[Header("Line Movement Properties")]
	public Rigidbody Rigidbody;

	public float Speed;

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	public override void OnEnableActivation()
	{
	}

	public override void StopMovement(bool stop)
	{
	}

	public override void EnableNavMesh(bool enable)
	{
	}

	public override void StopEnemyInPlace(bool stop)
	{
	}

	public override void RandomPositionOnMapToMove()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
