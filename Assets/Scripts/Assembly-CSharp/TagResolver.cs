using System.Collections.Generic;

public static class TagResolver
{
	public static List<GameTag> GetWeaponTags(Weapon weapon, BulletsDb bulletsDb, WeaponsDb weaponsDb, int bulletId = -1)
	{
		return null;
	}

	public static void CollectWeaponTags(Weapon weapon, BulletsDb bulletsDb, WeaponsDb weaponsDb, List<GameTag> tags, int bulletId = -1)
	{
	}

	public static bool WeaponHasTag(Weapon weapon, GameTag tag, BulletsDb bulletsDb, WeaponsDb weaponsDb)
	{
		return false;
	}

	public static List<GameTag> GetMicrochipTags(Microchip microchip)
	{
		return null;
	}

	public static void CollectMicrochipTags(Microchip microchip, List<GameTag> tags)
	{
	}

	public static List<GameTag> GetOverloadTags(Overload overload)
	{
		return null;
	}

	public static void CollectOverloadTags(Overload overload, List<GameTag> tags)
	{
	}

	public static void CollectOverloadTags(Overload overload, BulletsDb bulletsDb, List<GameTag> tags)
	{
	}

	public static void CollectBodyTypeTags(BodyType bodyType, List<GameTag> tags)
	{
	}

	public static void CollectBaseTypeTags(BaseType baseType, List<GameTag> tags)
	{
	}

	public static void CollectWeaponJoinTags(WeaponJoin weaponJoin, BulletsDb bulletsDb, WeaponsDb weaponsDb, List<GameTag> tags)
	{
	}

	public static void CollectBulletTags(BulletType bullet, List<GameTag> tags)
	{
	}

	private static void CollectDirectActionTags(Overload.OverloadDirectAction directAction, List<GameTag> tags)
	{
	}

	private static void CollectActivationTags(Overload.ActivationBy activation, List<GameTag> tags)
	{
	}

	private static bool IsPhysicalActivation(Overload.ActivationBy activation)
	{
		return false;
	}

	private static bool IsEnergyActivation(Overload.ActivationBy activation)
	{
		return false;
	}

	private static bool IsProjectileActivation(Overload.ActivationBy activation)
	{
		return false;
	}

	private static void CollectStatIncreaseTags(StatToIncrease.StatIncreaseType statType, List<GameTag> tags)
	{
	}

	private static void AddExtraTags(List<GameTag> extraTags, List<GameTag> tags)
	{
	}
}
