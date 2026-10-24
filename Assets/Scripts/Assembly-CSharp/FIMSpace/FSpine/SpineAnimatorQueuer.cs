using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FSpine
{
	[DefaultExecutionOrder(-12)]
	[AddComponentMenu("FImpossible Creations/Spinal Animator Utilities/Spinal Animator Queuer")]
	public class SpineAnimatorQueuer : MonoBehaviour
	{
		[Tooltip("Can be used to fade out all spinal animators")]
		[FPD_Suffix(0f, 1f, FPD_SuffixAttribute.SuffixMode.From0to100, "%", true, 0)]
		public float SpineAnimatorsAmount;

		[SerializeField]
		internal List<FSpineAnimator> updateOrder;

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
