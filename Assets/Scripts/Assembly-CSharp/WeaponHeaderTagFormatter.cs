using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class WeaponHeaderTagFormatter
{
	public const string DeliveryColorHex = "9E9E9E";

	public const string TagColorSiege = "E65100";

	public const string TagColorDrone = "4FC3F7";

	public const string EvolutionNameColorHex = "DC143C";

	public const string TagColorEvolution = "BF254C";

	public const string EvolutionTagKey = "Evolution";

	private static readonly GameTag[] HeaderIdentityTags;

	public static string FormatWeaponDisplayName(Weapon weapon, string localizedName)
	{
		return null;
	}

	public static string FormatBrackets(BulletType bullet, Weapon weapon, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	private static bool IsEvolutionWeapon(Weapon weapon)
	{
		return false;
	}

	public static string FormatBrackets(Overload overload, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	public static string FormatBrackets(BulletType bullet, List<GameTag> extraTags, Color colorPhysical, Color colorEnergy)
	{
		return null;
	}

	private static string GetIdentityColorHex(GameTag tag)
	{
		return null;
	}

	private static void AppendBracket(StringBuilder builder, string label, string colorHex)
	{
	}
}
