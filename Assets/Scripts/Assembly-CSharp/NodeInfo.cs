using System;
using System.Collections.Generic;

[Serializable]
public class NodeInfo
{
	public int NodeLevel;

	public int NodeIndex;

	public float XPosition;

	public float YPosition;

	public List<int> ConnectedUpNodesIndexes;

	public List<int> ConnectedDownNodesIndexes;

	public Node.NodeType NodeType;
}
