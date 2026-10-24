using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class StatsBase : MonoBehaviour
{
	public delegate void OnShockStateChangeEvent(bool shockState);

	public bool IsDead;

	public bool NotAvailableToTarget;

	public EffectsController.BloodColor BloodColor;

	public int Revival;

	public int CurrentLevel;

	public int CurrentXp;

	public int NextLevelXpNeeded;

	public int Life;

	public int MaxLife;

	public float Shield;

	public int MaxShield;

	public int Damage;

	public int MagnetBase;

	public float Speed;

	public float IncreaseSpeed;

	public int MicrochipSlots;

	public int OverloadSlots;

	public int DroneCapacity;

	public int BaseLife;

	public int BaseShield;

	public int BaseDamage;

	[Range(0f, 80f)]
	public int BaseReloadTimePercent;

	[Range(0f, 3f)]
	public ushort BaseMagazineIncreaseRaw;

	[Range(0f, 100f)]
	public int BaseCriticalChancePercent;

	[Range(0f, 200f)]
	public int BaseDamageIncreasePercent;

	[Range(0f, 200f)]
	public int BaseCriticalDamagePercent;

	[Range(0f, 100f)]
	public int BaseFireRatePercent;

	[Header("Altered stats")]
	[Header("Fire")]
	public float OnFired;

	public float OnFiredTickTime;

	public int FirePotency;

	public int TickNeedForAccumulatedFirePotencyUp;

	public int AccumulatedFirePotency;

	[Header("Shock")]
	public bool CantBeShocked;

	public bool OnShock;

	public float OnShockTime;

	public float OnShockResistance;

	[Header("Weak")]
	public bool OnWeak;

	public float OnWeakTime;

	[Header("Mark")]
	public bool OnMark;

	public float OnMarkTime;

	public int MarkCriticalChanceBonusPercent;

	[Header("Shield decay")]
	[Tooltip("When true, shield drains over time. When false, shield only decreases from damage.")]
	public bool ShieldDecaysOverTime;

	[Tooltip("Shield points removed per second while ShieldDecaysOverTime is enabled. Bigger shields take longer to deplete.")]
	public float ShieldDecayPerSecond;

	[Header("Global stats state")]
	public int LifeIncreaseRaw;

	[Range(0f, 200f)]
	public int LifeIncreasePercent;

	public int ShieldIncreaseRaw;

	[Range(0f, 200f)]
	public int ShieldIncreasePercent;

	[Range(0f, 100f)]
	public int CriticalChancePercent;

	[Range(0f, 500f)]
	public int CriticalDamagePercent;

	[Range(0f, 500f)]
	public int DamageIncreasePercent;

	[Range(0f, 80f)]
	public int ReloadTimePercent;

	[Range(0f, 80f)]
	public int FireRatePercent;

	[Range(0f, 500f)]
	public int MagazinePercent;

	[Range(0f, 10f)]
	public int MagazineIncreaseRaw;

	[Range(0f, 500f)]
	public int DamageIncreasePhysicalPercent;

	[Range(0f, 500f)]
	public int DamageIncreaseEnergyPercent;

	[Range(0f, 500f)]
	public int DamageIncreaseMissilePercent;

	[Range(0f, 500f)]
	public int DamageIncreaseBeamPercent;

	[Range(0f, 100f)]
	public int MagnetArea;

	[Range(0f, 500f)]
	public int XpCollectionPercent;

	[Range(0f, 500f)]
	public int CollectorXpDepositPercent;

	[Range(0f, 200f)]
	public int GoldCollectionPercent;

	[Range(0f, 100f)]
	public float RecoverBySecond;

	public int PierceEnemiesNumber;

	public int MissileIncreaseMagazine;

	public int ProjectileMagazineIncreasePhysical;

	public int ProjectileMagazineIncreaseEnergy;

	public int MissileMagazineIncreasePhysical;

	public int MissileMagazineIncreaseEnergy;

	public int BeamMagazineIncreasePhysical;

	public int BeamMagazineIncreaseEnergy;

	public int AreaMagazineIncreasePhysical;

	public int AreaMagazineIncreaseEnergy;

	public int BulletRicochet;

	[Header("Temporal ")]
	public int DamageIncreasePercentTemp;

	internal int TickNeedForAccumulatedFirePotencyUpCurrent;

	internal int TickNeedForAccumulatedFirePotencyDownCurrent;

	[CompilerGenerated]
	private OnShockStateChangeEvent m_OnShockStateChange;

	public bool IsAvailableToTarget => false;

	public event OnShockStateChangeEvent OnShockStateChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public abstract void ApplyDamage(DamageBase damageBaseStats, bool showDamageText);

	public abstract void ApplyFireDamage(int damage);

	public abstract void ApplyDamageOtherSource(int weaponId, int damage, bool critical, float pushBackForce, float inmuneTime);

	public abstract void AddLife(int life);

	public abstract void AddLifeBasedOnPercents(int lifePercent);

	public abstract void ApplyPureDamage(int damage);

	public abstract void ApplyPureDamageBasedOnPercents(int percentFromCurrentLife);

	public abstract void ApplyFiredState(float timer, float potency, int tickNeedForAccumulatedFirePotencyUp);

	public abstract void ManageFiredState();

	protected void RaiseOnShockStateChange(bool shockState)
	{
	}

	public abstract void ApplyShockState(float timer);

	public abstract void ManageShockState();

	public abstract void ApplyWeakState(float timer);

	public abstract void ManageWeakState();

	public abstract void ApplyMarkState(float timer, int criticalChanceBonusPercent);

	public abstract void ManageMarkState();

	public abstract void Dead();

	public abstract void DisableNotDead();

	public abstract void IncreaseAttackByTime(int increasePercent, int time);

	public virtual int GetOutgoingDamage(int plus = 0)
	{
		return 0;
	}

	public int GetCurrentLifePointsPercent()
	{
		return 0;
	}

	public int GetMagazineIncreaseByBulletKind(BulletType.TypeOfBullet typeOfBullet, BulletType.BulletClassType bulletClassType)
	{
		return 0;
	}
}
