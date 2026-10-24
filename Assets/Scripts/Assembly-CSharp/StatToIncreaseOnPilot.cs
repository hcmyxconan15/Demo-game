using System;
using UnityEngine;

[Serializable]
public class StatToIncreaseOnPilot
{
	public string StatName;

	[HideInInspector]
	public int Id;

	public Sprite StatToIncreaseIcon;

	public bool UseCustomIcon;

	public StatToIncrease StatToIncrease;

	public void ApplyDefaultIcon(PilotDb pilotDb)
	{
	}
}
