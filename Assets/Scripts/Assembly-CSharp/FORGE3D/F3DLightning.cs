using UnityEngine;

namespace FORGE3D
{
	[RequireComponent(typeof(LineRenderer))]
	public class F3DLightning : MonoBehaviour
	{
		public LayerMask layerMask;

		public Texture[] BeamFrames;

		public float FrameStep;

		public bool RandomizeFrames;

		public int Points;

		public float MaxBeamLength;

		public float beamScale;

		public bool AnimateUV;

		public float UVTime;

		public bool Oscillate;

		public float Amplitude;

		public float OscillateTime;

		public Transform rayImpact;

		public Transform rayMuzzle;

		private LineRenderer lineRenderer;

		private RaycastHit hitPoint;

		private int frameNo;

		private int FrameTimerID;

		private int OscillateTimerID;

		private float beamLength;

		private float initialBeamOffset;

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

		private float GetRandomNoise()
		{
			return 0f;
		}

		private void OnFrameStep()
		{
		}

		private void OnOscillate()
		{
		}

		private void Animate()
		{
		}

		private void ApplyForce(float force)
		{
		}

		private void Update()
		{
		}
	}
}
