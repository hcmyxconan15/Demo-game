using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class UnityAnalyticsController : MonoBehaviour
{
	private enum AnalyticsLogCategory
	{
		GamePlay = 0,
		Ftue = 1,
		Session = 2
	}

	private struct PendingFtueEvent
	{
		public FtueStepEvent Event;

		public int StepIndex;

		public string StepName;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CBeginDataCollection_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public UnityAnalyticsController _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public bool ConsentGiven;

	[Tooltip("If true, every analytics send is mirrored to the Unity console with a colored tag.\nFTUE = blue, SessionStart/SessionEnd = red, all others = green.")]
	[SerializeField]
	private bool LogEventsToConsole;

	[TextArea(10, 20)]
	public string FTUEText;

	public static UnityAnalyticsController Instance;

	private const string LogColorGamePlay = "#22c55e";

	private const string LogColorFtue = "#3b82f6";

	private const string LogColorSession = "#ef4444";

	private float _bossFightStartGameTime;

	private int _shopCoinsAtOpen;

	private int _shopItemsBought;

	private int _shopCoinsSpent;

	private readonly Dictionary<string, int> _coinsEarnedBySource;

	private readonly Dictionary<string, int> _coinsSpentBySource;

	private string _sessionId;

	private string _runId;

	private float _sessionStartTime;

	private int _sessionRunsStarted;

	private bool _sessionEnded;

	private AnalyticsContext _context;

	private bool _analyticsReady;

	private bool _startingCollection;

	private readonly List<PendingFtueEvent> _pendingFtueEvents;

	private void Awake()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool paused)
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void Start()
	{
	}

	public void GiveConsent(bool consent)
	{
	}

	[AsyncStateMachine(typeof(_003CBeginDataCollection_003Ed__30))]
	private void BeginDataCollection()
	{
	}

	private void StopDataCollection()
	{
	}

	public void ResetRunAccumulators()
	{
	}

	public void SetContext(int level, int robotId, string weapons, string overload, string chips)
	{
	}

	public void ClearRunId()
	{
	}

	public void RunCompleted(string result)
	{
	}

	public void PlayerDeath(bool revivalAvailable)
	{
	}

	public void RevivalUsed(int revivalsRemaining)
	{
	}

	public void LevelUpChoiceShown(string option1Type, int option1Id, string option2Type, int option2Id, string option3Type, int option3Id)
	{
	}

	public void LevelUpChoicePicked(string pickedType, int pickedId, int slotIndex, int itemLevelBefore)
	{
	}

	public void LevelUpChoiceModified(string action, int coinsSpent, bool usedFreeCharge)
	{
	}

	public void WeaponEvolved(int fromWeaponId, int toWeaponId)
	{
	}

	public void ItemShopOpened(int nodeIndex)
	{
	}

	public void ItemShopPurchase(string itemType, int itemId, int itemLevelBefore, int coinsSpent)
	{
	}

	public void ItemShopReroll(int coinsSpent)
	{
	}

	public void ItemShopClosed()
	{
	}

	public void MapNodeSelected(string nodeType, int nodeLevel, int nodeIndex, int nodesClimbedSoFar)
	{
	}

	public void BossEncountered(int bossId)
	{
	}

	public void BossDefeated(int bossId)
	{
	}

	public void UnknownEventTriggered(int eventId, int responseChoice, string outcome)
	{
	}

	public void RecordCoinsEarned(int amount, string source)
	{
	}

	public void RecordCoinsSpent(int amount, string source)
	{
	}

	private void AccumulateCoinsSpent(int amount, string source)
	{
	}

	private void SendEconomyRunBreakdown()
	{
	}

	public void SkillPointsEarned(int amount, int balanceAfter, int nodesClimbed)
	{
	}

	public void SkillPointsSpent(int amount, string spentOn, int targetId, string targetType, int balanceAfter)
	{
	}

	public void ItemUnlocked(int itemId, string itemType, string unlockMethod)
	{
	}

	public void MechSelected(int mechId, int previousId)
	{
	}

	public void PilotSelected(int pilotId, int previousId)
	{
	}

	public void PlanetSelected(int planetId, int previousId)
	{
	}

	public void PilotLevelUp(int pilotId, int newLevel)
	{
	}

	public void PowerUpUpgraded(int powerUpId, int newLevel, int cost, string source)
	{
	}

	public void BestScoreUpdated(int score, int previousBest)
	{
	}

	public void SessionStart()
	{
	}

	public void SessionEnd()
	{
	}

	private static string GetCanonicalPlatform()
	{
		return null;
	}

	private static string GetAndroidCanonicalPlatform()
	{
		return null;
	}

	private static bool IsAmazonAndroid()
	{
		return false;
	}

	private static string GetIosCanonicalPlatformForIphoneOs()
	{
		return null;
	}

	private static string GetWindowsUniversalCanonicalPlatform()
	{
		return null;
	}

	public void SettingsSnapshot()
	{
	}

	public void SettingChanged(string settingKey, string oldValue, string newValue)
	{
	}

	public void SaveLoadFailed(string operation, string errorMessage)
	{
	}

	public void SendFtueEvent(FtueStep step, string gameStatus = null)
	{
	}

	private void SendFtueEvent(string stepName, int stepIndex, string gameStatus = null)
	{
	}

	private void QueuePendingFtueEvent(FtueStepEvent evt, int stepIndex, string stepName)
	{
	}

	private void FlushPendingFtueEvents()
	{
	}

	private void RecordFtueStep(FtueStepEvent evt, int stepIndex, string stepName)
	{
	}

	private void RefreshGameplayContextIfAvailable()
	{
	}

	private void RefreshAnalyticsContextFromSaveFallback()
	{
	}

	private static int GetPilotLevelForAnalytics(DataUser save)
	{
		return 0;
	}

	private static string FormatWeaponsFromMechSave(DataUser save)
	{
		return null;
	}

	private void SendEventWithContext(GamePlayBaseEvent evt)
	{
	}

	private void LogAndRecord(LoggableEvent evt, AnalyticsLogCategory category)
	{
	}

	private void FlushEvents()
	{
	}
}
