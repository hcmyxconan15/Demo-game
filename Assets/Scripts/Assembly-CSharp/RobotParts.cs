using System.Collections.Generic;
using UnityEngine;

public class RobotParts : MonoBehaviour
{
	public Transform BaseTransform;

	public int BaseId;

	public int BodyId;

	public int PilotId;

	public int FreeSlotTypeA;

	public int FreeSlotTypeB;

	public int FreeSlotTypeC;

	public int FreeSlotTypeD;

	public MechaDataBase MechaDataBase;

	public RobotBaseDb RobotBaseDb;

	public RobotBodyDb RobotBodyDb;

	public WeaponsDb WeaponsDb;

	public WeaponsDb DroneWeaponsDb;

	public DroneDb DroneDb;

	public ChipDb ChipDb;

	public OverloadDb OverloadDb;

	public PilotDb PilotDb;

	public PowerUpsDb PowerUpsDb;

	public MechPlayerController MechPlayerController;

	public PilotSkills PilotSkills;

	public List<WeaponJoin> WeaponsJoins;

	public List<MicrochipInstalled> MicrochipsInstalled;

	public List<OverloadInstalled> OverloadInstalled;

	public List<Drone> DronesActives;

	public Transform Magnet;

	public Transform UpTransform;

	public BaseJoin BaseJoin;

	public BodyJoin BodyJoin;

	private BuildTagIndex _buildTagIndex;

	private BuildArchetypeIndex _seedBuildArchetypeIndex;

	private readonly List<int> _startingWeaponIds;

	private readonly List<GameObject> _runtimeDroneFollowPositions;

	private int _startingDroneId;

	private bool _buildTagIndexDirty;

	private const float DuplicateFollowMinDistance = 4f;

	public BuildTagIndex GetBuildTagIndex()
	{
		return null;
	}

	public BuildArchetypeIndex GetBuildArchetypeIndex()
	{
		return null;
	}

	public void InvalidateBuildTagIndex()
	{
	}

	public TagOfferWeightConfig GetTagOfferWeightConfig()
	{
		return null;
	}

	private void RebuildBuildIndicesIfDirty()
	{
	}

	private void CaptureSeedBuildArchetypes(IReadOnlyList<int> startingWeaponIds, int startingDroneId)
	{
	}

	private void Awake()
	{
	}

	public void JoinRobotParts(MechData mechData)
	{
	}

	public void RefreshPilotSkillsMainMenu()
	{
	}

	public void JoinRobotPartsMainUi(MechData mechData)
	{
	}

	public void UpdateAllJoinsAndStats()
	{
	}

	public void RefreshWeaponCombatStats()
	{
	}

	public void AddWeapon(int id)
	{
	}

	public void EvolveWeapon(int id, int newId)
	{
	}

	public void AddDrone(int droneId)
	{
	}

	private void EnsureDroneDuplicatesForLevel(DroneStats droneStats, Drone primary)
	{
	}

	private void AddInitialDrone(int droneId, bool updateInGameUi)
	{
	}

	private void EnsureStartingDroneSlot()
	{
	}

	private void ClearActiveDrones()
	{
	}

	private void ClearRuntimeDroneFollowPositions()
	{
	}

	private void TrySpawnNewDrone(DroneStats newDrone, bool updateInGameUi)
	{
	}

	private void TrySpawnDroneOnSlot(DroneStats newDrone, DronePosition droneSlot, bool updateInGameUi)
	{
	}

	private void SpawnDroneDuplicateOnSameSlot(DroneStats droneStats, Drone primary)
	{
	}

	private Transform ResolveDuplicateFollowTransform(Drone primary, int duplicateIndex)
	{
		return null;
	}

	private DronePosition TryClaimSpareDronePosition()
	{
		return null;
	}

	private Transform CreateDuplicateFollowTransform(Transform primaryFollow, int duplicateIndex)
	{
		return null;
	}

	private bool IsDroneFollowPositionAvailable(Vector3 candidatePosition)
	{
		return false;
	}

	private static Vector2Int GetSquareSpiralPosition(int index)
	{
		return default;
	}

	private Drone CreateDroneInstance(DroneStats droneStats, Transform followTransform, bool isSlotOwner, int level, Drone primary)
	{
		return null;
	}

	public void AddChip(int chipId)
	{
	}

	public void AddOverload(int overloadId)
	{
	}

	public bool HaveFreeSlotForWeapon(Weapon.SlotType slotType)
	{
		return false;
	}

	public bool HaveFreeSlotForChip()
	{
		return false;
	}

	public bool HaveFreeSlotForOverload()
	{
		return false;
	}

	public bool HaveFreeSlotForDrone()
	{
		return false;
	}

	public void DetachPartsOnDead()
	{
	}

	private void UpdateFreeSlotsCount()
	{
	}

	private void AddBase(int baseId)
	{
	}

	private void AddBody(int bodyId)
	{
	}

	private void AddInitialWeapons(List<int> weaponIds)
	{
	}

	private void AddDroneCapacity(int droneCapacity)
	{
	}

	private void AddInitialWeaponsMainUi(List<int> weaponIds)
	{
	}

	private void UpdateMagnetSize()
	{
	}

	public void ExecuteOverloadDirectAction(OverloadInstalled overloadInstalled)
	{
	}

	public int GetStationaryTagDamagePercent(HashSet<GameTag> weaponTags)
	{
		return 0;
	}

	public void RegisterCoinsCollected(int coinValue)
	{
	}

	public void RefreshScrapToFirepowerDamage()
	{
	}

	public int GetScrapToFirepowerDamagePercent()
	{
		return 0;
	}

	public int GetStationaryTagFireRatePercent(HashSet<GameTag> weaponTags)
	{
		return 0;
	}

	public float GetStationaryBonusLingerSeconds()
	{
		return 0f;
	}

	public float GetStationaryBonusArmSecondsRequired()
	{
		return 0f;
	}

	private static bool WeaponTagsMatchBonus(HashSet<GameTag> weaponTags, List<GameTag> bonusWeaponTags)
	{
		return false;
	}

	public bool WeaponShotHasTag(int weaponId, int droneId, GameTag tag)
	{
		return false;
	}

	public bool WeaponShotIsSiegeProjectile(int weaponId, int droneId)
	{
		return false;
	}

	public bool ShouldPauseShieldDecayWhileStationary()
	{
		return false;
	}

	public void OnShieldDamageAbsorbed(int absorbed)
	{
	}

	private void ForceReloadWeapons(BulletType.BulletClassType? bulletClassType, BulletType.TypeOfBullet? typeOfBullet)
	{
	}

	private static bool MatchesReloadFilter(WeaponJoin weaponJoin, BulletType.BulletClassType? bulletClassType, BulletType.TypeOfBullet? typeOfBullet)
	{
		return false;
	}

	private static float GetCurrentCombatTimeSeconds()
	{
		return 0f;
	}

	private void UpdatePilotSkills(bool inGame)
	{
	}

	private void TryInstallPilotOverload(int pilotId, int overloadId, bool inGame)
	{
	}

	private void TryInstallPilotMicrochip(int pilotId, int chipId, bool inGame)
	{
	}
}
