using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(RectTransform))]
	public class BarViewPosImageFill : ProgressBarProView
	{
		[SerializeField]
		private RectTransform rectTrans;

		[SerializeField]
		private Image referenceImage;

		[Range(-1f, 1f)]
		[SerializeField]
		private float offset;

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private Vector2 GetAnchor(float currentDisplay)
		{
			return default;
		}

		private Vector2 GetAnchorHorizontal(float fillAmount, int fillOrigin)
		{
			return default;
		}

		private Vector2 GetAnchorVertical(float fillAmount, int fillOrigin)
		{
			return default;
		}

		private Vector2 GetAnchorRadial360(float fillAmount, int fillOrigin, bool fillClockwise)
		{
			return default;
		}

		private Vector2 GetPointOnCircle(float degrees)
		{
			return default;
		}
	}
}
