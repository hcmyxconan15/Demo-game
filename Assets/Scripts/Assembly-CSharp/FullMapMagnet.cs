using UnityEngine;

public class FullMapMagnet : MonoBehaviour
{
	public bool Taken;

	public float SpeedToPlayer;

	private bool _underMagnet;

	private Transform _gravityCenterTransform;

	private float _force;

	private float _acceleration;

	private Vector3 _direction;

	private Vector3 _position;

	private float _timeForMagnet;

	private float _timeForBackMagnet;

	private int _directionForce;

	public ParticleSystem GroundParticle;

	public MagnetForce MagnetForce;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void FixedUpdate()
	{
	}

	public void ForceMagnet(Transform transformToGo)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
