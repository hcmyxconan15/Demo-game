using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Pilot DB", menuName = "GameData/new pilot db")]
public class PilotDb : ScriptableObject
{
	public int MaxPilotLevel;

	[Tooltip("XP for level N: Round(BaseXp * N^GrowthFactor).")]
	public float BaseXp;

	[Tooltip("XP for level N: Round(BaseXp * N^GrowthFactor).")]
	public float GrowthFactor;

	public List<Pilot> Pilots;

	public List<PilotStatTypeIcon> StatIcons;

	public OverloadDb OverloadDb;

	public ChipDb ChipDb;

	private void OnValidate()
	{
	}

	private void BindPilotEditorSources()
	{
	}

	public int GetXpForPilotLevel(int level)
	{
		return 0;
	}

	public int GetTotalXpForPilotLevel(int level)
	{
		return 0;
	}

	public Sprite GetDefaultStatIcon(StatToIncrease.StatIncreaseType statsType)
	{
		return null;
	}

	private void EnsureStatIconTable()
	{
	}
}
