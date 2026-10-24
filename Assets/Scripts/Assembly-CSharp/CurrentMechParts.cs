using UnityEngine;
using UnityEngine.UI;

public class CurrentMechParts : MonoBehaviour
{
	public CurrentPilot CurrentPilot;

	[Header("Weapon")]
	public Image WeaponImage;

	[Header("Body")]
	public Image BodyImage;

	[Header("Base")]
	public Image BaseImage;

	public void SetCurrentEquipItems(MechData mechData, bool unlocked)
	{
	}

	private void SetWeaponInfo(Weapon weapon, bool unlocked)
	{
	}

	private void SetDroneInfo(DroneStats drone, bool unlocked)
	{
	}

	private void SetBodyInfo(BodyType bodyType, bool unlocked)
	{
	}

	private void SetBaseInfo(BaseType baseType, bool unlocked)
	{
	}
}
