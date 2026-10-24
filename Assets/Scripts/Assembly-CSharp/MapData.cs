using System;
using System.Collections.Generic;

[Serializable]
public class MapData
{
	public List<int> CurrentSelectedPath;

	public List<NodeInfo> MapNodeInfo;

	public int GenerationSeed;

	public List<int> FavoriteMapSeeds;

	public NodeInfo GetNodeInfo(int nodeIndex, int nodeLevel)
	{
		return null;
	}
}
