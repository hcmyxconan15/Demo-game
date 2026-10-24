using TMPro;
using UnityEngine;

public class WeaponDamageResultButton : MonoBehaviour
{
	public TextMeshProUGUI ActiveTime;

	public TextMeshProUGUI DamageInLevel;

	public TextMeshProUGUI DpsValue;

	public SlotInfo SlotInfo;

	public OverloadSlotUi OverloadSlotUi;

	public void SetupWeaponResult(int damage, WeaponSlotUi weaponSlotUi)
	{
	}

	public void SetupOverloadResult(int damage, OverloadSlotUi overloadSlotUi)
	{
	}

	private void SetActiveTimeText(float elapsedSeconds)
	{
	}

	private void SetDpsText(int damage, float combatSeconds)
	{
	}
}
