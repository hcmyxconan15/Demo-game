using System;
using System.Collections.Generic;

[Serializable]
public class PlanetQuestSet
{
	public string SetupName;

	public int PlanetId;

	public string Name;

	public int UnlockSourcePlanetId;

	public int UnlockQuestsRequired;

	public bool NotAvailable;

	public List<PlanetQuest> Quests;
}
