using System;
using System.Collections.Generic;

[Serializable]
public class PilotData
{
	public int Id;

	public int PilotLevel;

	public int Progress;

	public List<SkillsUnlockedPilot> SkillsUnlocked;
}
