using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Overload
{
	public enum OverloadActionType
	{
		BulletId = 0,
		DirectFunction = 1
	}

	public enum OverloadLaunchMode
	{
		Burst = 0,
		DeploySlots = 1
	}

	public enum OverloadDirectAction
	{
		None = 0,
		ReloadAllWeapons = 1,
		ReloadAllEnergyWeapons = 2,
		ReloadAllPhysicalWeapons = 3,
		ReloadAllMissileWeapons = 4,
		MissileGuaranteedCritical = 5,
		AddShield = 6,
		IncreaseDamagePercent = 7,
		StopShieldDecayWhileStationary = 8,
		ConvertShieldAbsorptionToLife = 9,
		IncreaseRecoverHealthWhileStationary = 10,
		IncreaseTagDamageWhileStationary = 11,
		IncreaseTagFireRateWhileStationary = 12,
		StationaryBonusLinger = 13,
		ScrapToFirepowerConverter = 14,
		DroneRepairProtocol = 15
	}

	public enum ActivationBy
	{
		PhysicLaunch = 0,
		EnergyLaunch = 1,
		PhysicHit = 2,
		EnergyHit = 3,
		ReloadPhysic = 4,
		ReloadEnergy = 5,
		ReloadDash = 6,
		EndDash = 7,
		StartDash = 8,
		KillOnFire = 9,
		KillOnShock = 10,
		KillOnWeak = 11,
		OnKill = 12,
		PhysicLaunchProjectile = 13,
		PhysicLaunchMissile = 14,
		EnergyLaunchProjectile = 15,
		EndReload = 16,
		StartReload = 17,
		StartReloadPhysic = 18,
		StartReloadEnergy = 19,
		WhileMoving = 20,
		WhileStationary = 21,
		OnShieldAbsorb = 22,
		SiegeHit = 23,
		OnCoinPickup = 24,
		OnXpPickup = 25,
		KillOnMark = 26
	}

	public enum OverloadLaunchPosition
	{
		None = 0,
		TurretTrigger = 1,
		AllPhysicalTurret = 2,
		AllEnergyTurret = 3,
		AllMissileTurret = 4,
		AllProjectileTurret = 5,
		AllBeamTurret = 6,
		AllAreaTurret = 7,
		AllPhysicalProjectileTurret = 8,
		AllPhysicalMissileTurret = 9,
		AllPhysicalBeamTurret = 10,
		AllPhysicalAreaTurret = 11,
		AllEnergyProjectileTurret = 12,
		AllEnergyMissileTurret = 13,
		AllEnergyBeamTurret = 14,
		AllEnergyAreaTurret = 15,
		PlayerPosition = 16,
		AllSiegeTurret = 17
	}

	public string OverloadDescriptionName;

	public string Name;

	[Tooltip("If true, this overload is excluded from the game entirely (level-up, shop, hub unlocks, unlock lists). Treat as if it does not exist.")]
	public bool NotInclude;

	public bool NotAvailable;

	public bool NotFoundByLevelUp;

	public Sprite Icon;

	public int Id;

	public int MaxLevel;

	public OverloadActionType ActionType;

	public int BulletId;

	public OverloadDirectAction DirectAction;

	public int BasePrice;

	public int UnlockPrice;

	[Tooltip("Per activation: bullet/overload damage, shield % (AddShield), HP healed (IncreaseRecoverHealthWhileStationary), or damage % per stack (ScrapToFirepowerConverter / IncreaseDamagePercent).")]
	public int Damage;

	[Tooltip("Added to Damage per level above 1.")]
	public int GrowDamage;

	public float OnWeak;

	public float OnFire;

	public float OnShock;

	[Tooltip("Mark duration in seconds. While marked, hits gain OnMarkCriticalChanceBonus crit chance.")]
	public float OnMark;

	[Tooltip("Extra critical chance percent applied to damage against a Marked enemy.")]
	public int OnMarkCriticalChanceBonus;

	public ActivationBy ActivationTrigger;

	[Tooltip("Every N triggers for count-based overloads, or coins per damage stack for ScrapToFirepowerConverter.")]
	public float ActivationTriggerCount;

	public float GrowActivationTriggerCount;

	[Range(0f, 100f)]
	public float ActivationPercent;

	public float ActivationPercentGrow;

	public float ActiveTime;

	public float ActiveTimeIncrease;

	[Tooltip("Show a floating icon over the player when this overload activates. Passive/permanent overloads never show it.")]
	public bool ShowActivationPopup;

	[Tooltip("Minimum seconds between activations. Use for bullet procs, AddShield ticks, and interval heals (IncreaseRecoverHealthWhileStationary). 0 = no interval limit.")]
	public float ActivationInterval;

	[Tooltip("Reduces ActivationInterval per level above 1 (faster barrages, shield ticks, interval heals).")]
	public float ActivationIntervalGrow;

	public OverloadLaunchPosition LaunchPosition;

	[Tooltip("Burst: fire LaunchTimes bullets per activation. DeploySlots: one deploy per activation until the LaunchTimes cap (mines, traps, etc.).")]
	public OverloadLaunchMode LaunchMode;

	[Tooltip("Burst: bullets per activation. DeploySlots: max simultaneous deploys. ScrapToFirepowerConverter: soft-cap stack count.")]
	public int LaunchTimes;

	[Tooltip("Seconds between each launch in a chain. 0 = all at once.")]
	public float TimeBetweenLaunch;

	public int GrowLaunchTimes;

	[Tooltip("Reduces interval per level above 1.")]
	public float TimeBetweenLaunchGrow;

	[Tooltip("Seconds between each matching turret per chain tick. 0 = all turrets at once.")]
	public float TimeBetweenTurretLaunch;

	[Tooltip("Reduces turret stagger per level above 1.")]
	public float TimeBetweenTurretLaunchGrow;

	public List<GameTag> ResolvedTags;

	public List<GameTag> ExtraTags;

	public TagRequirements TagGate;

	[Tooltip("Weapons carrying ANY of these tags receive this overload's per-weapon bonus (damage, fire rate, etc. while stationary). Separate from TagGate, which only gates when the overload is offered.")]
	public List<GameTag> BonusWeaponTags;

	public List<BuildArchetype> Archetypes;

	public List<int> RequiredWeaponsId;

	[Tooltip("OR list — the player needs any one of these drone ids installed.")]
	public List<int> RequiredDronesId;

	public List<int> RequiredOverloadId;

	public List<int> RequiredChipsId;

	public List<int> IncompatibleChipsId;

	private const float MinIntervalSeconds = 0.1f;

	private bool UsesBulletAction => false;

	private bool UsesDirectAction => false;

	private bool ShowsLaunchTimes => false;

	private bool UsesMultiTurretLaunchPosition => false;

	public void SetDescriptionName(string unlockCondition)
	{
	}

	public void RefreshResolvedTags(BulletsDb bulletsDb)
	{
	}

	public void IsolateTagGate()
	{
	}

	public bool IsPassiveDirectOverload()
	{
		return false;
	}

	public bool UsesDeploySlotLaunch()
	{
		return false;
	}

	public static bool TryGetTurretFilters(OverloadLaunchPosition launchPosition, out BulletType.BulletClassType? bulletClassType, out BulletType.TypeOfBullet? typeOfBullet)
	{
		bulletClassType = null;
		typeOfBullet = null;
		return false;
	}

	public int GetGrowDamage(int level)
	{
		return 0;
	}

	public int GetGrowShieldPercent(int level)
	{
		return 0;
	}

	public int GetGrowActivationPercent(int level)
	{
		return 0;
	}

	public int GetGrowActiveTime(int level)
	{
		return 0;
	}

	public float GetGrowActivationInterval(int level)
	{
		return 0f;
	}

	public int GetGrowCount(int level)
	{
		return 0;
	}

	public int GetGrowLaunchTimes(int level)
	{
		return 0;
	}

	public float GetGrowTimeBetweenLaunch(int level)
	{
		return 0f;
	}

	public float GetGrowTimeBetweenTurretLaunch(int level)
	{
		return 0f;
	}
}
