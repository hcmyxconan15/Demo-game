using System.Collections.Generic;
using UnityEngine;

public class BlockButtonOnTutorial : MonoBehaviour
{
	public Sprite NormalButtonSprite;

	public Sprite LockButtonSprite;

	public List<BlockButton> BlockButtons;

	[Header("Hangar")]
	public BlockButton HangarButton;

	public MainMenuJoystick MainMenuJoystick;

	public void LockButtons()
	{
	}

	public bool SetHangarButtonStatus()
	{
		return false;
	}

	private void LockHangarButton(bool lockButton)
	{
	}
}
