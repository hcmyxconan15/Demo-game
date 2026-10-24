using UnityEngine;

namespace Missiles
{
	public class Carrier : MissileScript
	{
		[Header("Specific variables")]
		[Tooltip("Time to start spawn.")]
		public float startSpawn;

		[Tooltip("Time betwen spawn.")]
		public float spawnTimeTic;

		[Tooltip("Time to end spawn after the spawn start.")]
		public float spawnCarrierTime;

		[Tooltip("Spawn the next missile in mirror rotation.")]
		public bool mirror;

		[Tooltip("The object to spawn.")]
		public GameObject carrierSpawn;

		[Tooltip("The angle to spawn the object")]
		public Vector3 spawAngle;

		private float timeTemp;

		private void Awake()
		{
		}

		public void Update()
		{
		}

		private void CarrierSpawn()
		{
		}
	}
}
