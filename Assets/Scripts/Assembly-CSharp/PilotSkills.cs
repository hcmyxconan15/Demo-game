using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PilotSkills
{
	[NonSerialized]
	[HideInInspector]
	private OverloadDb _overloadDb;

	[NonSerialized]
	[HideInInspector]
	private ChipDb _chipDb;

	public int PilotOverloadId;

	public int PilotOverloadId2;

	public int PilotMicrochipId;

	public int PilotMicrochipId2;

	public List<StatToIncreaseOnPilot> StatsOnPilot;

	private Sprite PilotOverloadIcon => null;

	private Sprite PilotOverloadIcon2 => null;

	private Sprite PilotMicrochipIcon => null;

	private Sprite PilotMicrochipIcon2 => null;

	public void BindEditorSources(OverloadDb overloadDb, ChipDb chipDb)
	{
	}

	private Sprite GetOverloadIcon(int overloadId)
	{
		return null;
	}

	private Sprite GetMicrochipIcon(int microchipId)
	{
		return null;
	}
}
