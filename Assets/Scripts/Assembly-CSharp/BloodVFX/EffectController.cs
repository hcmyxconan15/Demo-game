using UnityEngine;

namespace BloodVFX
{
	public class EffectController : MonoBehaviour
	{
		[Space(10f)]
		public int spawnNumber;

		public float spawnRadius;

		public float minScale;

		public float maxScale;

		public float spread;

		public float minForce;

		public float maxForce;

		public GameObject[] prefabs;

		private Rigidbody[] rigids;

		private void OnEnable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
