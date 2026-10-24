using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "New Drone DB", menuName = "GameData/Drone/new Drone db")]
public class DroneDb : ScriptableObject
{
	[FormerlySerializedAs("DroneStatsList")]
	public List<DroneStats> Drones;

	private void OnValidate()
	{
	}

	public void SetUnlockPrice()
	{
	}
}
