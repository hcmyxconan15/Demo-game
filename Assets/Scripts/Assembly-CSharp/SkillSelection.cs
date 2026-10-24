using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillSelection : MonoBehaviour
{
	public enum SelectionType
	{
		Banish = 0,
		Reload = 1,
		Skip = 2
	}

	[CompilerGenerated]
	private sealed class _003CReloadingCoroutine_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillSelection _003C_003E4__this;

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
		public _003CReloadingCoroutine_003Ed__144(int _003C_003E1__state)
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
	private sealed class _003CSmoothIntFill_003Ed__143 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int targetValue;

		public TextMeshProUGUI textMeshProUGUI;

		private float _003Celapsed_003E5__2;

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
		public _003CSmoothIntFill_003Ed__143(int _003C_003E1__state)
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

	public float CurrentLoopIncrease;

	public bool IgnoreWeaponsAndOverloadOnLevelOne;

	[Header("ReRoll")]
	public int ReRollCurrentLoop;

	public int ReRollAvailable;

	public int ReRollAvailableFromChip;

	public int ReRollInitialCost;

	[Header("Banish")]
	public int BanishCurrentLoop;

	public int BanishAvailable;

	public int BanishInitialCost;

	[Header("Skip")]
	public int SkipCurrentLoop;

	public int SkipAvailable;

	public int SkipInitialCost;

	public bool AllowToAddLifeOnSkip;

	[Range(0f, 100f)]
	public int HitPointsPercent;

	[Header("Chest price status")]
	public int PaymentsMade;

	public int ChestBasePrice;

	[Header("Ui reference")]
	public Button ReloadButton;

	public Button BanishButton;

	public Button CancelButton;

	public Button SkipButton;

	public TextMeshProUGUI ReloadText;

	public TextMeshProUGUI ReloadPriceText;

	public TextMeshProUGUI BanishText;

	public TextMeshProUGUI BanishPriceText;

	public TextMeshProUGUI SkipText;

	public TextMeshProUGUI SkipTextHitPoints;

	public TextMeshProUGUI SkipPriceText;

	public TextMeshProUGUI PanelText;

	[Header("Tag offer weighting")]
	public bool UseTagOfferWeighting;

	[Tooltip("Logs build tag stacks and every roll-pool item weight to the Console.")]
	public bool LogTagOfferWeightsToConsole;

	public BoxOfSkillsPanel BoxOfSkillsPanel;

	[SerializeField]
	private CanvasGroup SkillSelectionCanvas;

	public List<SkillButton> SkillButtons;

	[SerializeField]
	private CanvasGroup SkillSelectionUpgradeCanvas;

	public List<SkillButton> SkillButtonsFromUpgrade;

	public Color CanBuyColor;

	public Color CantBuyColor;

	[Header("Banish")]
	public bool BanishActive;

	[Header("Panel to level one of the items installed")]
	public UpgradeInstalledPanel UpgradeInstalledPanel;

	private List<int> _weaponsOnDbToSelect;

	private List<int> _weaponsToSelect;

	private List<int> _weaponsToUpgrade;

	private List<int> _weaponsBanished;

	private List<int> _weaponsBanishedByUpgrade;

	private int _randomIndex;

	private List<int> _microchipsOnDbToSelect;

	private List<int> _microchipsToSelect;

	private List<int> _microchipsToUpgrade;

	private List<int> _microchipsBanished;

	private int _randomStatsIndex;

	private List<int> _droneOnDbToSelect;

	private List<int> _droneBanished;

	private int _randomDroneIndex;

	private List<int> _overloadOnDbToSelect;

	private List<int> _overloadsToSelect;

	private List<int> _overloadsToUpgrade;

	private List<int> _overloadBanished;

	private int _randomOverloadIndex;

	private bool _lastRollPoolNewWeaponsOnly;

	private int _lastRollPoolSize;

	private bool _lastRollPoolIncludesBattery;

	private float _lastBatteryRollWeight;

	private string _lastShownChoicesSummary;

	private bool _lastShouldIgnoreWeaponsThisLevel;

	private readonly List<OptionToSelect> _lastLevelUpShownOffers;

	private readonly List<OptionToSelect> _currentScreenShownOffers;

	private int _levelUpsUntilFreshOffer;

	private readonly List<GameTag> _offerAffinityScratch;

	private readonly List<BuildArchetype> _offerArchetypeScratch;

	private int _coinToAdFromBox;

	private void Awake()
	{
	}

	public void SetupPowerUps(PowerUpsDb powerUpsDb)
	{
	}

	public void AddBanishPoint(float value)
	{
	}

	public void AddReRollPoint(float value)
	{
	}

	public void AddSkipPoint(float value)
	{
	}

	public void ActiveBanishSkill()
	{
	}

	public void CancelBanish()
	{
	}

	public void CompleteBanish()
	{
	}

	public void ReloadButtons()
	{
	}

	public void SkipSelection()
	{
	}

	public bool OpenChestByPurchase()
	{
		return false;
	}

	public int GetCurrentBoxPrice()
	{
		return 0;
	}

	public void ContinueAfterBoxUpgradesSelection()
	{
	}

	public void AddSelectedWeapon(int weaponId)
	{
	}

	public void BanishThisWeapon(int weaponId)
	{
	}

	public void BanishThisWeaponByUpgrade(int weaponId)
	{
	}

	public void AddSelectedDrone(int droneId)
	{
	}

	public void BanishThisDrone(int droneId)
	{
	}

	public void BanishThisOverload(int overloadId)
	{
	}

	public void AddSelectedChip(int chipId)
	{
	}

	public void BanishThisChip(int chipId)
	{
	}

	public bool IsWeaponBanished(int weaponId)
	{
		return false;
	}

	public bool IsChipBanished(int chipId)
	{
		return false;
	}

	public bool IsOverloadBanished(int overloadId)
	{
		return false;
	}

	public bool IsDroneBanished(int droneId)
	{
		return false;
	}

	public void AddSelectedGold(int value)
	{
	}

	public void GrantUpgradeBoxEmptyCoins(int coins)
	{
	}

	private void AddCoinsFromPlayer(int coins)
	{
	}

	public void AddSelectedOverload(int overloadId)
	{
	}

	public void ResetFreshOfferRotationForRun()
	{
	}

	public void FillLevelUpChoices(int choiceToAdd, bool isReroll = false)
	{
	}

	private static List<(OptionToSelect, float)> CombineUniqueOfferPools(List<(OptionToSelect, float)> primary, List<(OptionToSelect, float)> extra)
	{
		return null;
	}

	private static void ApplyUnownedOfferWeightBonus(List<(OptionToSelect, float)> pool, RobotParts robotParts, TagOfferWeightConfig config)
	{
	}

	private List<OptionToSelect> PickLevelUpOffers(List<(OptionToSelect, float)> rollPool, RobotParts robotParts, TagOfferWeightConfig config, int choiceToAdd, bool guaranteeTopPick, float topTierRatio)
	{
		return null;
	}

	private static void ShuffleLevelUpOffers(List<OptionToSelect> offers)
	{
	}

	private static void ApplyRecentOfferWeightPenalty(List<(OptionToSelect, float)> pool, IReadOnlyList<OptionToSelect> recentOffers, TagOfferWeightConfig config)
	{
	}

	private static void BackfillMissingLevelUpChoices(List<OptionToSelect> selected, List<(OptionToSelect, float)> fullEligiblePool, IReadOnlyList<OptionToSelect> excludedOffers, int choiceToAdd, bool guaranteeTopPick, float topTierRatio)
	{
	}

	private static List<(OptionToSelect, float)> FilterPoolExcludingOffers(List<(OptionToSelect option, float weight)> pool, IReadOnlyList<OptionToSelect> excludedOffers)
	{
		return null;
	}

	private static bool IsExcludedOffer(OptionToSelect option, IReadOnlyList<OptionToSelect> excludedOffers)
	{
		return false;
	}

	private static bool OptionKeyEquals(OptionToSelect a, OptionToSelect b)
	{
		return false;
	}

	private void StoreCurrentScreenOffers(List<OptionToSelect> shownOffers)
	{
	}

	private void AdvanceFreshOfferRotation(bool isFreshOfferLevel, List<OptionToSelect> shownOffers)
	{
	}

	private string GetMicrochipLevelUpBlockReason(Microchip microchip)
	{
		return null;
	}

	private void ReportLevelUpChoiceShown()
	{
	}

	public void FillUpgradeChoices(int choiceToAdd)
	{
	}

	private void AddUpgradeChoiceMicrochip(int buttonIndex)
	{
	}

	private void AddUpgradeChoiceWeapon(int buttonIndex)
	{
	}

	public void SetPlayerWeaponsAndStatsFromBox(int choiceToAdd)
	{
	}

	public void AddBoxResults(int choiceToAdd, int coinsToAdd)
	{
	}

	private void CheckPanelOptionsButtons()
	{
	}

	private void SetHitPointsRecoverOnSkip()
	{
	}

	private bool CanBePurchaseWithMoney(float value)
	{
		return false;
	}

	private void ConsumeCoinsForButtonOptions(SelectionType selectionType)
	{
	}

	private LevelUpOfferEligibilityContext BuildLevelUpEligibilityContext(bool shouldIgnoreWeaponsThisLevel)
	{
		return null;
	}

	private void AddLevelUpOption(List<(OptionToSelect, float)> target, int typeId, int itemId, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes)
	{
	}

	private float GetLevelUpOfferWeight(int typeId, int itemId, float baseWeight, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, TagOfferWeightConfig config)
	{
		return 0f;
	}

	private static float GetChipRollWeight(List<(OptionToSelect, float)> rollPool, int chipId)
	{
		return 0f;
	}

	private string ExplainMicrochipRequirementsFailure(Microchip microchip)
	{
		return null;
	}

	private bool MeetsItemRequirements(Microchip microchip)
	{
		return false;
	}

	private bool MeetsItemRequirements(Weapon weapon)
	{
		return false;
	}

	private void AddInstalledEvolutionWeaponUpgrades(List<int> weaponsOnDbToSelect, bool shouldIgnoreWeaponsThisLevel, bool applyBanishAndRequirements)
	{
	}

	private bool MeetsItemRequirements(Overload overload)
	{
		return false;
	}

	private void AddButtonWithWeapon(int buttonIndex, int weaponIndex)
	{
	}

	private void AddButtonWithMicrochip(int buttonIndex, int microchipId)
	{
	}

	private void AddButtonWithDrone(int buttonIndex, int droneId)
	{
	}

	private void AddButtonWithOverload(int buttonIndex, int overloadId)
	{
	}

	private void AddButtonGold(int buttonIndex)
	{
	}

	public void ActiveSkillSelectionCanvas(bool active)
	{
	}

	public void ActiveLevelUpRewardsCanvas(bool active)
	{
	}

	public void ActiveSkillSelectionGameObject(bool active)
	{
	}

	public void ActiveSkillSkillSelectionUpgradeGameObject(bool active)
	{
	}

	public void ActiveUpgradeInstalledPanel(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothIntFill_003Ed__143))]
	private IEnumerator SmoothIntFill(int targetValue, TextMeshProUGUI textMeshProUGUI)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReloadingCoroutine_003Ed__144))]
	private IEnumerator ReloadingCoroutine()
	{
		return null;
	}
}
