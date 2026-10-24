using UnityEngine;

namespace FORGE3D
{
	[RequireComponent(typeof(LineRenderer))]
	public class F3DCurvedBeam : MonoBehaviour
	{
		public Transform dest;

		public float beamScale;

		public float UVTime;

		private LineRenderer lineRenderer;

		public int curvePoints;

		public float curveHeight;

		private float initialBeamOffset;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
