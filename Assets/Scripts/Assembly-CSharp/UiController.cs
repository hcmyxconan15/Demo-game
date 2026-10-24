using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UiController : MonoBehaviour
{
	[Serializable]
	public struct QueuedBoxReward
	{
		public int CoinsToAdd;

		public int MinItemsToAdd;

		public int MaxItemsToAdd;

		public DropBox.BoxShape BoxShape;
	}

	[CompilerGenerated]
	private sealed class _003COpenBoxPanelCoroutine_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

		private QueuedBoxReward _003CqueuedBox_003E5__2;

		private BoxOfSkillsPanel _003CboxPanel_003E5__3;

		private int _003CchoiceToAdd_003E5__4;

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
		public _003COpenBoxPanelCoroutine_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003COpenEvolveWeaponCoroutine_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

		private int _003CweaponId_003E5__2;

		private int _003CevolutionId_003E5__3;

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
		public _003COpenEvolveWeaponCoroutine_003Ed__85(int _003C_003E1__state)
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
	private sealed class _003COpenLevelUpPanelCoroutine_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

		private bool _003CexistChipTutorial_003E5__2;

		private bool _003CexistWeaponTutorial_003E5__3;

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
		public _003COpenLevelUpPanelCoroutine_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003COpenLevelUpPowerUpSelectionPanelCoroutine_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

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
		public _003COpenLevelUpPowerUpSelectionPanelCoroutine_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CPresentEmptyUpgradeBoxCoins_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

		public BoxOfSkillsPanel boxPanel;

		public int coinsIfEmpty;

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
		public _003CPresentEmptyUpgradeBoxCoins_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CPresentSelectSimpleUpgradeBox_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiController _003C_003E4__this;

		private int _003CcoinsIfEmpty_003E5__2;

		private BoxOfSkillsPanel _003CboxPanel_003E5__3;

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
		public _003CPresentSelectSimpleUpgradeBox_003Ed__77(int _003C_003E1__state)
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

	public static UiController Instance;

	public bool LevelUpPanelOpen;

	public bool BoxPanelOpen;

	public bool UpgradePanel;

	public bool EvolvePanel;

	public CanvasGroup FullCanvas;

	public CanvasGroup GamePlayCanvasMarkers;

	public GameObject DarkBackground;

	public UiXpLevelController UiXpLevelController;

	public SkillSelection SkillSelection;

	public ItemShop ItemShop;

	public GameUiStats GameUiStats;

	public UiRobotStats UiRobotStats;

	public WeaponDamageResult WeaponDamageResult;

	public CurrentWeaponsUi CurrentWeaponsUi;

	public PowerSourceController PowerSourceController;

	public GameControllers GameControllers;

	public GameOverUi GameOverUi;

	public GameObject PauseButtons;

	public OptionsController OptionsController;

	public MainMenuJoystickGamePlay MainMenuJoystickGamePlay;

	public SimpleActiveQuestUi SimpleActiveQuestUi;

	public EvolveWeapon EvolveWeapon;

	public AvatarInfo AvatarInfo;

	public List<int> QueueLevelUp;

	public List<QueuedBoxReward> QueueBoxRewards;

	public List<int> QueueSelectUpgradeRewards;

	private List<int> _selectUpgradeEmptyCoins;

	public List<CanvasGroup> CanvasGroupsToHide;

	public bool UiOnMainMenu;

	private bool _pauseGameByInput;

	private bool _rewardPanelActive;

	private bool _levelUpSelectionMade;

	private bool _boxSelectionMade;

	private bool _openChestMade;

	private bool _upgradeSelectionMade;

	private Coroutine _levelUpCoroutine;

	private Coroutine _boxCoroutine;

	private Coroutine _upgradeCoroutine;

	private Coroutine _evolveCoroutine;

	[HideInInspector]
	public float DelayToInput;

	public bool PauseMenuOpen => false;

	public bool AutoOpenSelectUpgradeBox { get; private set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetMovementType(MovementController.MovementType movementType)
	{
	}

	public void SetAvatarInfo()
	{
	}

	public void ActiveMainCanvas(bool active)
	{
	}

	public void PauseGameByInput()
	{
	}

	public void ClearPauseMenuOverlay()
	{
	}

	private bool BlocksOpeningPause()
	{
		return false;
	}

	public void RestartGame()
	{
	}

	public void LoadMainMenu()
	{
	}

	public void QuitGame()
	{
	}

	public void ClosePowerUpPanel()
	{
	}

	public bool CanOfferGameplayRewardPanels()
	{
		return false;
	}

	public void CloseBoxAfterContinuePanel()
	{
	}

	public void OpenLevelUpPanel()
	{
	}

	public void OpenBoxPanel(int coinsToAdd, int minItemsToAdd, int maxItemsToAdd, DropBox.BoxShape boxShape)
	{
	}

	public void OpenEvolveWeaponPanel()
	{
	}

	public bool IsWeaponEvolutionPending()
	{
		return false;
	}

	public void OpenUpgradeSelectionPanel()
	{
	}

	public void OpenSelectSimpleUpgradeBox(int coinsIfEmpty)
	{
	}

	public void OpenBox()
	{
	}

	public void OpenEvolveBox()
	{
	}

	public bool UiIsOpen()
	{
		return false;
	}

	public bool HasPendingRewardPanels()
	{
		return false;
	}

	private bool RewardSlotBusy()
	{
		return false;
	}

	private void TryResumeGameAfterRewards()
	{
	}

	public void HideUiDuringPopUpStats(bool hide)
	{
	}

	[IteratorStateMachine(typeof(_003COpenLevelUpPanelCoroutine_003Ed__74))]
	private IEnumerator OpenLevelUpPanelCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenBoxPanelCoroutine_003Ed__75))]
	private IEnumerator OpenBoxPanelCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenLevelUpPowerUpSelectionPanelCoroutine_003Ed__76))]
	private IEnumerator OpenLevelUpPowerUpSelectionPanelCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPresentSelectSimpleUpgradeBox_003Ed__77))]
	private IEnumerator PresentSelectSimpleUpgradeBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPresentEmptyUpgradeBoxCoins_003Ed__78))]
	private IEnumerator PresentEmptyUpgradeBoxCoins(BoxOfSkillsPanel boxPanel, int coinsIfEmpty)
	{
		return null;
	}

	private void ClearQueuedSelectUpgrades()
	{
	}

	private void DequeueSelectUpgradeReward()
	{
	}

	public List<int> WeaponsToEvolve()
	{
		return null;
	}

	private bool EvolveRequirementsComplete(Weapon weapon)
	{
		return false;
	}

	private bool HasReadyEvolution(Weapon weapon)
	{
		return false;
	}

	private void EvolutionSelected(List<int> weaponsToEvolveList, out int weaponId, out int evolutionId)
	{
		weaponId = default;
		evolutionId = default;
	}

	[IteratorStateMachine(typeof(_003COpenEvolveWeaponCoroutine_003Ed__85))]
	private IEnumerator OpenEvolveWeaponCoroutine()
	{
		return null;
	}
}
