using UnityEngine;

public class InputResponseHandler : MonoBehaviour
{
	public Texture2D CursorIcon;

	[SerializeField]
	private InputEventChannelSO InputEventChannel;

	private bool _hadJoystickConnected;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleInputDeviceChanged(bool isUsingJoystick)
	{
	}
}
