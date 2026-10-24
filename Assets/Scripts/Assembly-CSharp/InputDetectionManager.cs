using Rewired;
using UnityEngine;

public class InputDetectionManager : MonoBehaviour
{
	[SerializeField]
	private InputEventChannelSO InputEventChannel;

	private Player _player;

	public bool IsUsingJoystick;

	public static InputDetectionManager Instance;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args)
	{
	}

	private void SwitchToKeyboardMouseMode(string reason = null)
	{
	}

	private bool HasJoysticksConnected()
	{
		return false;
	}

	private void SetMouseInputEnabled(bool enabled)
	{
	}

	private bool IsJoystickInputThisFrame()
	{
		return false;
	}

	private bool IsKeyboardMouseInputThisFrame()
	{
		return false;
	}
}
