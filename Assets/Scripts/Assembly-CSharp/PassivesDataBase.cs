using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New passives DB", menuName = "GameData/passives db")]
public class PassivesDataBase : ScriptableObject
{
	public List<Passives> PassivesList;
}
