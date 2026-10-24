using System.Collections.Generic;
using UnityEngine;

public class CurrentWeaponsUi : MonoBehaviour
{
	public List<WeaponSlotUi> WeaponsSlotsActive;

	public List<WeaponSlotUi> WeaponsSlotsDroneActive;

	public List<MicrochipSlotUi> MicrochipSlotsActive;

	public List<OverloadSlotUi> OverloadSlotActive;

	public List<TemporalBuffUi> TemporalBuffUis;

	private Dictionary<int, WeaponSlotUi> _weaponSlotByWeaponId;

	private Dictionary<int, WeaponSlotUi> _droneSlotByWeaponId;

	private const float BulletCountTextUpdateInterval = 0.08f;

	private readonly Dictionary<int, (int count, float time)> _lastBulletCountUi;

	private readonly Dictionary<int, (int count, float time)> _lastDroneBulletCountUi;

	public void HideWeaponSlot(Weapon weapon)
	{
	}

	public void UpdateWeaponStatusUi(Weapon weapon, int level, WeaponJoin weaponJoin)
	{
	}

	public RectTransform GetWeaponSlotIconTransform(int weaponId)
	{
		return null;
	}

	public RectTransform GetDroneSlotIconTransform(int droneId)
	{
		return null;
	}

	public RectTransform GetMicrochipSlotIconTransform(int microchipId)
	{
		return null;
	}

	public RectTransform GetOverloadSlotIconTransform(int overloadId)
	{
		return null;
	}

	private WeaponSlotUi GetWeaponSlot(int weaponId)
	{
		return null;
	}

	private WeaponSlotUi GetDroneSlot(int weaponId)
	{
		return null;
	}

	private void CacheWeaponSlot(int weaponId, WeaponSlotUi slot)
	{
	}

	private void CacheDroneSlot(int weaponId, WeaponSlotUi slot)
	{
	}

	public void WeaponBulletCount(int weaponId, int bulletCount)
	{
	}

	public void ReloadTimerForWeapon(int weaponId, float value, int magazine)
	{
	}

	public void ReloadTimerFireRate(int weaponId, float value)
	{
	}

	public void CancelWeaponReloadUi(int weaponId, bool isDrone = false)
	{
	}

	public void UpdateDroneStatusUi(Weapon weapon, DroneStats droneStats, WeaponJoin weaponJoin)
	{
	}

	public void UpdateCollectorDroneStatusUi(DroneStats droneStats, Drone drone)
	{
	}

	public void WeaponDroneBulletCount(int weaponId, int bulletCount)
	{
	}

	public void ReloadTimerDroneFireRate(int weaponId, float value)
	{
	}

	public void ReloadTimerForWeaponDrone(int weaponId, float value, int magazine)
	{
	}

	public void UpdateMicrochip(Microchip microchip, int level)
	{
	}

	public void UpdateOverload(OverloadInstalled overload)
	{
	}

	private static void MoveAfterLastActiveSibling(Transform slot)
	{
	}

	public void ActiveTemporalBuffUiAttackTem(int value, bool active)
	{
	}
}
