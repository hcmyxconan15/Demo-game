using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[Serializable]
public class DataUser
{
	public int SavedBuildNumber;

	public string UserName;

	public int LanguageIndex;

	public bool LanguageSelectedByUser;

	public int SkillPoints;

	public int DiamondsPoints;

	public int Coins;

	public int CurrentPlanetSelected;

	public int CurrentQuestSelected;

	public int SpendSkillPoints;

	public int BestScore;

	public int MechSelected;

	public int MovementTypeSelected;

	public int PilotSelected;

	public List<PowerUps> PowerUps;

	public List<MechData> MechData;

	public List<PilotData> PilotData;

	public List<WeaponProficiencyData> WeaponProficiencyList;

	public MapData MapData;

	public List<UnlockItemData> UnlockPlanets;

	public List<UnlockItemData> UnlockMechList;

	public List<UnlockItemData> UnlockWeaponsList;

	public List<UnlockItemData> UnlockMicroChipList;

	public List<UnlockItemData> UnlockOverloadList;

	public List<UnlockItemData> UnlockDroneList;

	public List<UnlockItemData> UnlockBodyList;

	public List<UnlockItemData> UnlockBaseList;

	[Header("End game multiplier")]
	public int NormalEnemyKilledMultiplier;

	public int EliteEnemyMultiplier;

	public int MercenaryEnemyKilledMultiplier;

	public int BossEnemyKilledMultiplier;

	public int ChestMultiplier;

	public int QuestCompletedMultiplier;

	public int TimePlayedMultiplier;

	[Header("GeneralSettings")]
	public bool Blood;

	public bool Parts;

	public bool DamageNumbers;

	public bool CoinMovement;

	public bool CameraShake;

	public bool EnemyCameraFocus;

	public bool Vibrations;

	public bool LifeBars;

	[OptionalField]
	public bool SpeedUpBoxSequence;

	[Header("QualitySettings")]
	public bool FullScreen;

	public int FullScreenModeIndex;

	public int QualityIndex;

	public int ResolutionIndex;

	public bool Shadows;

	public int Vsync;

	public bool Vignette;

	public bool ShowFps;

	public int TargetFrameRate;

	public float Brightness;

	public float RenderScale;

	public int TargetMonitor;

	[Header("Sound")]
	public bool MasterSound;

	public float VolumeMusic;

	public float VolumeFx;

	[Header("Achievement data")]
	public List<AchievementData> Achievements;

	public List<StatsData> Stats;

	[Header("Achievement data")]
	public List<HuntsData> HuntsData;

	[Header("Other data")]
	public bool ConsentGiven;

	[OptionalField]
	public bool AnalyticsConsentAnswered;

	public List<int> FtueStepsSent;

	public List<int> TutorialsSeen;

	public bool HasOpenedHangarParts;

	public int LevelsStarted;

	public int LevelsCompleted;

	public int DeadCount;

	public int MonsterKilled;

	[OptionalField]
	public float TotalPlayTimeSeconds;

	public string UserPlayFabId;

	[OnDeserializing]
	private void OnDeserializing(StreamingContext context)
	{
	}

	public void AddCoins(int coins)
	{
	}

	private static void NotifyScrapToFirepowerCoinsEarned(int coins)
	{
	}

	public void AddSkillPoints(int skillPoints)
	{
	}

	public void AddSpendSkillPoints(int skillPoints)
	{
	}

	public void ResetSkillPoints()
	{
	}

	public void AddDiamondsPoints(int diamondPoints)
	{
	}

	public PowerUps GetPowerUp(int powerUpId)
	{
		return null;
	}

	public void UpgradePowerUp(int powerUpId, float value)
	{
	}

	public void AddUnlockPlanet(int planetId)
	{
	}

	public bool IsPlanetUnlocked(int planetId)
	{
		return false;
	}

	public UnlockItemData GetPlanetUnlockedData(int planetId)
	{
		return null;
	}

	public bool PlanetUnlockedToSee()
	{
		return false;
	}

	public void AddUnlockPilot(int pilotId)
	{
	}

	public bool IsPilotUnlocked(int pilotId)
	{
		return false;
	}

	public bool UnlockSkillOnPilot(int pilotId, int skillId, SkillsUnlockedPilot.PilotSkillSlotType skillSlotType)
	{
		return false;
	}

	public WeaponProficiencyData GetOrCreateWeaponProficiency(int weaponId)
	{
		return null;
	}

	public WeaponProficiencyData GetWeaponProficiency(int weaponId)
	{
		return null;
	}

	public PilotData GetPilotData(int pilotId)
	{
		return null;
	}

	public bool CanSpendPilotSkills()
	{
		return false;
	}

	public bool IsSkillUnlockedOnPilot(int pilotId, int skillId, SkillsUnlockedPilot.PilotSkillSlotType skillType)
	{
		return false;
	}

	public void AddUnlockMech(int mechId)
	{
	}

	public void GrantMechStarterLoadout(Mech mech)
	{
	}

