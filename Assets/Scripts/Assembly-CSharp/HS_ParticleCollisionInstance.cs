using System.Collections.Generic;
using UnityEngine;

public class HS_ParticleCollisionInstance : MonoBehaviour
{
	public GameObject[] EffectsOnCollision;

	public float DestroyTimeDelay;

	public bool UseWorldSpacePosition;

	public float Offset;

	public Vector3 rotationOffset;

	public bool useOnlyRotationOffset;

	public bool UseFirePointRotation;

	public bool DestoyMainEffect;

	private ParticleSystem part;

	private List<ParticleCollisionEvent> collisionEvents;

	private ParticleSystem ps;

	private void Start()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
