using UnityEngine;

namespace Missiles
{
	public class LowFlyMissile : MissileScript
	{
		[Header("Specific variables.")]
		[Tooltip("This is the projectile fall speed.")]
		public float fallSpeed;

		[Tooltip("LayerMask to determine what is considered ground for the projectile.")]
		public LayerMask whatIsGround;

		[Tooltip("Distance between the projectile and the ground.")]
		public float distanceToGround;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
