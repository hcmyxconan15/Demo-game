using System.Collections.Generic;
using UnityEngine;

public class DamageOnLevelController : MonoBehaviour
{
	public List<WeaponDamageInLevel> WeaponDpsList;

	public List<OverloadDamageInLevel> OverloadDamageInLevel;

	public float CombatTimeSeconds;

	private readonly Dictionary<(int weaponId, int droneId), WeaponDamageInLevel> _weaponDpsByKey;

	private readonly Dictionary<int, OverloadDamageInLevel> _overloadDpsById;

	private readonly Dictionary<int, int> _weaponKillCountsByBaseId;

	private void Awake()
	{
	}

	public void AddWeaponKill(int weaponId)
	{
	}

	public Dictionary<int, int> ConsumeWeaponKillCountsByBaseId()
	{
		return null;
	}

	private void Update()
	{
	}

	public float GetCombatTimeSeconds()
	{
		return 0f;
	}

	public void AddWeaponDamageInLevel(int weaponId, int droneId, int damage)
	{
	}

	public int GetWeaponDamageOnLevel(int weaponId, int droneId)
	{
		return 0;
	}

	public void AddOverloadDamage(int overloadId, int damage)
	{
	}

	public int GetOverloadDamageOnLevel(int overloadId)
	{
		return 0;
	}

	public int GetTotalDamage()
	{
		return 0;
	}
}
