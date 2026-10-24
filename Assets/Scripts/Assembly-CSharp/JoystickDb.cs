using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Joystick Db", menuName = "GameData/Base/new JoystickDb")]
public class JoystickDb : ScriptableObject
{
	public List<JoystickInput> JoystickInputs;

	[ContextMenu("AddButtonSprite")]
	public void AddButtonSpriteInputs()
	{
	}
}
