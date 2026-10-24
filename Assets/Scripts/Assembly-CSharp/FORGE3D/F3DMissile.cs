using UnityEngine;

namespace FORGE3D
{
	public class F3DMissile : MonoBehaviour
	{
		public enum MissileType
		{
			Unguided = 0,
			Guided = 1,
			Predictive = 2
		}

		public MissileType missileType;

		public Transform target;

		public LayerMask layerMask;

		public float detonationDistance;

		public float lifeTime;

		public float despawnDelay;

		public float velocity;

		public float alignSpeed;

		public float RaycastAdvance;

		public bool DelayDespawn;

		public ParticleSystem[] delayedParticles;

		private ParticleSystem[] particles;

		private new Transform transform;

		private bool isHit;

		private bool isFXSpawned;

		private float timer;

		private Vector3 targetLastPos;

		private Vector3 step;

		private MeshRenderer meshRenderer;

		public F3DMissileLauncher launcher;

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

		private void OnMissileDestroy()
		{
		}

		private void OnHit()
		{
		}

		private void Update()
		{
		}
	}
}
