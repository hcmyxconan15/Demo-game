using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Weapon
{
	public enum SlotType
	{
		A = 0,
		B = 1,
		C = 2,
		D = 3
	}

	public string WeaponDescriptionName;

	public string WeaponName;

	[Tooltip("If true, this weapon is excluded from the game entirely (level-up, shop, hub unlocks, unlock lists). Treat as if it does not exist.")]
	public bool NotInclude;

	public bool NotAvailable;

	public bool NotFoundByLevelUp;

	public Sprite Icon;

	public GameObject WeaponPrefab;

	public ushort WeaponId;

	public ushort MaxWeaponLevel;

	public SlotType WeaponSlotType;

	public int BulletId;

	[Tooltip("-1 = none. Fired when a bullet switch matches this weapon. Chain on hit and chain on launch stay on this weapon.")]
	public int AlternateBulletId;

	public ushort BasePrice;

	public int UnlockPrice;

	public ushort WeaponDamage;

	public float WeaponDamageGrowUp;

	public ushort WeaponShieldDamage;

	public bool PermanentWeapon;

	public bool DontTriggerCriticalHits;

	public bool IgnoreMagazineGrowWeapon;

	public float AttackRate;

	public float AttackRateGrowUp;

	public float ReloadTime;

	public float ReloadTimeGrowUp;

	public int BaseMagazine;

	public float BaseMagazineGrowUp;

	public int PassEnemyCount;

	public int RicochetCount;

	[Tooltip("-1 = disabled. Bullet id spawned when this weapon's projectile hits.")]
	public int ChainBulletId;

	[Tooltip("Percent of the parent bullet damage dealt by the chained bullet. Shown in descriptions as #_P.")]
	public int ChainDamagePercent;

	[Tooltip("Chance for the chain bullet to spawn on hit. Shown in descriptions as #activationPer. 100 = always.")]
	public int ChainActivationPercent;

	[Tooltip("Spawn the chain bullet on the ground (flattened Y) with upright / perpendicular-to-ground rotation.")]
	public bool ChainSpawnOnGround;

	[Tooltip("-1 = disabled. Bullet id spawned each time this weapon launches a projectile.")]
	public int LaunchChainBulletId;

	[Tooltip("Percent of the launched bullet damage dealt by the chained bullet. Shown in descriptions as #_P.")]
	public int LaunchChainDamagePercent;

	[Tooltip("Chance for the chain bullet to spawn on launch. Shown in descriptions as #activationPer. 100 = always.")]
	public int LaunchChainActivationPercent;

	[Tooltip("Spawn the chain bullet on the ground (flattened Y) with upright / perpendicular-to-ground rotation.")]
	public bool LaunchChainSpawnOnGround;

	public bool IntervalWeapon;

	public bool PositionControlByBullet;

	public float IntervalWeaponActiveTime;

	public float IntervalWeaponActiveTimeGrow;

	public int WeaponSoundId;

	public float OnWeak;

	public float OnFire;

	public int TickNeedForAccumulatedFirePotencyUp;

	public float OnShock;

	[Tooltip("Mark duration in seconds. While marked, hits gain OnMarkCriticalChanceBonus crit chance.")]
	public float OnMark;

	[Tooltip("Extra critical chance percent applied to damage against a Marked enemy.")]
	public int OnMarkCriticalChanceBonus;

	public List<GameTag> ResolvedTags;

	public List<GameTag> ExtraTags;

	public TagRequirements TagGate;

	public List<BuildArchetype> Archetypes;

	public PartStats PartStats;

	public List<int> RequiredWeaponsId;

	public List<int> RequiredOverloadId;

	public List<int> RequiredChipsId;

	public List<int> IncompatibleChipsId;

	[Tooltip("Proficiency level that unlocks this weapon's evolutions. -1 = available from the start (no proficiency). 0 = use WeaponProficiencyConfig default.")]
	public int EvolutionUnlockProficiencyLevel;

	[Tooltip("Optional per-weapon proficiency rewards (one per level). If empty, uses WeaponProficiencyConfig.LevelRewards. Do not assign a reward on the evolution unlock level.")]
	public List<WeaponProficiencyLevelReward> ProficiencyLevelRewards;

	public List<EvolutionRequirementOption> WeaponToEvolveId;

	public List<EvolutionRequirementOption> MicrochipRequiredToEvolve;

	public List<EvolutionRequirementOption> OverloadRequiredToEvolve;

	public void SetDescriptionName(string evolution, string unlockCondition)
	{
	}

	public void BindEvolutionEditorSources(WeaponsDb weaponsDb, ChipDb chipDb, OverloadDb overloadDb)
	{
	}

	public void RefreshResolvedTags(BulletsDb bulletsDb, WeaponsDb weaponsDb)
	{
	}

	public void IsolateTagGate()
	{
	}

	public int GetWeaponDamageByLevel(int level)
	{
		return 0;
	}

	public float GetWeaponAttackRateByLevel(int level)
	{
		return 0f;
	}

	public float GetWeaponReloadTimeByLevel(int level)
	{
		return 0f;
	}

	public int GetWeaponBaseMagazineByLevel(int level)
	{
		return 0;
	}

	public float GetWeaponIntervalTimeByLevel(int level)
	{
		return 0f;
	}
}
