using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Localization;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
	public enum OptionsPanel
	{
		General = 0,
		Keybindings = 1,
		Graphics = 2,
		Language = 3,
		Audio = 4,
		Credits = 5,
		Exit = 6
	}

	[CompilerGenerated]
	private sealed class _003CConfirmResolution_003Ed__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OptionsController _003C_003E4__this;

		public int index;

		private int _003ColdIndex_003E5__2;

		private int _003CnewIndex_003E5__3;

		private float _003Ctimer_003E5__4;

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
		public _003CConfirmResolution_003Ed__147(int _003C_003E1__state)
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

	private const int MinRenderScaleStep = 5;

	private const int MaxRenderScaleStep = 15;

	private const int RenderScaleStepMultiplier = 10;

	private const int UnlimitedFrameRateIndex = 5;

	private const int JoystickControlTypeIndex = 2;

	public const int FullScreenWindowModeIndex = 1;

	private static readonly int[] FrameRateLimitValues;

	public bool Open;

	public TextMeshProUGUI PopUpText;

	public SupportsResolutions CurrentResolution;

	public int CurrentIndexResolution;

	public OptionsPanel CurrentTab;

	public GameObject PopUp;

	public List<GameObject> Tabs;

	public List<MenuNavigation> MenuNavigationOptions;

	public List<OptionTab> OptionsButtons;

	public InOutFromBottom InOutFromBottomComponent;

	public MenuNavigation MenuNavigation;

	public InputDetectionManager InputDetectionManager;

	[Header("General tab")]
	public TMP_Dropdown ControlTypeDropdown;

	public List<GameObject> ControlType;

	[Header("Keybindings")]
	public GameObject SelectControlType;

	public KeyboardRebindController KeyboardRebindController;

	public InputEventChannelSO InputEventChannel;

	[Header("Settings tab")]
	public CustomToggle FullScreenCustomToggle;

	public TMP_Dropdown FullScreenDropdown;

	public TMP_Dropdown MonitorDropdown;

	public TMP_Dropdown ResolutionDropdown;

	public TMP_Dropdown QualityDropdown;

	public TMP_Dropdown LanguageDropdown;

	[Header("Shadows")]
	public Light MainSceneLight;

	public CustomToggle ShadowCustomToggle;

	[Header("Vsync")]
	public CustomToggle VsyncCustomToggle;

	[Header("Vignette")]
	public CustomToggle VignetteCustomToggle;

	[Header("ShowFPS")]
	public CustomToggle ShowFpsCustomToggle;

	[Header("FrameRate")]
	public TextMeshProUGUI FrameRateText;

	public Slider FrameRateSlider;

	[Header("Brightness")]
	public TextMeshProUGUI BrightnessText;

	public Slider BrightnessSlider;

	[Header("RenderScale")]
	public TextMeshProUGUI RenderScaleText;

	public Slider RenderScaleSlider;

	[Header("Resolutions")]
	public List<SupportsResolutions> Resolutions;

	public GameObject ConfirmResolutionPanel;

	public MenuNavigation ConfirmResolutionPanelMenuNavigation;

	public TextMeshProUGUI TimerText;

	public TextMeshProUGUI ResolutionAlertPanelText;

	[Header("Global volume effects")]
	public GlobalVolumeController GlobalVolumeController;

	public UniversalRenderPipelineAsset UniversalRenderPipelinePerformant;

	public UniversalRenderPipelineAsset UniversalRenderPipelineBalance;

	public UniversalRenderPipelineAsset UniversalRenderPipelineUltra;

	public UnityEvent ExitOptionEvent;

	public static OptionsController Instance;

	private bool _confirmation;

	public CustomToggle CustomToggleBlood;

	public CustomToggle CustomToggleParts;

	public CustomToggle CustomToggleDamageNumbers;

	public CustomToggle CustomToggleCoinMovement;

	public CustomToggle CustomToggleShake;

	public CustomToggle CustomToggleEnemyCameraFocus;

	public CustomToggle CustomToggleVibrations;

	public CustomToggle CustomToggleLifeBars;

	public CustomToggle CustomToggleSpeedUpBoxSequence;

	public CustomToggle CustomToggleAnalytics;

	private readonly List<DisplayInfo> _displayLayout;

	[Header("Audio tab")]
	public CustomToggle CustomToggleMasterVolume;

	public Slider SoundSlider;

	public Slider FxSlider;

	public AudioMixer MusicAudioMixer;

	public AudioMixer SoundFxAudioMixer;

	private float _currentMusicVolumeValue;

	private float _currentSoundFxVolumeValue;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSelectedLocaleChanged(Locale locale)
	{
	}

	private void RefreshLocalizedOptionTexts()
	{
	}

	private void Start()
	{
	}

	public static void ApplySavedDisplaySettings()
	{
	}

	private void OnInputDeviceChanged(bool isUsingJoystick)
	{
	}

	public void LoadCurrentSettings()
	{
	}

	private void LoadCurrentLanguage()
	{
	}

	private void Update()
	{
	}

	private void HandleBackOneLevel()
	{
	}

	public bool HasInnerNavigationFocus()
	{
		return false;
	}

	private ManageSliders GetActiveSlider()
	{
		return null;
	}

	private DropdownController GetOpenDropdown()
	{
		return null;
	}

	private void ResetInnerNavigationState()
	{
	}

	public void OpenOptions(bool open)
	{
	}

	public void ShowTab(OptionsPanel optionType)
	{
	}

	private void RefreshKeyboardRebindLabels()
	{
	}

	public void RefreshKeybindingsDeviceLayout()
	{
	}

	private void RefreshKeybindingsNavigationFocus()
	{
	}

	public void ResetGraphicConfig()
	{
	}

	public void QuitApp()
	{
	}

	public void ResetPlayerDataAndReloadFromMainMenu()
	{
	}

	private void LoadGeneralSettings()
	{
	}

	public void LoadBloodSettings()
	{
	}

	public void LoadPartsSettings()
	{
	}

	public void LoadDamageNumbersSettings()
	{
	}

	public void LoadCoinMovementSettings()
	{
	}

	public void LoadShakeSettings()
	{
	}

	public void LoadEnemyCameraFocusSettings()
	{
	}

	public void LoadVibrationsSettings()
	{
	}

	public void LoadLifeBarsSettings()
	{
	}

	public void LoadSpeedUpBoxSequenceSettings()
	{
	}

	public void LoadAnalyticsSettings()
	{
	}

	public void SetBlood(bool isEnabled)
	{
	}

	public void SetParts(bool isEnabled)
	{
	}

	public void SetDamageNumbers(bool isEnabled)
	{
	}

	public void SetCoinMovement(bool isEnabled)
	{
	}

	public void SetCameraShake(bool isEnabled)
	{
	}

	public void SetEnemyCameraFocus(bool isEnabled)
	{
	}

	public void SetVibration(bool isEnabled)
	{
	}

	public void SetLifeBars(bool isEnabled)
	{
	}

	public void SetSpeedUpBoxSequence(bool isEnabled)
	{
	}

	public void SetAnalytics(bool isEnabled)
	{
	}

	private static void ApplyLifeBarsSetting(bool isEnabled)
	{
	}

	private static void ReportSettingChanged(string key, string oldValue, string newValue)
	{
	}

	public void LoadControlTypeSettings()
	{
	}

	private void FillControlTypeDropdown()
	{
	}

	public void SetControlType(int index)
	{
	}

	public void LoadFrameRate()
	{
	}

	public void SetFrameRate(float frameRate)
	{
	}

	private void UpdateFrameRateText(int index)
	{
	}

	private static string GetFrameRateDisplayValue(int index)
	{
		return null;
	}

	private static int ResolveFrameRateIndex(int savedValue)
	{
		return 0;
	}

	private static void ApplyFrameRateLimit(int index)
	{
	}

	public void LoadBrightness()
	{
	}

	public void SetBrightness(float brightness)
	{
	}

	public void LoadRenderScale()
	{
	}

	public void SetRenderScale(float scale)
	{
	}

	private void ApplyRenderScale(float scalePercent)
	{
	}

	public void LoadVsyncSettings()
	{
	}

	public void SetVsync(bool isEnabled)
	{
	}

	public void LoadVignetteSettings()
	{
	}

	public void SetVignette(bool isEnabled)
	{
	}

	public void LoadShowFpsSettings()
	{
	}

	public void SetShowFps(bool isEnabled)
	{
	}

	public void LoadFullScreenSettings()
	{
	}

	private void FillFullScreenDropdown()
	{
	}

	public void SetFullScreen(bool fullScreen)
	{
	}

	public void LoadScreenResolution()
	{
	}

	public void SetScreenResolutionByUser(int index)
	{
	}

	public void SetScreenResolution(int index)
	{
	}

	public void SetFullScreenMode(int index)
	{
	}

	public void LoadMonitorSettings()
	{
	}

	private void FillMonitorDropdown()
	{
	}

	public void SetTargetMonitor(int monitorIndex)
	{
	}

	public void LoadQualitySettings()
	{
	}

	private void FillQualityDropdown()
	{
	}

	public void SetQualitySettings(int index)
	{
	}

	public void Confirm(bool confirm)
	{
	}

	public void LoadShadowsSettings()
	{
	}

	public void ActiveShadow(bool activeShadow)
	{
	}

	[IteratorStateMachine(typeof(_003CConfirmResolution_003Ed__147))]
	private IEnumerator ConfirmResolution(int index)
	{
		return null;
	}

	public void LoadSoundsSettings()
	{
	}

	public void OnChangeSliderMusic(float value)
	{
	}

	public void OnChangeSliderSoundFx(float value)
	{
	}

	public void MasterVolume(bool active)
	{
	}

	private float ClampSliderValue(Slider slider, float value)
	{
		return 0f;
	}

	private void GetSupportedResolutions()
	{
	}

	private static List<SupportsResolutions> BuildSupportedResolutionsList()
	{
		return null;
	}

	private static void AddResolutionIfMissing(List<SupportsResolutions> resolutions, HashSet<string> uniqueResolutions, int width, int height)
	{
	}

	private int ClampResolutionIndex(int index)
	{
		return 0;
	}

	private static int ClampResolutionIndex(int index, List<SupportsResolutions> resolutions)
	{
		return 0;
	}

	private static int FindCurrentResolutionIndex(List<SupportsResolutions> resolutions)
	{
		return 0;
	}

	private static int ClampFullScreenModeIndex(int index)
	{
		return 0;
	}

	private static FullScreenMode GetFullScreenMode(int index)
	{
		return FullScreenMode.ExclusiveFullScreen;
	}

	private static void ApplyResolutionIfNeeded(int width, int height, FullScreenMode mode)
	{
	}

	private void FillDropDownResolutionsOptions()
	{
	}

	private void FillDropDownLanguageOptions()
	{
	}
}
