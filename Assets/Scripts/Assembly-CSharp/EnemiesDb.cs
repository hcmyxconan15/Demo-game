using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemies DB", menuName = "GameData/Enemies/new enemies db")]
public class EnemiesDb : ScriptableObject
{
	public List<EnemyData> Enemies;

	private Dictionary<int, EnemyData> _byId;

	public EnemyData GetEnemy(int enemyId)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void EnsureLookup()
	{
	}
}
