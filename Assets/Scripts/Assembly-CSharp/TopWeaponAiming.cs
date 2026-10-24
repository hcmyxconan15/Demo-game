using UnityEngine;

public class TopWeaponAiming : MonoBehaviour
{
	private const float SearchInterval = 0.3f;

	[Header("Enemies")]
	public EnemyBase SelectedNearestTarget;

	public float RotationSpeed;

	public Transform TurretTargetToLook;

	public Transform TurretTransform;

	public MechPlayerController MechPlayerController;

	private float _searchTimer;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
