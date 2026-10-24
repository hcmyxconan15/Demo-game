using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PilotHiveGraphConfig", menuName = "GameData/Pilot Hive Graph Config")]
public class PilotHiveGraphConfig : ScriptableObject
{
	public PilotDb PilotDb;

	public OverloadDb OverloadDb;

	public ChipDb ChipDb;

	[NonSerialized]
	public PilotSkillsUi PilotSkillsUi;

	[Tooltip("Hex radius in graph pixels (center to vertex). Controls snap and auto-layout spacing.")]
	public float HexSize;

	public List<PilotHiveNodeData> Nodes;

	public List<PilotHiveEdgeData> Edges;

	public Pilot GetPilot(int pilotId)
	{
		return null;
	}
}
