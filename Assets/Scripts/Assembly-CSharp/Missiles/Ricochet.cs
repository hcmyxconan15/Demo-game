using UnityEngine;

namespace Missiles
{
	public class Ricochet : MissileScript
	{
		[Header("Specific variables")]
		[Tooltip("This is the number of jump.")]
		public int numberOfJump;

		[Tooltip("This is the spawner.")]
		public GameObject missileSpawner;

		private void InstOther()
		{
		}

		private new void OnTriggerEnter(Collider other)
		{
		}

		public new void OnCollisionEnter(Collision other)
		{
		}
	}
}
