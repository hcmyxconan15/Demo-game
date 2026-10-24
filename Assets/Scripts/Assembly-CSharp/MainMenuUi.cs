using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuUi : MonoBehaviour
{
	public enum MainMenuStatus
	{
		MainScreen = 0,
		Upgrade = 1,
		MapSection = 2,
		Options = 3,
		SkillTree = 4,
		Hangar = 5,
		ItemsUnlocks = 6,
		StartPanel = 7,
		PilotSection = 8,
		Parts = 9
	}

	[CompilerGenerated]
	private sealed class _003CShowHideButtons_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuUi _003C_003E4__this;

		public bool hide;

		private List<InOutFromLeft>.Enumerator _003C_003E7__wrap1;

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
		public _003CShowHideButtons_003Ed__84(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShowHideButtonsHangar_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuUi _003C_003E4__this;

		public bool hide;

		private List<InOutFromLeft>.Enumerator _003C_003E7__wrap1;

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
		public _003CShowHideButtonsHangar_003Ed__85(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CStart_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuUi _003C_003E4__this;

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
		public _003CStart_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CStartGameScene_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuUi _003C_003E4__this;

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
		public _003CStartGameScene_003Ed__86(int _003C_003E1__state)
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

	public MainMenuStatus CurrentMenuStatus;

	[Header("Skill tree points")]
	public Transform CurrencyTransform;

	public CanvasGroup CurrencyCanvasGroup;

	public NotCurrencyFeedback SkillsCurrencyFeedback;

	public TextMeshProUGUI SkillsPoints;

	public Transform SkillsPointsImage;

	[Header("Diamonds points")]
	public CanvasGroup DiamondsCanvasGroup;

	public NotCurrencyFeedback DiamondsCurrencyFeedback;

	public TextMeshProUGUI DiamondsPoints;

	public Transform DiamondsPointsImage;

	public TextMeshProUGUI RobotName;

	public GameObject HangarAlert;

	public GameObject LockedAlert;

	public GameObject LockedAlertNormalLock;

	public GameObject NewRobotAlert;

	public CanvasGroup ChangeRobots;

	public CanvasGroup RobotSelectionButtons;

	public MechPlayerController MechPlayerController;

	public UiController UiController;

	public CurrentMechParts CurrentMechParts;

	public SkillTreeManager SkillTreeManager;

	public PlanetsUiController PlanetsUiController;

	public PilotUiController PilotUiController;

	public PartsUiController PartsUiController;

	public UnlockItemsManager UnlockItemsManager;

	public GlobalVolumeController GlobalVolumeController;

	public CinemachineVirtualCamera PlanetVirtualCamera;

	public CinemachineVirtualCamera HangarVirtualCamera;

	public CinemachineVirtualCamera PilotVirtualCamera;

	[Header("Helpers Tutorial")]
	public BlockButtonOnTutorial BlockButtonOnTutorial;

	public Button BackButton;

	public Button BackButtonToHangar;

	public List<Button> MenuButtons;

	public List<InOutFromLeft> MoveButtonScript;

	public List<Button> HangarButtons;

	public List<InOutFromLeft> HangarMoveButtonScript;

	public static MainMenuUi Instance;

	public List<GameObject> MainMenuDemoButtons;

	public CanvasGroup VersionOnMainMenu;

	private bool _loadingSceneTrigger;

	private bool _initialButtonsBlock;

	[HideInInspector]
	public bool _hangarButtonsBlock;

	public UnityEvent OnStartGame;

	private Coroutine _coroutine;

	private Coroutine _coroutineHangarButtons;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__45))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private static void ClearActiveMenuNavigationSelection()
	{
	}

	public void SetBackButtonStatus()
	{
	}

	public void StartGame()
	{
	}

	public void ShowStartPanel()
	{
	}

	public void ShowPlanetsSelection(bool showPlanetsSelection)
	{
	}

	public void ShowPilotSelection(bool showPilotSelection)
	{
	}

	public void OpenMainScreen()
	{
	}

	public void OpenHangar()
	{
	}

	public void OpenSkillTreePanel()
	{
	}

	public void OpenUnlockItemsPanel()
	{
	}

	public void OpenPartsSelection()
	{
	}

	public void OpenOptions()
	{
	}

	public void UpdateCurrentMechWeapon()
	{
	}

	public void NextRobot()
	{
	}

	public void PrevRobot()
	{
	}

	public void UpdateSkillsPoints()
	{
	}

	public void UpdateDiamondsPoints()
	{
	}

	public void HideMainMenuButtons(bool hide)
	{
	}

	public void HideHangarMenuButtons(bool hide)
	{
	}

	private void SetRobotSelectionButtonsVisible(bool visible)
	{
	}

	public void ShowMainMenuDemoButtons(bool show)
	{
	}

	public void ShowCurrency(bool show)
	{
	}

	public void RefreshSelectedMechUiState()
	{
	}

	private void CheckForAlerts()
	{
	}

	private void CheckNewRobotAlert()
	{
	}

	private bool NewRobotUnlockedToSee()
	{
		return false;
	}

	private void SetNewTagOnRobotToFalse(int mechId)
	{
	}

	private void SetSelectedRobot(int id)
	{
	}

	private int GetValidMechId(int mechId)
	{
		return 0;
	}

	private bool IsMechReadyToUse(int mechId)
	{
		return false;
	}

	private void UpdateMechLockAlerts(int mechId)
	{
	}

	private void UpdateMechLockAlerts(Mech mech)
	{
	}

	private void SetLockMaterial(bool lockMaterial)
	{
	}

	private void UpdateValidRobot()
	{
	}

	private bool ButtonsOnMovement()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CShowHideButtons_003Ed__84))]
	private IEnumerator ShowHideButtons(bool hide)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHideButtonsHangar_003Ed__85))]
	private IEnumerator ShowHideButtonsHangar(bool hide)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartGameScene_003Ed__86))]
	private IEnumerator StartGameScene()
	{
		return null;
	}

	public void RestoreAfterFailedLoad()
	{
	}
}
