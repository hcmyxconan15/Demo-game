using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickInputButtonSimple : MonoBehaviour
{
	public List<MainMenuJoystickBase.PanelActive> UseOnPanelActive;

	public string ButtonName;

	public Button ButtonComponent;

	public MainMenuJoystickBase MainMenuJoystick;

	public bool UseSpriteGuide;

	public string SpriteId;

	public Image ButtonSprite;

	private bool _buttonRight;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ClickOnThisButton()
	{
	}

	private void UpdateButtonSprite()
	{
	}
}
