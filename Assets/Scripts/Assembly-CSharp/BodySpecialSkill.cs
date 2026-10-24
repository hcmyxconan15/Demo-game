using System;

[Serializable]
public class BodySpecialSkill
{
	public BodySpecialSkillKind Kind;

	public Weapon.SlotType Slot;

	public BulletType.TypeOfBullet Delivery;

	public BulletType.BulletClassType FromDamageType;

	public BulletType.BulletClassType ToDamageType;

	private bool IsSwapBullet => false;
}
