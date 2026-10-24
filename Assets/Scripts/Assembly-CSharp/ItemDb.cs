using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item DB", menuName = "QuestSystem/New item db")]
public class ItemDb : ScriptableObject
{
	public List<Item> Items;
}
