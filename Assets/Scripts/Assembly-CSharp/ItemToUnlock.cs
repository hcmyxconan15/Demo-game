using System;
using UnityEngine;

[Serializable]
public class ItemToUnlock
{
	public enum UnlockType
	{
		Mech = 0,
		Weapon = 1,
		MicroChip = 2,
		Overload = 3,
		Drone = 4,
		Pilot = 5,
		Base = 6,
		Body = 7
	}

	[NonSerialized]
	[HideInInspector]
	private UnlockDb _unlockDb;

	public string EditorName;

	[HideInInspector]
	public int Id;

	public int ItemId;

	[HideInInspector]
	public UnlockType Type;

	public UnlockCondition Condition;

	private Sprite ItemIcon => null;

	private string StarterFollowLabel => null;

	private bool ShowStarterFollowLabel()
	{
		return false;
	}

	private bool CanEditUnlockCondition()
	{
		return false;
	}

	private string GetStarterFollowLabel()
	{
		return null;
	}

	public void BindEditorSources(UnlockDb unlockDb)
	{
	}
}
