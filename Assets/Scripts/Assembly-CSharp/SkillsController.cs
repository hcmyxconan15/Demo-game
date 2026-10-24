using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFireOverloadOnce_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverloadInstalled overloadInstalled;

		public SkillsController _003C_003E4__this;

		public Transform triggerLaunchPosition;

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
		public _003CFireOverloadOnce_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003COverloadLaunchChain_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverloadInstalled overloadInstalled;

		public SkillsController _003C_003E4__this;

		public Transform triggerLaunchPosition;

		private int _003ClaunchTimes_003E5__2;

		private float _003CtimeBetweenLaunch_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003COverloadLaunchChain_003Ed__53(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShotOverloadFromMatchingTurrets_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillsController _003C_003E4__this;

		public OverloadInstalled overloadInstalled;

		public int damage;

		public int bulletId;

		public int weaponId;

		public GameTag? requiredWeaponTag;

		public BulletType.BulletClassType? bulletClassType;

		public BulletType.TypeOfBullet? typeOfBullet;

		private Transform _003CfallbackLaunch_003E5__2;

		private float _003CtimeBetweenTurrets_003E5__3;

		private bool _003CfiredFromTurret_003E5__4;

		private List<WeaponJoin>.Enumerator _003C_003E7__wrap4;

		private WeaponJoin _003CweaponJoin_003E5__6;

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
		public _003CShotOverloadFromMatchingTurrets_003Ed__55(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public static SkillsController Instance;

	public Transform BulletParent;

	public List<DamageBase> BulletsOnPool;

	public BulletsDb BulletsDb;

	public MechPlayerController MechPlayerController;

	private readonly Dictionary<int, Stack<DamageBase>> _bulletPoolById;

	private readonly Dictionary<int, List<DamageBase>> _allBulletsById;

	private Vector3? _overloadDashStartOrigin;

	private readonly List<Vector3> _overloadDashBurstLandings;

	private void Awake()
	{
	}

	private void EnsurePoolCollections(int bulletId)
	{
	}

	private DamageBase CreateBulletInstance(int bulletId)
	{
		return null;
	}

	private DamageBase RentBullet(int bulletId, Vector3 position, Quaternion rotation, Transform parent = null)
	{
		return null;
	}

	public DamageBase GetPooledBullet(int bulletId, Vector3 position, Quaternion rotation, Transform parent = null)
	{
		return null;
	}

	public void ReleaseBullet(DamageBase bullet)
	{
	}

	public void PrewarmBullets(int bulletId, int count)
	{
	}

	public void PreloadAllBullets()
	{
	}

	public void ShotDamageBullet(Weapon weaponReference, int damage, int passEnemyCount, int ricochetCount, int id, int weaponId, int droneId, Transform launchPosition, int siegeDamagePercent = 0)
	{
	}

	private void TryChainBulletOnLaunch(Weapon weaponReference, DamageBase bullet)
	{
	}

	public DamageBase ShotPermanentBullet(Weapon weaponReference, int damage, int passEnemyCount, int ricochetCount, int id, int weaponId, int droneId, Transform launchPosition, int siegeDamagePercent = 0)
	{
		return null;
	}

	public void UpdateActiveBullets(int damage, int id)
	{
	}

	public void DeactivateBulletsById(int id)
	{
	}

	private void SetDamageStats(Weapon weaponReference, DamageBase damageBase, int weaponId, int droneId, int weaponDamage, int passEnemyCount, int ricochetCount, int siegeDamagePercent = 0)
	{
	}

	public int GetCriticalDamage(int damage, BulletType.TypeOfBullet typeOfBullet = BulletType.TypeOfBullet.Projectile)
	{
		return 0;
	}

	public int GetCriticalDamageWithChance(int damage, int criticalChancePercent, BulletType.TypeOfBullet typeOfBullet = BulletType.TypeOfBullet.Projectile)
	{
		return 0;
	}

	public int GetImpactCriticalChance(int bonusChancePercent = 0)
	{
		return 0;
	}

	public int GetIncreaseDamage(int damage, BulletType.BulletClassType bulletClassType, BulletType.TypeOfBullet typeOfBullet, int siegeDamagePercent = 0)
	{
		return 0;
	}

	public int GetEffectiveWeaponDamage(int baseWeaponDamage, BulletType.BulletClassType bulletClassType, BulletType.TypeOfBullet typeOfBullet, int siegeDamagePercent = 0)
	{
		return 0;
	}

	private void SetDamageStatsFromOverload(Overload overload, DamageBase damageBase, int weaponId, int weaponDamage, int passEnemyCount, int ricochetCount)
	{
	}

	private void ShotOverloadBullet(OverloadInstalled overloadInstalled, int damage, int passEnemyCount, int ricochetCount, int id, int weaponId, Transform launchPosition)
	{
	}

	private void ShotOverloadBulletAtPosition(OverloadInstalled overloadInstalled, int damage, int passEnemyCount, int ricochetCount, int id, int weaponId, Vector3 position, Quaternion rotation)
	{
	}

	private void SetupOverloadBullet(OverloadInstalled overloadInstalled, DamageBase bullet, int weaponId, int damage, int passEnemyCount, int ricochetCount)
	{
	}

	private bool CanActivateOverloads()
	{
		return false;
	}

	public void StopCombatCoroutinesForRunEnd()
	{
	}

	public void CheckOverloadOnEnemyDead(Transform launchPosition, bool killedByDrone = false)
	{
	}

	public void CheckOverloadOnHitEnemy(StatsEnemy enemyStats, DamageBase bullet)
	{
	}

	private void CheckForOverloadActivationByBulletLaunch(DamageBase bullet, Transform launchPosition)
	{
	}

	public void CheckOverloadActivationByReload(BulletType.BulletClassType bulletType)
	{
	}

	public void CheckOverloadActivationByReloadAtStart(BulletType.BulletClassType bulletType)
	{
	}

	public void CheckOverloadActivationByDash(Overload.ActivationBy overloadDashTypeTrigger, Vector3 dashStartPosition = default(Vector3))
	{
	}

	public void CheckOverloadActivationByMovement(Overload.ActivationBy overloadMovementTypeTrigger)
	{
	}

	public void ResetOverloadActivationInterval(Overload.ActivationBy activationTrigger)
	{
	}

	public void CheckOverloadActivationByEnemyKill(Overload.ActivationBy overloadKillType, Transform launchPosition)
	{
	}

	private void ActivateOverloadByLaunchType(OverloadInstalled overloadInstalled, Transform launchPosition)
	{
	}

	private void ActivateOverloadByReload(OverloadInstalled overloadInstalled, Transform launchPosition)
	{
	}

	private void ActivateOverloadByDash(OverloadInstalled overloadInstalled, Transform launchPosition, Vector3? dashStartOrigin = null)
	{
	}

	private void ActivateOverloadByMovement(OverloadInstalled overloadInstalled, Transform launchPosition)
	{
	}

	private void ActivateOverloadByKillEnemy(OverloadInstalled overloadInstalled, Transform launchPosition)
	{
	}

	public void CheckOverloadActivationByShieldAbsorb(int absorbedDamage, Transform launchPosition)
	{
	}

	public void CheckOverloadOnXpPickup(Transform origin)
	{
	}

	private void ActivateOverload(OverloadInstalled overloadInstalled, Transform triggerLaunchPosition, Vector3? dashStartOrigin = null)
	{
	}

	private Transform GetOverloadDeployAnchor(Overload overload, Transform triggerLaunchPosition)
	{
		return null;
	}

	private void TrySpawnDeployableOverload(OverloadInstalled overloadInstalled, Transform triggerLaunchPosition)
	{
	}

	[IteratorStateMachine(typeof(_003COverloadLaunchChain_003Ed__53))]
	private IEnumerator OverloadLaunchChain(OverloadInstalled overloadInstalled, Transform triggerLaunchPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFireOverloadOnce_003Ed__54))]
	private IEnumerator FireOverloadOnce(OverloadInstalled overloadInstalled, Transform triggerLaunchPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShotOverloadFromMatchingTurrets_003Ed__55))]
	private IEnumerator ShotOverloadFromMatchingTurrets(OverloadInstalled overloadInstalled, int damage, int bulletId, int weaponId, BulletType.BulletClassType? bulletClassType = null, BulletType.TypeOfBullet? typeOfBullet = null, GameTag? requiredWeaponTag = null)
	{
		return null;
	}

	private static Transform GetOverloadTurretLaunchTransform(WeaponJoin weaponJoin)
	{
		return null;
	}

	public void EventSkill(int id, Transform launchPosition)
	{
	}

	public void ShowDamageBulletFromEvents(int damage, int passEnemyCount, int ricochetCount, int id, int weaponId, int droneId, Transform launchPosition)
	{
	}
}
