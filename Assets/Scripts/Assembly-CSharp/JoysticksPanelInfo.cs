using TMPro;
using UnityEngine;

public class JoysticksPanelInfo : MonoBehaviour
{
	public CanvasGroup CanvasGroup;

	public GameObject JoystickInPanel;

	public TextMeshProUGUI InfoText;

	public MainMenuJoystickBase MainMenuJoystick;

	public static JoysticksPanelInfo Instance;

	private void Awake()
	{
	}

	public void ClosePanel()
	{
	}

	public void OpenPanel()
	{
	}

	public void JoystickConnected(bool joystickIsOn, bool hadJoystickBeforeSwitch)
	{
	}

	public void JoystickDisconnected()
	{
	}

	public void AcceptJoystickReconnection()
	{
	}

	public void AcceptJoystickDisconnection()
	{
	}
}
