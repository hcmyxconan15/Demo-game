using UnityEngine;

public class IncreaseLife : MonoBehaviour
{
	[Header("Item properties")]
	public int LifeToAdd;

	public bool TrackByPlayer;

	public bool CanBePullByMagnets;

	[Header("Magnet properties")]
	public bool Taken;

	public MagnetForce MagnetForce;

	public ParticleSystem GroundParticle;

	public float Radius;

	public float JumpPower;

	public float JumpDuration;

	private bool _useParticles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void PlayDropAnimation(Vector3 pointA)
	{
	}

	private void EndDrop()
	{
	}

	public void ForceMagnet(Transform transformToGo)
	{
	}

	private static bool IsPlayerAtFullHp()
	{
		return false;
	}
}
