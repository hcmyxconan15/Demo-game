using System;

[Serializable]
public class SkillsUnlockedPilot
{
	public enum PilotSkillSlotType
	{
		Stat = 0,
		Overload = 1,
		Microchip = 2
	}

	public int Id;

	public PilotSkillSlotType Type;
}
