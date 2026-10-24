using System;
using System.Diagnostics;
using Rewired;
using UnityEngine;
using UnityEngine.Events;

public class InputButtonsController : MonoBehaviour
{
	public enum ControllerGlyphOverride
	{
		Auto = 0,
		ForcePlaystation = 1,
		ForceXbox = 2,
		ForceNintendo = 3,
		ForceGenericGamePad = 4
	}

	public JoystickInput.JoystickType JoystickType;

	public JoystickDb JoystickDb;

	[SerializeField]
	private bool _showControllerDebugOverlayInEditor;

	[Tooltip("Enable/disable all controller debug logs in Unity Editor and development builds.")]
	[SerializeField]
	private bool _enableControllerDebugLogs;

	[Tooltip("Rewired player id used for glyph detection (default 0).")]
	[SerializeField]
	private int _rewiredPlayerId;

	[Tooltip("Optional override for controller glyph set when OS/driver emulation reports wrong hardware type.")]
	[SerializeField]
	private ControllerGlyphOverride _controllerGlyphOverride;

	[Tooltip("Show runtime controller debug overlay in Unity Editor only.")]
	public UnityEvent OnJoystickTypeChanged;

	public static InputButtonsController Instance;

	private Player _rewiredPlayer;

	private string _lastControllerDebugInfo;

	private int _lastDetectedJoystickId;

	private JoystickInput.JoystickType _lastDetectedJoystickType;

	private static readonly Guid GuidSonyDualShock4;

	private static readonly Guid GuidSonyDualSense;

	private static readonly Guid GuidSonyDualShock3;

	private static readonly Guid GuidMicrosoftXbox360;

	private static readonly Guid GuidMicrosoftXboxOne;

	private static readonly Guid GuidNintendoSwitchPro;

	private static readonly Guid GuidSteamController;

	private static readonly string[] SteamDeckNameHints;

	private static readonly string[] SteamInputVirtualNameHints;

	private static readonly string[] PlaystationNameHints;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetJoystick()
	{
	}

	private Joystick ResolvePrimaryJoystick()
	{
		return null;
	}

	private static int GetGlyphDetectionPriority(Joystick joystick)
	{
		return 0;
	}

	private JoystickInput.JoystickType ApplyGlyphOverride(JoystickInput.JoystickType detectedType)
	{
		return JoystickInput.JoystickType.Keyboard;
	}

	private static JoystickInput.JoystickType MapHardwareGuidToJoystickType(Joystick joystick)
	{
		return JoystickInput.JoystickType.Keyboard;
	}

	private void UpdateControllerDebugInfo(Joystick primaryJoystick)
	{
	}

	private static bool IsPlaystationJoystick(Joystick joystick)
	{
		return false;
	}

	private static bool IsXboxJoystick(Joystick joystick)
	{
		return false;
	}

	private static bool IsNintendoJoystick(Joystick joystick)
	{
		return false;
	}

	private static bool IsSteamInputVirtualJoystick(Joystick joystick)
	{
		return false;
	}

	private static bool ContainsAnyHint(string source, string[] hints)
	{
		return false;
	}

	private static bool IsSteamDeckJoystick(Joystick joystick)
	{
		return false;
	}

	private static bool IsSteamDeck()
	{
		return false;
	}

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private static void LogSteamDeckDetection(string joystickName, string deviceModel, bool matchedByName, bool matchedByPlatform)
	{
	}

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	private static void LogControllerDetection(string mappedType, Joystick joystick)
	{
	}

	private static bool CanLogControllerDebug()
	{
		return false;
	}

	private static JoystickInput.JoystickType ResolveKeyboardMouseJoystickType()
	{
		return JoystickInput.JoystickType.Keyboard;
	}

	public Sprite GetButtonSprite(string buttonName)
	{
		return null;
	}
}
