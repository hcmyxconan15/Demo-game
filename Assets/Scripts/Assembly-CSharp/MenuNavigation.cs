using System.Collections.Generic;
using Rewired;
using UnityEngine;

public class MenuNavigation : MonoBehaviour
{
	public enum InputDirection
	{
		Up = 0,
		Right = 1,
		Down = 2,
		Left = 3
	}

	public bool Active;

	public int LastSelectedButton;

	public bool ForceToInitialButton;

	public List<NavigableButton> ButtonSelectors;

	public MainMenuJoystickBase MainMenuJoystick;

	private bool _up;

	private bool _right;

	private bool _down;

	private bool _left;

	private bool _buttonDown;

	private float _previousHorizontalAxis;

	private float _previousVerticalAxis;

	private bool _axisStateDirty;

	private float _timeToApply;

	private const float AxisPressThreshold = 0.5f;

	private static int _rightClickMenuBackEvalFrame;

	private static bool _rightClickIsMenuBack;

	private void Update()
	{
	}

	public void DeActiveComponent()
	{
	}

	public void ClearSelectedButtons()
	{
	}

	public void SelectInitialButton(bool autoSelect, float delay = 0.3f)
	{
	}

	public void SelectInitialButton(float delay)
	{
	}

	public void SelectInitialActiveButton(float delay)
	{
	}

	public void SelectAndSetLastButton()
	{
	}

	private void ClickOnTheButtonSelected()
	{
	}

	private void ProcessInput(InputDirection inputDirection)
	{
	}

	private void EnsureSelectionForDirectionalInput()
	{
	}

	private bool TrySelectFirstActiveButton()
	{
		return false;
	}

	private bool TrySelectButtonAtIndex(int index)
	{
		return false;
	}

	private static bool IsKeyboardRebindBlockingMenuInput()
	{
		return false;
	}

	public static bool WasMenuAcceptPressed(Player player)
	{
		return false;
	}

	public static bool WasMenuBackPressed(Player player)
	{
		return false;
	}

	public static bool WasRightClickMenuBackThisFrame()
	{
		return false;
	}

	private static bool IsRightClickMenuBackContext()
	{
		return false;
	}
}
