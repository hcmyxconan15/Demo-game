using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(Text))]
	public class BarViewValueText : ProgressBarProView
	{
		[SerializeField]
		private Text text;

		[SerializeField]
		private string prefix;

		[SerializeField]
		private float minValue;

		[SerializeField]
		private float maxValue;

		[SerializeField]
		private int numDecimals;

		[SerializeField]
		private bool showMaxValue;

		[SerializeField]
		private string numberUnit;

		[SerializeField]
		private string suffix;

		private float lastDisplayValue;

		public override bool CanUpdateView(float currentValue, float targetValue)
		{
			return false;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private float GetDisplayValue(float num)
		{
			return 0f;
		}

		private float GetRoundedDisplayValue(float num)
		{
			return 0f;
		}

		private string FormatNumber(float num)
		{
			return null;
		}
	}
}
