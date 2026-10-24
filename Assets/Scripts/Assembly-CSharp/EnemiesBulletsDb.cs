using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemies Bullet DB", menuName = "GameData/Enemies/new enemies bullet db")]
public class EnemiesBulletsDb : ScriptableObject
{
	public List<EnemyBulletData> EnemyBullets;

	private Dictionary<int, EnemyBulletData> _byId;

	public EnemyBulletData GetBullet(int bulletId)
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
