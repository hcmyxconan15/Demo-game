using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(Graphic))]
	public class BarViewColorWhileMoving : ProgressBarProView
	{
		[SerializeField]
		protected Graphic graphic;

		[SerializeField]
		private Color colorStatic;

		[SerializeField]
		private Color colorMoving;

		[SerializeField]
		private float blendTimeOnMove;

		[SerializeField]
		private float blendTimeOnStop;

		private bool isMoving;

		private void OnEnable()
		{
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private Color GetCurrentColor()
		{
			return default;
		}

		private void SetDefaultColor()
		{
		}
	}
}
