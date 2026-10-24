using Rewired;
using UnityEngine;

public abstract class MainMenuJoystickBase : MonoBehaviour
{
	public enum PanelActive
	{
		PauseMenu = 0,
		Options = 1,
		LevelUp = 2,
		BoxCollection = 3,
		UpgradeSkills = 4,
		Shop = 5,
		EventPanel = 6,
		MapPanel = 7,
		PowerSourcePanel = 8,
		ConfirmExit = 9,
		GamePlay = 10,
		EndPanel = 11,
		UnlockPanel = 12,
		UpgradePanel = 13,
		InitialPanel = 14,
		MainMenu = 15,
		Tutorial = 16,
		MainMenuMap = 17,
		MainMenuHangar = 18,
		MainMenuSkillTree = 19,
		MainMenuUnlockItems = 20,
		MainMenuNickName = 21,
		MainMenuPilots = 22,
		MainMenuConfirmResetData = 23,
		TutorialChip = 24,
		TutorialXp = 25,
		TutorialSkillsWork = 26,
		TutorialEvolution = 27,
		MaiManuParts = 28,
		ItemsInfoGameplay = 29,
		AnalyticsConsent = 30
	}

	public Player Player;

	public PanelActive CurrentActiveStatus;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public abstract void InitJoystick();

	public abstract void ChangeToJoystickPanel();
}
