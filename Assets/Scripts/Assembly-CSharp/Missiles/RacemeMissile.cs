using UnityEngine;

namespace Missiles
{
	public class RacemeMissile : MissileScript
	{
		[Header("Specific variables")]
		[Tooltip("The other missiles to launch.")]
		public GameObject missile;

		[Tooltip("The other missiles number.")]
		public int numberToSpaw;

		[Range(1f, 10f)]
		[Tooltip("The projectile time to launch other missiles.")]
		public float activateOthersTime;

		private Vector3 m_Position;

		private Quaternion m_Rotation;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SpawnOthers()
		{
		}
	}
}
