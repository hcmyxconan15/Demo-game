using System;
using System.Collections.Generic;

[Serializable]
public class ContentAvailabilitySnapshot
{
	public bool IsCaptured;

	public List<int> Weapons;

	public List<int> Microchips;

	public List<int> Overloads;

	public List<int> Mechs;

	public List<int> Drones;

	public List<int> Bodies;

	public List<int> Bases;

	public List<int> Pilots;

	public List<int> Planets;

	public List<HuntAvailabilityKey> Hunts;
}
