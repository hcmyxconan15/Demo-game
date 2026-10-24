using System;

[Serializable]
public class BulletType
{
	public enum BulletClassType
	{
		Physical = 0,
		Energy = 1
	}

	public enum TypeOfBullet
	{
		Projectile = 0,
		Missile = 1,
		Beam = 2,
		Area = 3
	}

	public string BulletDescriptionName;

	public string Name;

	public ushort BulletId;

	public int BulletSoundId;

	public BulletClassType Type;

	public TypeOfBullet TypeBullet;

	public DamageBase BulletPrefab;
}
