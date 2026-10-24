using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class StatsEnemy : StatsBase
{
	private struct AuraSourceEntry
	{
		public ulong SourceId;

		public int SpeedBonusPercent;

		public int DamageBonusPercent;

		public int RegenPerTick;

		public float RegenIntervalSeconds;

		public float LingerSeconds;
	}

	[CompilerGenerated]
	private sealed class _003CDying_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StatsEnemy _003C_003E4__this;

		public bool wasOnShock;

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
		public _003CDying_003Ed__88(int _003C_003E1__state)
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
	private sealed class _003CDyingByDisable_003Ed__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StatsEnemy _003C_003E4__this;

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
		public _003CDyingByDisable_003Ed__89(int _003C_003E1__state)
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

	public EnemyBase EnemyBase;

	public bool HaveParts;

	public bool ForceParts;

	public Transform PartPosition;

	public bool UseLifeBarsWorldBarUi;

	public WorldBarUi WorldBarUi;

	public ParticleSystem OnFireParticles;

	public ParticleSystem OnShockParticles;

	public int DeadAnimationCount;

	public bool UseMainCanvasLifeBar;

	public BossLifeBarUi BossLifeBarReference;

	public Transform StatusTransform;

	public MapMarker MapMarker;

	public Outline Outline;

	[Header("Life multiply by level")]
	public bool UsePlayerLevelToIncreaseLife;

	private int _randomDeadType;

	private int _killingBlowDroneId;

	private int _killingBlowWeaponId;

	private int _timeForDisable;

	private readonly List<int> _hitSound;

	private bool _shaking;

	private bool _worldLifeBarRevealed;

	private bool _worldLifeBarSuppressed;

	private static readonly int InShockAnimator;

	private int _randomAnimation;

	private int _baseLife;

	private float _hideOnGroundTimer;

	private readonly List<AuraSourceEntry> _auraSources;

	private int _auraSpeedBonusPercent;

	private int _auraDamageBonusPercent;

	private int _auraRegenPerTick;

	private float _auraRegenInterval;

	private float _auraRegenTimer;

	private float _auraLingerEndTime;

	public UnityEvent OnDead;

	public UnityEvent OnRestart;

	public bool HasSpeedBuff => false;

	public bool HasDamageBuff => false;

	public bool HasRegenBuff => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public bool HasActiveStatusEffects()
	{
		return false;
	}

	private void RegisterStatusTick()
	{
	}

	private void UnregisterStatusTick()
	{
	}

	private void RestartEnemy()
	{
	}

	private void SetMainCanvasLifeBar()
	{
	}

	private void HideMainCanvasLifeBar()
	{
	}

	private void SetLifeBarsWorldBarUi()
	{
	}

	public void RefreshQuestMark()
	{
	}

	private void FillLifeBarImmediate()
	{
	}

	private void UpdateLifeBarOnDamage(bool shake = false)
	{
	}

	public void SetWorldUiOffscreen(bool offscreen)
	{
	}

	public void SetWorldLifeBarSuppressed(bool suppressed)
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

	public override void AddLife(int life)
	{
	}

	public override void AddLifeBasedOnPercents(int lifePercent)
	{
	}

	public override void ApplyPureDamage(int damage)
	{
	}

	public override void ApplyPureDamageBasedOnPercents(int percentFromCurrentLife)
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

	public override void Dead()
	{
	}

	public override void DisableNotDead()
	{
	}

	public override void IncreaseAttackByTime(int increasePercent, int time)
	{
	}

	public override int GetOutgoingDamage(int plus = 0)
	{
		return 0;
	}

	public void AddAuraSource(ulong sourceId, int speedBonusPercent, int damageBonusPercent, int regenPerTick, float regenIntervalSeconds, float lingerSeconds)
	{
	}

	public void RemoveAuraSource(ulong sourceId)
	{
	}

	public void ManageAuraBuffs()
	{
	}

	private void TickAuraRegen()
	{
	}

	private void RecalculateAuraBonuses()
	{
	}

	private void ClearAuraBuffs()
	{
	}

	private void DeadAnimation()
	{
	}

	private void Drop()
	{
	}

	private void HitSound()
	{
	}

	private void ShakeLifeBars()
	{
	}

	private void EndShake()
	{
	}

	[IteratorStateMachine(typeof(_003CDying_003Ed__88))]
	private IEnumerator Dying(bool wasOnShock = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDyingByDisable_003Ed__89))]
	private IEnumerator DyingByDisable()
	{
		return null;
	}

	private void SetShockState(bool enabledShock, float timer, bool raiseEvent)
	{
	}
}
