using System;
using UnityEngine;

[Serializable]
public class PartStats
{
	public ushort Life;

	public ushort Shield;

	public ushort Damage;

	[Range(0f, 80f)]
	public int ReloadTimePercent;

	[Range(0f, 3f)]
	public ushort MagazineIncreaseRaw;

	[Range(0f, 250f)]
	public int CriticalDamagePercent;

	[Range(0f, 100f)]
	public int CriticalChancePercent;

	[Range(0f, 100f)]
	public int DamageIncreasePercent;

	[Range(0f, 100f)]
	public int FireRateIncreasePercent;

	public int MicrochipSlots;

	public int OverloadSlots;

	public int DroneCapacity;
}
