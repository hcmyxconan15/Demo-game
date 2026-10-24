using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest DB", menuName = "QuestSystem/New quest db")]
public class QuestDb : ScriptableObject
{
	public List<Quest> Quest;
}
