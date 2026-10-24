using UnityEngine;

namespace FORGE3D
{
	public class F3DTurret : MonoBehaviour
	{
		public enum TurretTrackingType
		{
			Step = 0,
			Smooth = 1
		}

		[HideInInspector]
		public bool destroyIt;

		public TurretTrackingType TrackingType;

		public GameObject Mount;

		public GameObject Swivel;

		private Vector3 defaultDir;

		private Quaternion defaultRot;

		private Transform headTransform;

		private Transform barrelTransform;

		public float HeadingTrackingSpeed;

		public float ElevationTrackingSpeed;

		private Vector3 targetPos;

		[HideInInspector]
		public Vector3 headingVetor;

		private float curHeadingAngle;

		private float curElevationAngle;

		public Vector2 HeadingLimit;

		public Vector2 ElevationLimit;

		public bool DebugDraw;

		public Transform DebugTarget;

		private bool fullAccess;

		public Animator[] Animators;

		private Vector3 PreviousTargetPosition;

		private void Awake()
		{
		}

		public void PlayAnimation()
		{
		}

		public void PlayAnimationLoop()
		{
		}

		public void StopAnimation()
		{
		}

		private void Start()
		{
		}

		public void SetNewTarget(Vector3 _targetPos)
		{
		}

		public float GetAngleToTarget()
		{
			return 0f;
		}

		private void Update()
		{
		}
	}
}
