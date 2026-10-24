using UnityEngine;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(RectTransform))]
	public class BarViewSizeAnchors : ProgressBarProView
	{
		public enum FillType
		{
			LeftToRight = 0,
			RightToLeft = 1,
			TopToBottom = 2,
			BottomToTop = 3
		}

		[SerializeField]
		protected RectTransform rectTrans;

		[SerializeField]
		protected FillType fillType;

		[SerializeField]
		private bool hideOnEmpty;

		[SerializeField]
		private bool useDiscreteSteps;

		[SerializeField]
		private int numSteps;

		protected DrivenRectTransformTracker m_Tracker;

		protected bool isDisplaySizeZero;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			return false;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		protected void SetPivot(float startEdge, float endEdge)
		{
		}

		private void UpdateTracker()
		{
		}

		private void OnDisable()
		{
		}
	}
}
