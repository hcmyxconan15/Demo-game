using UnityEngine;
using UnityEngine.EventSystems;

public class DevHelperButtonItemInfo : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private enum ItemKind
	{
		None = 0,
		Weapon = 1,
		Microchip = 2,
		Overload = 3,
		Drone = 4,
		Monster = 5
	}

	private ItemKind _itemKind;

	private Weapon _weapon;

	private int _itemLevel;

	private Microchip _microchip;

	private Overload _overload;

	private DroneStats _drone;

	private EnemyData _enemy;

	private int _monsterSpawnCount;

	public static DevHelperButtonItemInfo EnsureOn(GameObject gameObject)
	{
		return null;
	}

	public void ConfigureWeapon(Weapon weapon, int currentLevel)
	{
	}

	public void ConfigureMicrochip(Microchip microchip, int currentLevel)
	{
	}

	public void ConfigureOverload(Overload overload, int currentLevel)
	{
	}

	public void ConfigureDrone(DroneStats drone, int currentLevel)
	{
	}

	public void ConfigureMonster(EnemyData enemy, int spawnCount)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void ShowInfo()
	{
	}

	private void HideInfo()
	{
	}

	private string BuildMonsterInfo()
	{
		return null;
	}

	private void Clear()
	{
	}
}
