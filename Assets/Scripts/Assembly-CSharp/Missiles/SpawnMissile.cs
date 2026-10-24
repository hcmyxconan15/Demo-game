using UnityEngine;

namespace Missiles
{
	public class SpawnMissile : MissileScript
	{
		[Header("Specific variables")]
		[Tooltip("The object to spawn")]
		public GameObject[] spawn;

		[Tooltip("The rotation for the spawn")]
		public Vector3 rotation;

		private Vector3 m_Position;

		public override void MissileContact()
		{
		}

		private void Spawn()
		{
		}
	}
}
