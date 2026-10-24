using System;
using System.Collections.Generic;

[Serializable]
public class JoystickInput
{
	public enum JoystickType
	{
		Keyboard = 0,
		GamePad = 1,
		Playstation = 2,
		Xbox = 3,
		Nintendo = 4,
		SteamDeck = 5,
		OnlyMouse = 6
	}

	public JoystickType Joystick;

	public List<ButtonSprite> ButtonSprite;
}
