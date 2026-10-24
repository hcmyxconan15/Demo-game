using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddChipHelperButton : MonoBehaviour
{
	public int Id;

	public Image WeaponIcon;

	public TextMeshProUGUI Name;

	public TextMeshProUGUI IdText;

	public TextMeshProUGUI SlotType;

	public TextMeshProUGUI ChipLevel;

	public HelperDevInput.TypeButton TypeButton;

	public void Setup(Microchip microchip, int chipLevel)
	{
	}

	public void SetupOverload(Overload overload, int overloadLevel)
	{
	}

	public void SetupDrone(DroneStats droneStats, int droneLevel)
	{
	}

	public void AddThis()
	{
	}
}
