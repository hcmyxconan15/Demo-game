using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(Image))]
	public class BarViewSizeImageFill : ProgressBarProView
	{
		[SerializeField]
		protected Image image;

		[SerializeField]
		private bool hideOnEmpty;

		[SerializeField]
		private bool useDiscreteSteps;

		[SerializeField]
		private int numSteps;

		private bool isDisplaySizeZero;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			return false;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private float GetDisplayValue(float display)
		{
			return 0f;
		}
	}
}
