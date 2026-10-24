using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New alert DB", menuName = "GameData/Base/new alert db")]
public class AlertDb : ScriptableObject
{
	public List<Alert> BasicAlerts;
}
