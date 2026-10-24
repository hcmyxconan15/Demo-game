using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkillTreeGraphConfig", menuName = "GameData/Skill Tree Graph Config")]
public class SkillTreeGraphConfig : ScriptableObject
{
	public PowerUpsDb PowerUpsDb;

	[NonSerialized]
	public SkillTreeManager SkillTreeManager;

	public float NodeSpacing;

	public float HorizontalSpacing;

	public float VerticalSpacing;

	public List<SkillTreeGraphNodeData> Nodes;

	public List<SkillTreeGraphEdgeData> Edges;
}
