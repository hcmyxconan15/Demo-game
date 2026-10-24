using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnknownEventsDb", menuName = "GameData/Unknown event db")]
public class UnknownEventsDb : ScriptableObject
{
	public List<UnknownEvent> UnknownEvents;
}
