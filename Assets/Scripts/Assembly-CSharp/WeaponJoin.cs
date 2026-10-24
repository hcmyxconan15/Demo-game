using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WeaponJoin : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShooting_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponJoin _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CShooting_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CShootingIntervalWeapon_003Ed__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponJoin _003C_003E4__this;

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
		public _003CShootingIntervalWeapon_003Ed__80(int _003C_003E1__state)
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
	private sealed class _003CShootingNotUiUpdate_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponJoin _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CShootingNotUiUpdate_003Ed__79(int _003C_003E1__state)
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

	public Transform BaseTransform;

	public ushort WeaponId;

	public ushort WeaponCurrentLevel;

	public ushort WeaponMaxLevel;

	public int BulletId;

	public int WeaponDamage;

	public int WeaponDamageAfterChips;

	public float AttackRate;

	public bool PermanentWeapon;

	public bool IgnoreMagazineGrowWeapon;

	public bool IntervalWeapon;

	public float IntervalCurrentWeaponActiveTime;

	public float IntervalWeaponActiveTimeGrow;

	public float BulletShowCannonsTime;

	public int CurrentMagazine;

	public int BaseMagazine;

	public int CurrenPassEnemyCount;

	public int CurrenRicochetCount;

	public BulletType.BulletClassType BulletClassType;

	public BulletType.TypeOfBullet TypeOfBullet;

	public List<Transform> LaunchPoint;

	public Animator WeaponAnimator;

	public Animator WeaponAnimator2;

	public List<ParticleSystem> MuzzleEffects;

	public bool UseExtraCannon;

	public List<Transform> LaunchPointExtraCannon;

	public List<ParticleSystem> ExtraMuzzleEffects;

	public bool UseExtraCannon2;

	public List<Transform> LaunchPointExtraCannon2;

	public List<ParticleSystem> ExtraMuzzleEffects2;

	public List<Renderer> Renderers;

	public int CurrentMagazineTotal;

	public bool DontRepeatSoundOnMultipleShots;

	public float ActiveTimeStart;

	public float CombatTimeStart;

	[Header("On drone")]
	public bool InDrone;

	public int DroneId;

	[Header("On destroy")]
	public BoxCollider WeaponBoxCollider;

	public Rigidbody WeaponRigidbody;

	public float _attackRate;

	public float _reloadTime;

	public Weapon WeaponBaseReference;

	private HashSet<GameTag> _weaponTags;

	public int CachedTagDamagePercent;

	public float EffectiveOnWeak;

	public float EffectiveOnFire;

	public float EffectiveOnShock;

	public float EffectiveOnMark;

	public int EffectiveOnMarkCriticalChanceBonus;

	private static readonly int ShootTrigger;

	private bool _soundTriggerOnce;

	private List<DamageBase> _permanentBullets;

	private static readonly WaitForSeconds WaitIntervalBulletCleanup;

	private WaitForSeconds _waitBulletShowCannons;

	private float _waitBulletShowCannonsSeconds;

	private WaitForSeconds _waitReload;

	private float _waitReloadSeconds;

	private WaitForSeconds _waitIntervalActive;

	private float _waitIntervalActiveSeconds;

	private const float PostReloadFireDelay = 0.3f;

	public bool HasWeaponTag(GameTag tag)
	{
		return false;
	}

	private WaitForSeconds GetBulletShowCannonsWait()
	{
		return null;
	}

	private WaitForSeconds GetReloadWait()
	{
		return null;
	}

	private WaitForSeconds GetIntervalActiveWait()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetupWeapon(Weapon weapon, int droneId)
	{
	}

	public void ResetPermanentWeapon()
	{
	}

	public void UpdateWeaponStats(Stats stats)
	{
	}

	public void Shoot()
	{
	}

	public void ShootNotUiUpdate()
	{
	}

	public void ForceInstantReload()
	{
	}

	private void ClearIntervalWeaponBullets()
	{
	}

	private void RefreshReloadUiAfterForceReload()
	{
	}

	public void DetachWeaponOnDead()
	{
	}

	private void ActivatePermanentWeapon()
	{
	}

	private void UpdatePermanentWeapon(int tempCurrentMagazine)
	{
	}

	private void ActivatingPermanentWeapon()
	{
	}

	[IteratorStateMachine(typeof(_003CShooting_003Ed__78))]
	private IEnumerator Shooting()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShootingNotUiUpdate_003Ed__79))]
	private IEnumerator ShootingNotUiUpdate()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShootingIntervalWeapon_003Ed__80))]
	private IEnumerator ShootingIntervalWeapon()
	{
		return null;
	}

	public Transform FindParentWithNegativeXScale(Transform start, int maxAttempts)
	{
		return null;
	}
}
