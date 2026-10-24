using System.Collections.Generic;
using UnityEngine;

public class ExplosionsOnAnimation : MonoBehaviour
{
	public List<ParticleSystem> ParticleSystems;

	[Header("Particle Id")]
	public int ParticleId;

	public List<Transform> ParticleSystemsCustomPosition;

	public void PlayEffect(int idPosition)
	{
	}

	public void PlayCustomEffect(int id)
	{
	}
}
