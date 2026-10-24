using System;

[Serializable]
public class StatToIncrease
{
	public enum StatIncreaseType
	{
		None = 0,
		LifePercent = 1,
		LifeMax = 2,
		ShieldPercent = 3,
		ShieldMax = 4,
		DecreaseReloadTimePercent = 5,
		IncreaseMagazinePercent = 6,
		ExtraBulletToWeapon = 7,
		IncreaseDamagePercent = 8,
		IncreaseMagnetArea = 9,
		IncreaseXpCollection = 10,
		IncreaseGoldCollection = 11,
		IncreaseCriticalChance = 12,
		IncreaseCriticalDamage = 13,
		IncreaseRecoverHealthByTime = 14,
		PiercingChipset = 15,
		IncreaseMissileLaunchers = 16,
		Ricochet = 17,
		IncreaseEnergyDamagePercent = 18,
		IncreasePhysicalDamagePercent = 19,
		IncreaseMissileDamagePercent = 20,
		IncreaseBeamDamage = 21,
		FreeBanishOnLevelUp = 22,
		FreeRerollOnLevelUp = 23,
		DashIncrease = 24,
		FireRatePercent = 25,
		Speed = 26,
		MagnetSize = 27,
		IncreaseProjectileMagazinePhysical = 28,
		IncreaseProjectileMagazineEnergy = 29,
		IncreaseMissileMagazinePhysical = 30,
		IncreaseMissileMagazineEnergy = 31,
		IncreaseBeamMagazinePhysical = 32,
		IncreaseBeamMagazineEnergy = 33,
		IncreaseAreaMagazinePhysical = 34,
		IncreaseAreaMagazineEnergy = 35,
		DecreaseDashReloadTimePercent = 36,
		DecreaseShieldDecayPercent = 37,
		IncreaseDroneCapacity = 38,
		IncreaseCollectorXpDepositPercent = 39,
		IncreaseSpeedPercent = 40
	}

	public StatIncreaseType StatsType;

	public float BaseValue;

	public float IncreaseValue;
}
