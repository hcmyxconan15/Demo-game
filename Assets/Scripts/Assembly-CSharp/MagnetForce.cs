using UnityEngine;

public class MagnetForce : MonoBehaviour, IActiveEffectTick
{
	public float SpeedToPlayer;

	public bool EndDropAnimation;

	public ParticleSystem ParticleSystem;

	public bool IgnoreMagnetWhenPlayerIsFull;

	[HideInInspector]
	public bool UnderMagnet;

	private Transform _gravityCenterTransform;

	private float _force;

	private float _acceleration;

	private Vector3 _direction;

	private Vector3 _position;

	private float _magnetReadyTime;

	private float _timeForBackMagnet;

	private int _directionForce;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void TickActiveEffect(float deltaTime)
	{
	}

	public void ForceMagnet(Transform transformToGo)
	{
	}

	public void StopCollectParticle()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private bool ShouldIgnoreMagnet()
	{
		return false;
	}
}
