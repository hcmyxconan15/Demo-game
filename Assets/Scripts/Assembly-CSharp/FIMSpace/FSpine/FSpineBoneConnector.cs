using UnityEngine;
using UnityEngine.EventSystems;

namespace FIMSpace.FSpine
{
	[AddComponentMenu("FImpossible Creations/Spine Animator Utilities/FSpine Bone Connector")]
	public class FSpineBoneConnector : MonoBehaviour, IDropHandler, IEventSystemHandler, IFHierarchyIcon
	{
		[Space(5f)]
		public FSpineAnimator TargetSpineAnimator;

		public Transform TargetBone;

		[Space(3f)]
		[FPD_Width(130)]
		public bool PositionAnimated;

		[FPD_Width(130)]
		public bool RotationAnimated;

		[Space(3f)]
		public Vector3 RotationCorrection;

		public bool Mirror;

		private Vector3 animatorStatePosition;

		private Quaternion animatorStateRotation;

		private Quaternion targetBoneStateRotation;

		public string EditorIconPath => null;

		public void OnDrop(PointerEventData data)
		{
		}

		private void Start()
		{
		}

		internal void RememberAnimatorState()
		{
		}

		internal void RefreshAnimatorState()
		{
		}
	}
}
