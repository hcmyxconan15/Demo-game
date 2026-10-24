using UnityEngine;

namespace FORGE3D
{
	public class F3DProjectile : MonoBehaviour
	{
		public F3DFXType fxType;

		public LayerMask layerMask;

		public float lifeTime;

		public float despawnDelay;

		public float velocity;

		public float RaycastAdvance;

		public bool DelayDespawn;

		public ParticleSystem[] delayedParticles;

		private ParticleSystem[] particles;

		private new Transform transform;

		private RaycastHit hitPoint;

		private bool isHit;

		private bool isFXSpawned;

		private float timer;

		private float fxOffset;

		private void Awake()
		{
		}

		public void OnSpawned()
		{
		}

		public void OnDespawned()
		{
		}

		private void Delay()
		{
		}

		private void OnProjectileDestroy()
		{
		}

		private void ApplyForce(float force)
		{
		}

		private void Update()
		{
		}

		public void SetOffset(float offset)
		{
		}
	}
}
