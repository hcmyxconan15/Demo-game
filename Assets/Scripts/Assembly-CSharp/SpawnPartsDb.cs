using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Spawn Parts DB", menuName = "GameData/Enemies/new spawn parts db")]
public class SpawnPartsDb : ScriptableObject
{
	public List<SpawnParts> Parts;

	private Dictionary<int, SpawnParts> _byId;

	public SpawnParts GetPart(int monsterPartId)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void EnsureLookup()
	{
	}
}
