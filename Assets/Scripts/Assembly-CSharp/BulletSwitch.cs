using System.Collections.Generic;
using UnityEngine;

public static class BulletSwitch
{
	public const string SwapBulletKey = "BodySkillSwapBullet";

	public static List<BulletSwitchRule> CollectRules(BodyType body)
	{
		return null;
	}

	public static List<BulletSwitchRule> CollectActiveRules(RobotParts robotParts)
	{
		return null;
	}

	public static int ResolveForEquippedBody(Weapon weapon, RobotParts robotParts, BulletsDb bulletsDb)
	{
		return 0;
	}

	public static int ResolveBulletId(Weapon weapon, IReadOnlyList<BulletSwitchRule> rules, BulletsDb bulletsDb)
	{
		return 0;
	}

	public static string FormatSkillText(BodyType body, Color colorPlus, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	public static string CombineWithGrowth(string growthText, BodyType body, Color colorPlus, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	private static string FormatSwapBullet(BodySpecialSkill skill, Color colorPlus, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	private static string DamageColorHex(BulletType.BulletClassType type, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	private static string ColorLabel(string label, string colorHex, bool bold)
	{
		return null;
	}
}
