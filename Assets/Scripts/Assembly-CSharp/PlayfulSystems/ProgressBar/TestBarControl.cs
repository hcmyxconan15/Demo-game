using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	public class TestBarControl : MonoBehaviour
	{
		[SerializeField]
		private Transform barParent;

		[SerializeField]
		private Transform sizeButtonParent;

		[SerializeField]
		private TestSwitchBar[] barSelectors;

		private ProgressBarPro[] bars;

		private Button[] buttons;

		private Slider slider;

		private void Start()
		{
		}

		private void SetupButtons()
		{
		}

		private void SetSlider(float value)
		{
		}

		public void SetBars(float value)
		{
		}

		public void SetRandomColor()
		{
		}

		public void SetColor(Color color)
		{
		}
	}
}
