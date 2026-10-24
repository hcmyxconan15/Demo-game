using UnityEngine;

public class TurretController : MonoBehaviour
{
	[Header("Enemies")]
	public EnemyBase SelectedNearestTarget;

	public float MaxDistanceToSearchEnemies;

	public float MaxDistanceToChangeTarget;

	public float RotationSpeed;

	public Transform TurretTransform;

	public Transform TurretTargetToLook;

	public Transform TurretTargetNormal;

	public MechPlayerController MechPlayerController;

	private float _searchTimer;

	private float _changeDirectionTimer;

	private float _lastShotTimer;

	private EnemyBase _lastSelectedNearestTarget;

	private float _maxDistanceToSearchSqr;

	private float _maxDistanceToChangeSqr;

	private float _defaultMaxDistanceToSearchEnemies;

	private void Start()
	{
	}

	public void SetBossCameraSearchDistance(bool active)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void UpdateTarget()
	{
	}

	private void ShotNormalWeapons()
	{
	}

	private void ShotDroneWeapons()
	{
	}

	private void DistanceToEnemy()
	{
	}
}
