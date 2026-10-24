using UnityEngine;

namespace FORGE3D
{
	public class F3DWarpJumpTunnel : MonoBehaviour
	{
		private new Transform transform;

		private MeshRenderer meshRenderer;

		public float StartDelay;

		public float FadeDelay;

		public Vector3 ScaleTo;

		public float ScaleTime;

		public float ColorTime;

		public float ColorFadeTime;

		public float RotationSpeed;

		private bool grow;

		private float alpha;

		private int alphaID;

		private void Awake()
		{
		}

		public void OnSpawned()
		{
		}

		private void ToggleGrow()
		{
		}

		private void Update()
		{
		}
	}
}
