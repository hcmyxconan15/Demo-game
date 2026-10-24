using System;
using UnityEngine;

[Serializable]
public class SkillTreeGraphNodeData
{
	public string NodeId;

	public int ButtonIndex;

	public int PowerUpId;

	public Vector2 Position;

	public bool IsLocked;

	public string LockedLabel;
}
