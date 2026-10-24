using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Pilot
{
	public string PilotDescriptionName;

	public string Name;

	[Multiline(2)]
	public string Description;

	[FormerlySerializedAs("CantBeUsed")]
	public bool NotAvailable;

	public Sprite AvatarSprite;

	public int Id;

	public int MaxLevel;

	public PilotComponent BodyPrefab;

	public PilotSkills Skills;

	public void BindEditorSources(OverloadDb overloadDb, ChipDb chipDb)
	{
	}

	public int GetDisplayLevel(PilotData data)
	{
		return 0;
	}

	public bool IsAtMaxLevel(PilotData data)
	{
		return false;
	}
}
