using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New node DB", menuName = "GameData/Map/NodeDb")]
public class NodeBd : ScriptableObject
{
	public List<Node> NodeTypes;
}
