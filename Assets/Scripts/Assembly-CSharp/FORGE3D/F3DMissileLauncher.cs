using UnityEngine;
using UnityEngine.UI;

namespace FORGE3D
{
	public class F3DMissileLauncher : MonoBehaviour
	{
		public Transform missilePrefab;

		public Transform target;

		public Transform[] socket;

		public Transform explosionPrefab;

		private F3DMissile.MissileType missileType;

		public Text missileTypeLabel;

		private void Start()
		{
		}

		public void SpawnExplosion(Vector3 position)
		{
		}

		private void ProcessInput()
		{
		}

		private void Update()
		{
		}
	}
}
