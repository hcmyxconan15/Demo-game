using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Stats : StatsBase
{
	[CompilerGenerated]
	private sealed class _003CAttackIncreaseBarController_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int increasePercent;

		public Stats _003C_003E4__this;

		public float time;

		private float _003CtimeForBar_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAttackIncreaseBarController_003Ed__125(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CIncreaseAttackByTimeCoroutine_003Ed__123 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Stats _003C_003E4__this;

		public int increasePercent;

		public int time;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CIncreaseAttackByTimeCoroutine_003Ed__123(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRevivalPlayerCoroutine_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Stats _003C_003E4__this;

		private GameControllers _003CgameControllers_003E5__2;

		private float _003Celapsed_003E5__3;

		private bool _003CaddingLife_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRevivalPlayerCoroutine_003Ed__122(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public MechPlayerController MechPlayerController;

	[Header("Shield")]
	public ShieldController ShieldController;

	[Header("Effects stats")]
	public ParticleSystem AttackBuff;

	[Header("Power ups active")]
	public int MaxHealthByPowerUp;

	public int SpeedByPowerUp;

	public int DamageByPowerUp;

	public int MagnetByPowerUp;

	public int GoldByPowerUp;

	public int ReloadByPowerUp;

	public int DroneByPowerUp;

	public int OverloadByPowerUp;

	public int MicrochipByPowerUp;

	public int XpByPowerUp;

	public int MagazineCapacityByPowerUp;

	public float RecoveryByPowerUp;

	public float BoxSecondItemChancePercent;

	public float BoxThirdItemChancePercent;

	public int ShopDiscountOffByPowerUp;

	public int ShopDiscountItemsByPowerUp;

	[Header("Microchip active specials")]
	public int FreeRerollOnLevelUp;

	public int FreeBanishOnLevelUp;

	public int DashIncrease;

	public int DashReloadTimePercent;

	public int ShieldDecayReductionPercent;

	public int SpeedIncreasePercent;

	public int BaseDashCharges;

	public float BaseDashCooldown;

	private float _immuneTime;

	private float _immuneTimeOtherSource;

	private float _dashImmuneTime;

	private float _missileGuaranteedCriticalEndTime;

	private float _timedDamageIncreaseEndTime;

	private float _timedSpeedIncreaseEndTime;

	public int RunCoinsCollected;

	public int ScrapToFirepowerDamagePercent;

	private const float LevelConstant = 0.4f;

	private const float LevelGrow = 1.5f;

	private int _maxLifeIncrease;

	private int _maxShieldIncrease;

	private bool _shieldVisualActive;

	private float _speedByPowerUpConverted;

	private float _timeForRecover;

	private float _lifeToRecover;

	private int _lifeToAdd;

	private Coroutine _coroutineAttackBar;

	private bool IsImmune => false;

	private void Update()
	{
	}

	public void SetInitialRobotStats(int baseId, int bodyId)
	{
	}

	public void ActivateMissileGuaranteedCritical(float durationSeconds)
	{
	}

	public bool IsMissileGuaranteedCriticalActive()
	{
		return false;
	}

	public void ActivateTimedDamageIncrease(int increasePercent, int durationSeconds)
	{
	}

	public void ApplyOverloadIntervalHeal(int healAmount)
	{
	}

	public bool IsTimedDamageIncreaseActive()
	{
		return false;
	}

	public void ExtendTimedSpeedIncreaseVisibility(float durationSeconds)
	{
	}

	public bool IsTimedSpeedIncreaseActive()
	{
		return false;
	}

	private static void ExtendTimedBuffEndTime(ref float endTime, float durationSeconds)
	{
	}

	public void UpdateStats()
	{
	}

	private void ApplyPilotSkillSlotBonuses(PilotSkills pilotSkills, int pilotId)
	{
	}

	private void ApplyPilotSkillStats()
	{
	}

	public int GetBodyLevelGrowthTimes()
	{
		return 0;
	}

	public int GetBaseLevelGrowthTimes()
	{
		return 0;
	}

	private int GetLevelGrowthTimes(int maxTimes, int levelInterval)
	{
		return 0;
	}

	private void ApplyPartsLevelGrowthStats()
	{
	}

	private void ApplyLevelGrowthStats(List<StatToIncrease> growthStats, int maxTimes, int levelInterval)
	{
	}

	private void ApplyStatIncrease(StatToIncrease statToIncreases, int level)
	{
	}

	private void ApplyStatIncreaseValue(StatToIncrease.StatIncreaseType statsType, float value)
	{
	}

	public void AddShieldByMaxPercent(int percentOfMaxShield)
	{
	}

	public void AddShield(int amount)
	{
	}

	public void RefreshShieldState()
	{
	}

	private void UpdateShieldUi()
	{
	}

	private void DecayShieldByTime()
	{
	}

	private int AbsorbDamageWithShield(int damageTotal, out int lifeDamage)
	{
		lifeDamage = default;
		return 0;
	}

	private void CurrentBaseStats(int baseId, int bodyId)
	{
	}

	public void LoadPowerUpsState(bool gamePlayScene)
	{
	}

	public int RollBoxItemCount(int minItemsToAdd, int maxItems)
	{
		return 0;
	}

	public float GetCurrentSpeed()
	{
		return 0f;
	}

	public int GetCurrentDashCharges()
	{
		return 0;
	}

	public float GetCurrentDashReloadTime()
	{
		return 0f;
	}

	public void ApplyDashToMovement()
	{
	}

	public float GetCurrentReloadTime(Weapon weapon, int weaponLevel, Stats stats)
	{
		return 0f;
	}

	private float GetReloadRateReduction(Weapon weapon, int weaponLevel, Stats stats)
	{
		return 0f;
	}

	public float GetCurrentFireRate(Weapon weapon, int weaponLevel, Stats stats, int extraFireRatePercent = 0)
	{
		return 0f;
	}

	private float GetFireRateReduction(Weapon weapon, Stats stats, int extraFireRatePercent = 0)
	{
		return 0f;
	}

	public int GetPlusMagazinePercent(Weapon weapon, Stats stats)
	{
		return 0;
	}

	public int GetPlusMagazineDirectValue(Weapon weapon, Stats stats)
	{
		return 0;
	}

	public void InitialLevel()
	{
	}

	public void InitialLevelMainUi()
	{
	}

	public void AddExp(int xpValue)
	{
	}

	public void AddExpFromCollectorDeposit(int xpValue)
	{
	}

	public void AddExpPercentOfNextNeed(int percent)
	{
	}

	public void AddCoinAndIncreaseByCurrentStatus(int coinValue)
	{
	}

	public void AddCoinByCollectingOnGround(int coinValue)
	{
	}

	public int GetXpIncreaseValue(int xpValue)
	{
		return 0;
	}

	public int GetCollectorXpDepositIncreaseValue(int xpValue)
	{
		return 0;
	}

	public int GetCoinIncreaseValue(int goldValue)
	{
		return 0;
	}

	private void LevelUp()
	{
	}

	private void RefreshPartsLevelGrowthOnLevelUp()
	{
	}

	private void ApplyChipsAndOverloadsOnLevelUp()
	{
	}

	public void AddLifeByRecover(int life)
	{
	}

	public override void AddLife(int life)
	{
	}

	public override void AddLifeBasedOnPercents(int lifePercent)
	{
	}

	public override void ApplyPureDamage(int damage)
	{
	}

	public override void ApplyPureDamageBasedOnPercents(int damagePercentFromCurrentLife)
	{
	}

	public override void ApplyDamage(DamageBase damageBase, bool showDamageText)
	{
	}

	public override void ApplyFireDamage(int damage)
	{
	}

	public override void ApplyDamageOtherSource(int weaponId, int damage, bool critical, float pushBackForce, float inmuneTime)
	{
	}

	public override void ApplyFiredState(float timer, float potency, int tickNeedForAccumulatedFirePotencyUp)
	{
	}

	public override void ManageFiredState()
	{
	}

	public override void ApplyShockState(float timer)
	{
	}

	public override void ManageShockState()
	{
	}

	public override void ApplyWeakState(float timer)
	{
	}

	public override void ManageWeakState()
	{
	}

	public override void ApplyMarkState(float timer, int criticalChanceBonusPercent)
	{
	}

	public override void ManageMarkState()
	{
	}

	public void RecoverHealthByTime()
	{
	}

	public void SetImmuneTime(float immuneTime)
	{
	}

	public void SetDashImmuneTime(float immuneTime)
	{
	}

	public void ClearDashImmuneTime()
	{
	}

	public override void DisableNotDead()
	{
	}

	public override void IncreaseAttackByTime(int increasePercent, int time)
	{
	}

	public override void Dead()
	{
	}

	private void RevivalPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CRevivalPlayerCoroutine_003Ed__122))]
	private IEnumerator RevivalPlayerCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIncreaseAttackByTimeCoroutine_003Ed__123))]
	private IEnumerator IncreaseAttackByTimeCoroutine(int increasePercent, int time)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttackIncreaseBarController_003Ed__125))]
	private IEnumerator AttackIncreaseBarController(int increasePercent, float time)
	{
		return null;
	}
}
