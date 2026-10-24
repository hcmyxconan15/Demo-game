using UnityEngine;

namespace FORGE3D
{
	public class F3DRandomize : MonoBehaviour
	{
		private new Transform transform;

		private Vector3 defaultScale;

		public bool RandomScale;

		public bool RandomRotation;

		public float MinScale;

		public float MaxScale;

		public float MinRotation;

		public float MaxRotaion;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}
	}
}
