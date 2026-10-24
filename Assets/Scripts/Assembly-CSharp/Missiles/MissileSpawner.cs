using UnityEngine;

namespace Missiles
{
	public class MissileSpawner : MonoBehaviour
	{
		public enum AxisToRotate
		{
			AroundX = 0,
			AroundY = 1,
			AroundZ = 2,
			noRotate = 3
		}

		[Header("Variables")]
		[Tooltip("This is the projectile to spawn.")]
		public GameObject missile;

		[Tooltip("This is the projectile number to spawn.")]
		public int number;

		[Tooltip("This is the spawn time per tic.")]
		public float spawnTicTime;

		[Tooltip("This is the rotation speed for the spawner.")]
		public float rotationSpeed;

		[Tooltip("This is the axis to rotate the spawner.")]
		public AxisToRotate way;

		[Tooltip("This is prefabs if have a launch effect.")]
		public GameObject launchExplotion;

		[HideInInspector]
		public int ricochetNumber;

		private GameObject newMissile;

		private void Start()
		{
		}

		private void SpawnMisile()
		{
		}
	}
}
