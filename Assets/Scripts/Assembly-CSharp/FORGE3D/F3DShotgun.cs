using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	public class F3DShotgun : MonoBehaviour
	{
		private readonly List<ParticleCollisionEvent> _collisionEvents;

		private ParticleSystem _ps;

		private void Start()
		{
		}

		private void OnParticleCollision(GameObject other)
		{
		}
	}
}
