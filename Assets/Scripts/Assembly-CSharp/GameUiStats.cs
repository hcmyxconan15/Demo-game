using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class GameUiStats : MonoBehaviour
{
	public float LowLivePercent;

	public ProgressBarPro LifeSlider;

	public CanvasGroup ShieldCanvasGroup;

	public ProgressBarPro ShieldSlider;

	public TextMeshProUGUI TimerText;

	public TextMeshProUGUI LifeBarsText;

	public CanvasGroup LifeDamageImageCanvasGroup;

	public CanvasGroup ShieldDamageImageCanvasGroup;

	public GameObject LifeBarkMarker;

	public float DamageImageSpeed;

	public GameObject RevivalComponent;

	public TextMeshProUGUI RevivalCount;

	public List<CanvasGroup> DashComponent;

	public List<CanvasGroup> DashComponentInGame;

	[Header("Dash stamp animation")]
	[SerializeField]
	private float _dashStampPeakScale;

	[SerializeField]
	private float _dashActivateDuration;

	[SerializeField]
	private float _dashDeactivateDuration;

	[Header("InGameStatusAndLifeBars")]
	public MechPlayerController MechPlayerController;

	private const int DashSlotStateUnset = -1;

	private const int DashSlotStateConsumed = 0;

	private const int DashSlotStateAvailable = 1;

	private readonly List<int> _dashSlotStates;

	private readonly Dictionary<CanvasGroup, Tween> _dashSlotTweens;

	private float _damageScreenTimer;

	private float _currentLife;

	private float _currentShield;

	private bool _lowLiveStatus;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void UpdateLifeBars(int currentLife, int maxLife)
	{
	}

	public void UpdateShiedBars(float currentShield, int maxShield)
	{
	}

	public void FlashScreenOnLifeDamage()
	{
	}

	public void FlashScreenOnShieldDamage()
	{
	}

	public void SetRevivalStatus(int revivalCount)
	{
	}

	public void SetDashStatus(int currentCharges, int maxCharges)
	{
	}

	private int GetDashSlotCount()
	{
		return 0;
	}

	private void UpdateDashSlotPair(int index, int currentCharges, int maxCharges)
	{
	}

	private static bool IsDashSlotUsedInActiveRange(List<CanvasGroup> dashSlots, CanvasGroup dashSlot, int maxCharges, int excludeIndex)
	{
		return false;
	}

	private static CanvasGroup GetDashSlot(List<CanvasGroup> dashSlots, int index)
	{
		return null;
	}

	private void ApplyDashSlotHidden(CanvasGroup dashSlot)
	{
	}

	private static void EnsureDashSlotVisible(CanvasGroup dashSlot)
	{
	}

	private void SetDashSlotInstant(CanvasGroup dashSlot, bool isAvailable)
	{
	}

	private void PlayDashSlotActivateAnimation(CanvasGroup dashSlot)
	{
	}

	private void PlayDashSlotDeactivateAnimation(CanvasGroup dashSlot)
	{
	}

	private void KillDashSlotTween(CanvasGroup dashSlot)
	{
	}

	private void OnDisable()
	{
	}

	private void KillAllDashSlotTweens(List<CanvasGroup> dashSlots)
	{
	}
}
