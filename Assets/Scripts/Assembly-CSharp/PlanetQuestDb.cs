using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Planet Quest DB", menuName = "GameData/new planet quest db")]
public class PlanetQuestDb : ScriptableObject
{
	public List<PlanetQuestSet> Planets;

	private Dictionary<int, PlanetQuestSet> _setByPlanetId;

	private Dictionary<int, PlanetQuest> _questByQuestId;

	public PlanetQuestSet GetPlanetSet(int planetId)
	{
		return null;
	}

	public PlanetQuest GetQuest(int questId)
	{
		return null;
	}

	public List<PlanetQuest> GetAvailableQuests(int planetId)
	{
		return null;
	}

	public int GetQuestIndex(int planetId, int questId)
	{
		return 0;
	}

	private void EnsureLookups()
	{
	}

	public string GetPlanetNameKey(int planetId)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	private void SetPlanetSetNames()
	{
	}
}
