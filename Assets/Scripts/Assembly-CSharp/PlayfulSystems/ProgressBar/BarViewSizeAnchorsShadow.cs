using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(Image))]
	public class BarViewSizeAnchorsShadow : BarViewSizeAnchors
	{
		public enum ShadowType
		{
			Gaining = 0,
			Losing = 1
		}

		[SerializeField]
		private ShadowType shadowType;

		public override void UpdateView(float currentValue, float targetValue)
		{
		}
	}
}
