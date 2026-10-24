using System;
using System.Collections.Generic;

[Serializable]
public class UnknownEvent
{
	public enum EventSelectionType
	{
		None = 0,
		AcceptDecline = 1
	}

	public enum EventRewardType
	{
		None = 0,
		EliteEnemyAppear = 1,
		SpecialEnemyAppear = 2,
		TreasureBox = 3,
		Overload = 4,
		MercenaryAppear = 5,
		AllowToRemoveWeapon = 6,
		DamageThePlayer = 7,
		HealThePlayer = 8,
		FreeUpgrade = 9,
		RemoveMoney = 10,
		AddMoney = 11,
		GaiaEffect = 12,
		AreaHeal = 13,
		MotherShipLasers = 14
	}

	public string EventName;

	public int Id;

	public bool IgnoreEvent;

	public int MinNodeLevelToTrigger;

	public int EventDangerLevel;

	public string EventDescription;

	public EventSelectionType SelectionType;

	public string Selection0Key;

	public string Selection1Key;

	public List<EventConclusion> PossibleEventConclusions0;

	public List<EventConclusion> PossibleEventConclusions1;
}
