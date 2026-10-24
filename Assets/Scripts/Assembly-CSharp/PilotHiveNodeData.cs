using System;
using UnityEngine;

[Serializable]
public class PilotHiveNodeData
{
	public string NodeId;

	public int SlotIndex;

	public PilotHiveNodeKind Kind;

	public int HexQ;

	public int HexR;

	public Vector2 Position;

	public bool IsStart;
}
