using UnityEngine;

namespace Missiles
{
	public class JavelinMissile : MissileScript
	{
		[Header("Specific variables")]
		[Range(1f, 5f)]
		[Tooltip("The projectile inactive time in air before activate and go for the target.")]
		public float timeInactive;

		private float temporalTime;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
