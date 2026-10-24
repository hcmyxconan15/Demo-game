using System;
using UnityEngine;

[Serializable]
public class Node
{
	public enum NodeType
	{
		Enemy = 0,
		EliteEnemy = 1,
		Mercenary = 2,
		Treasure = 3,
		Shop = 4,
		Rest = 5,
		Unknown = 6,
		Boss = 7,
		InitialNode = 8,
		OptionalHuntNode = 9,
		SpecialEventNode = 10
	}

	public string Name;

	public Sprite NodeIcon;

	public Sprite NodeBackground;

	public NodeType Type;
}
