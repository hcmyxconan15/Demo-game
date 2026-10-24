using System;
using UnityEngine;

[Serializable]
public class WeaponPosition
{
	public bool InUse;

	public WeaponJoin WeaponJoinOnSlot;

	public Weapon.SlotType SlotType;

	public Transform WeaponTransformPosition;
}