	public UnlockItemData GetMechUnlockedData(int skillId)
	{
		return null;
	}

	public bool IsMechUnlocked(int mechId)
	{
		return false;
	}

	public bool IsMechReadyToUse(Mech mech)
	{
		return false;
	}

	public bool SomeItemToSee()
	{
		return false;
	}

	public bool SkillUnlockedToSee()
	{
		return false;
	}

	public bool MicrochipUnlockedToSee()
	{
		return false;
	}

	public bool OverloadUnlockedToSee()
	{
		return false;
	}

	public bool DroneUnlockedToSee()
	{
		return false;
	}

	public bool BaseUnlockedToSee()
	{
		return false;
	}

	public bool BodyUnlockedToSee()
	{
		return false;
	}

	public void MarkItemAsPurchased(int id, ItemToUnlock.UnlockType itemType)
	{
	}

	public void AddUnlockSkill(int weaponId)
	{
	}

	public void SetSkillAsSeen(int skillId)
	{
	}

	public UnlockItemData GetSkillUnlockedData(int skillId)
	{
		return null;
	}

	public bool IsSkillUnlocked(int skillId)
	{
		return false;
	}

	public bool IsSkillReadyToUse(int skillId)
	{
		return false;
	}

	public int SkillUnlockedOrder(int skillId)
	{
		return 0;
	}

	public void AddUnlockMicroChip(int microchipId)
	{
	}

	public UnlockItemData GetMicrochipUnlockedData(int overloadId)
	{
		return null;
	}

	public void SetMicrochipAsSeen(int microchipId)
	{
	}

	public bool IsMicroChipUnlocked(int microchipId)
	{
		return false;
	}

	public bool IsMicroChipReadyToUse(int microchipId)
	{
		return false;
	}

	public int MicrochipUnlockedOrder(int microchipId)
	{
		return 0;
	}

	public void AddUnlockOverload(int overloadId)
	{
	}

	public UnlockItemData GetOverloadUnlockedData(int overloadId)
	{
		return null;
	}

	public void SetOverloadAsSeen(int overloadId)
	{
	}

	public bool IsOverloadUnlocked(int overloadId)
	{
		return false;
	}

	public bool IsOverloadReadyToUse(int overloadId)
	{
		return false;
	}

	public int OverloadUnlockedOrder(int overloadId)
	{
		return 0;
	}

	public void AddUnlockDrone(int droneId)
	{
	}

	public UnlockItemData GetDroneUnlockedData(int droneId)
	{
		return null;
	}

	public void SetDroneAsSeen(int droneId)
	{
	}

	public bool IsDroneUnlocked(int droneId)
	{
		return false;
	}

	public bool IsDroneReadyToUse(int droneId)
	{
		return false;
	}

	public void AddUnlockBase(int baseId)
	{
	}

	public UnlockItemData GetBaseUnlockedData(int baseId)
	{
		return null;
	}

	public void SetBaseAsSeen(int baseId)
	{
	}

	public bool IsBaseUnlocked(int baseId)
	{
		return false;
	}

	public bool IsBaseReadyToUse(int baseId)
	{
		return false;
	}

	public void AddUnlockBody(int bodyId)
	{
	}

	public UnlockItemData GetBodyUnlockedData(int bodyId)
	{
		return null;
	}

	public void SetBodyAsSeen(int bodyId)
	{
	}

	public bool IsBodyUnlocked(int bodyId)
	{
		return false;
	}

	public bool IsBodyReadyToUse(int bodyId)
	{
		return false;
	}

	public bool AchievementCompleted(AchievementsDatabase.AchievementApiName achievementApiName)
	{
		return false;
	}

	public int GetStatsValue(AchievementsDatabase.StatsApiName statsApiName, int extraId = 0)
	{
		return 0;
	}

	public void AddStatsBestValue(AchievementsDatabase.StatsApiName statsApiName, int value, int extraId = 0)
	{
	}

	public void AddStats(AchievementsDatabase.StatsApiName statsApiName, int value, int extraId = 0)
	{
	}

	public void SetStatValue(AchievementsDatabase.StatsApiName statsApiName, int value, int extraId = 0)
	{
	}

	public void SetAchievementCompleted(AchievementsDatabase.AchievementApiName achievementApiName, AchievementsDatabase.StatsApiName statsApiName)
	{
	}

	public HuntsData GetHuntData(int huntId)
	{
		return null;
	}

	public void SetHuntData(int huntId, int runTimes, int completed, TimeSpan timePlayed, int enemiesKilled)
	{
	}

	public bool IsQuestCompleted(int questId)
	{
		return false;
	}

	public int GetCompletedQuestCount(PlanetQuestSet planetSet)
	{
		return 0;
	}

	public bool HasSeenTutorial(TutorialController.Tutorials tutorial)
	{
		return false;
	}

	public void ResetAllStats()
	{
	}

	public void ResetAllAchievements()
	{
	}

	public void ResetAllHuntsData()
	{
	}
}
