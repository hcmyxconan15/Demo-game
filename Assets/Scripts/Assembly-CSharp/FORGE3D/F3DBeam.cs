using UnityEngine;

namespace FORGE3D
{
	[RequireComponent(typeof(LineRenderer))]
	public class F3DBeam : MonoBehaviour
	{
		public LayerMask layerMask;

		public F3DFXType fxType;

		public bool OneShot;

		public Texture[] BeamFrames;

		public float FrameStep;

		public float beamScale;

		public float MaxBeamLength;

		public bool AnimateUV;

		public float UVTime;

		public Transform rayImpact;

		public Transform rayMuzzle;

		private LineRenderer lineRenderer;

		private RaycastHit hitPoint;

		private RaycastHit2D hitPoint2D;

		private int frameNo;

		private int FrameTimerID;

		private float beamLength;

		private float initialBeamOffset;

		public float fxOffset;

		private float animateUVTime;

		private void Awake()
		{
		}

		private void OnSpawned()
		{
		}

		private void OnDespawned()
		{
		}

		private void Raycast()
		{
		}

		private void OnFrameStep()
		{
		}

		private void Animate()
		{
		}

		private void ApplyForce(float force)
		{
		}

		public void SetOffset(float offset)
		{
		}

		private void Update()
		{
		}
	}
}
