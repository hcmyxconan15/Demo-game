using System;

[Serializable]
public class EnemyData
{
	public enum EnemyType
	{
		Normal = 0,
		Elite = 1,
		Mercenary = 2,
		Boss = 3
	}

	public string EnemyName;

	public int EnemyId;

	public bool NotAvailable;

	public EnemyType Type;

	public EnemyBase EnemyPrefab;
}
