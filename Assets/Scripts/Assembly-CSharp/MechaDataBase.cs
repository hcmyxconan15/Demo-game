using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Mecha DataBase", menuName = "GameData/new MechaDataBase")]
public class MechaDataBase : ScriptableObject
{
	public List<Mech> MechList;

	public WeaponsDb WeaponsDb;

	public RobotBodyDb RobotBodyDb;

	public RobotBaseDb RobotBaseDb;

	public DroneDb DroneDb;

	public TagOfferWeightConfig TagOfferWeightConfig;

	private void OnValidate()
	{
	}

	private void BindMechEditorSources()
	{
	}
}
