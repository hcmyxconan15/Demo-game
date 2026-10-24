using System.Collections.Generic;
using UnityEngine;

public class InitialWeaponController : MonoBehaviour
{
	public List<InitialWeaponSlot> InitialWeaponSlots;

	private int _currentEquippedWeapon;

	private int _currentEquippedDrone;

	public void SetupInitialWeapons(int mechId, bool mechUnlocked)
	{
	}
}
