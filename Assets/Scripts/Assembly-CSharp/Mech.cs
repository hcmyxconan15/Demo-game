using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Mech
{
	public string MechDescriptionName;

	public string MechName;

	public int Id;

	public bool NotAvailable;

	public int BaseChassis;

	public int BaseType;

	public int BodyId;

	public int BaseId;

	public int WeaponId;

	public int DroneId;

	public List<Chassis> Chassis;

	public List<MechPartOption> Weapons;

	public List<MechPartOption> BodyParts;

	public List<MechPartOption> BaseParts;

	[NonSerialized]
	private WeaponsDb _weaponsDb;

	[NonSerialized]
	private RobotBodyDb _robotBodyDb;

	[NonSerialized]
	private RobotBaseDb _robotBaseDb;

	[NonSerialized]
	private DroneDb _droneDb;

	private Sprite DefaultBodyIcon => null;

	private Sprite DefaultBaseIcon => null;

	private Sprite DefaultWeaponIcon => null;

	private Sprite DefaultDroneIcon => null;

	public void BindEditorSources(WeaponsDb weaponsDb, RobotBodyDb robotBodyDb, RobotBaseDb robotBaseDb, DroneDb droneDb)
	{
	}

	public string BuildDescriptionName()
	{
		return null;
	}

	private string BuildArchetypeListSuffix()
	{
		return null;
	}

	public List<int> GetWeaponIds()
	{
		return null;
	}

	public List<int> GetBodyPartIds()
	{
		return null;
	}

	public List<int> GetBasePartIds()
	{
		return null;
	}

	private Sprite GetWeaponIcon(int weaponId)
	{
		return null;
	}

	private Sprite GetDroneIcon(int droneId)
	{
		return null;
	}

	private DroneStats GetDrone(int droneId)
	{
		return null;
	}

	private Sprite GetBodyIcon(int bodyId)
	{
		return null;
	}

	private Sprite GetBaseIcon(int baseId)
	{
		return null;
	}

	private void BindStartOptions(List<MechPartOption> options)
	{
	}

	private static void BindPartOptions(List<MechPartOption> options, Func<int, Sprite> resolveIcon)
	{
	}

	private Sprite ResolveStartOptionIcon(MechPartOption option)
	{
		return null;
	}

	private static List<int> GetPartIds(List<MechPartOption> options)
	{
		return null;
	}
}
