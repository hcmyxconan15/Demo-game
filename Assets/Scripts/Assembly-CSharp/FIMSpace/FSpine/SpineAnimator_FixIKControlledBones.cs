using UnityEngine;

namespace FIMSpace.FSpine
{
	[DefaultExecutionOrder(-12)]
	[AddComponentMenu("FImpossible Creations/Spinal Animator Utilities/Spinal Animator IK Controlled Bone Fixer")]
	public class SpineAnimator_FixIKControlledBones : MonoBehaviour
	{
		public Transform SkeletonParentBone;

		[Tooltip("If bones are twisting with this option off you should turn it on (calibrating bone if it's animation don't use keyframes)")]
		public bool Calibrate;

		private Quaternion initLocalRot;

		private Vector3 initLocalPos;

		private Quaternion localRotation;

		private Vector3 localPosition;

		private void Start()
		{
		}

		public void Calibration()
		{
		}

		public void UpdateOnAnimator()
		{
		}

		public void UpdateAfterProcedural()
		{
		}
	}
}
