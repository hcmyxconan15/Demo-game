using UnityEngine;
using UnityEngine.UI;

public class ManageSliders : MonoBehaviour
{
	public bool Active;

	public float ValueToChange;

	public Slider Slider;

	public GameObject ActiveSliderMark;

	public MenuNavigation ParentMenuNavigation;

	private bool _right;

	private bool _left;

	private bool _buttonDown;

	private bool _buttonDownRight;

	private bool _rightLongPressed;

	private bool _leftLongPressed;

	private float _timeToApply;

	private void Update()
	{
	}

	public void ActiveComponent(bool active)
	{
	}

	public void ForceClose()
	{
	}

	public void MoveSliderLeftDirection()
	{
	}

	public void MoveSliderRightDirection()
	{
	}
}
