using UnityEngine;

namespace Missiles
{
	public class AirToAir : MissileScript
	{
		[Header("Specific variables")]
		[Tooltip("This is the time the projectile waits to activate after launching.")]
		public float activateMissile;

		[Tooltip("This is the projectile fall speed.")]
		public float fallSpeed;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
