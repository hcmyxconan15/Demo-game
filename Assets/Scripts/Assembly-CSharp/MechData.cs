using System;
using System.Collections.Generic;

[Serializable]
public class MechData
{
	public int Id;

	public int ChassisId;

	public int BaseType;

	public int BaseId;

	public int BodyId;

	public int WeaponId;

	public int DroneId;

	public List<int> Weapons;

	public List<int> Bodies;

	public List<int> Bases;
}
