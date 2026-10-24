using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New power ups DB", menuName = "GameData/power ups db")]
public class PowerUpsDb : ScriptableObject
{
	public List<PowerUpData> PowerUps;

	private void OnValidate()
	{
	}

	public bool HasActivePowerUpType(PowerUpType type)
	{
		return false;
	}
}
