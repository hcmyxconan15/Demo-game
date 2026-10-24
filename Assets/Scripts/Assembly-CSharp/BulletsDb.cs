using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New bullet DB", menuName = "GameData/Bullet/new bullets db")]
public class BulletsDb : ScriptableObject
{
	public List<BulletType> Bullets;

	private Dictionary<int, BulletType> _byId;

	public BulletType GetBullet(int bulletId)
	{
		return null;
	}

	private void EnsureLookup()
	{
	}

	private void OnValidate()
	{
	}
}
