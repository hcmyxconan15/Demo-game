using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Input Event Channel")]
public class InputEventChannelSO : ScriptableObject
{
	public UnityAction<bool> OnInputDeviceChanged;

	public void RaiseEvent(bool isUsingJoystick)
	{
	}
}
