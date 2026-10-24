using UnityEngine;
using UnityEngine.AI;

public class EnemyOffscreenLod : MonoBehaviour
{
	private EnemyBase _enemyBase;

	private EnemyMovement _movement;

	private NavMeshAgent _navMeshAgent;

	private Animator _animator;

	private bool _hasAttackControllerDistance;

	private EnemyAttackControllerDistance _attackControllerDistance;

	private bool _hasEnemyChargeOnRange;

	private EnemyChargeOnRange _chargeOnRange;

	private bool _hasAttackController;

	private EnemyAttackController _attackController;

	private ObstacleAvoidanceType _originalObstacleAvoidanceType;

	private bool _hasOriginalObstacleAvoidanceType;

	private bool _tracksAttackState;

	private bool _isOffscreen;

	private bool _animatorWasEnabled;

	private bool _capAvoidanceQuality;

	private bool _avoidanceQualityCapped;

	public bool IsOffscreenBool => false;

	public void Initialize(EnemyBase enemyBase)
	{
	}

	public void SetOffscreen(bool offscreen)
	{
	}

	private void OnDisable()
	{
	}

	public void ForceOnscreen()
	{
	}

	public static bool IsOffscreen(EnemyBase enemy)
	{
		return false;
	}

	public bool IsAttacking()
	{
		return false;
	}

	private void DisableAnimator()
	{
	}

	private void EnableAnimator()
	{
	}

	private void DisableObstacleAvoidance()
	{
	}

	private void RestoreObstacleAvoidance()
	{
	}

	private void ApplyAvoidanceQualityCap()
	{
	}
}
