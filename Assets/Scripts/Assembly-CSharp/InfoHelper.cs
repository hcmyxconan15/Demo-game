using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class InfoHelper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAvoidActivation_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InfoHelper _003C_003E4__this;

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
		public _003CAvoidActivation_003Ed__55(int _003C_003E1__state)
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

	public bool AvoidUpdatePosition;

	public CanvasGroup CanvasGroup;

	public RectTransform MainCanvas;

	public RectTransform ComponentRectRectTransform;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI InfoText;

	[Header("Weapon settings")]
	public GameObject WeaponInfoComponent;

	public TextMeshProUGUI WeaponPower;

	public TextMeshProUGUI WeaponMagazine;

	public TextMeshProUGUI WeaponReloadTime;

	public TextMeshProUGUI WeaponFireRate;

	public TextMeshProUGUI WeaponActiveTime;

	public List<TextMeshProUGUI> StatusToApply;

	public Color ColorPlus;

	public Color ColorPhysical;

	public Color ColorEnergy;

	public Color ColorStatusWeak;

	public Color ColorStatusBurn;

	public Color ColorStatusShock;

	public Color ColorStatusMark;

	private Vector2 _anchoredPosition;

	public const string TagColorSiege = "E65100";

	private bool _avoidActivation;

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void ShowWeaponInfo(WeaponJoin weaponJoin)
	{
	}

	public void ShowWeaponInfo(Weapon weaponToShow, int currentLevel)
	{
	}

	public void ShowWeaponInfoNotShowLevel(Weapon weaponToShow)
	{
	}

	public void ShowDroneInfo(DroneStats drone, WeaponJoin weaponJoin)
	{
	}

	public void ShowDroneInfoNoWeaponJoin(DroneStats drone, int level = 1)
	{
	}

	private void ShowCollectorDroneInfo(DroneStats drone, int level)
	{
	}

	public void ShowMicrochipInfo(Microchip microchip, int level)
	{
	}

	public static string FormatStatIncrease(StatToIncrease.StatIncreaseType statsType, float value, Color colorPlus)
	{
		return null;
	}

	public static void GetStatPreviewLabel(StatToIncrease.StatIncreaseType statsType, out string nameKey, out bool isPercent)
	{
		nameKey = null;
		isPercent = default;
	}

	public static string FormatMicrochipStats(Microchip microchip, int level, Color colorPlus)
	{
		return null;
	}

	public static string FormatDroneDescription(DroneStats drone, int currentLevel, Color plusColor)
	{
		return null;
	}

	public void ShowOverloadInfo(OverloadInstalled overloadInstalled)
	{
	}

	public string OverloadDescriptionInfo(OverloadInstalled overloadInstalled)
	{
		return null;
	}

	public string OverloadDescriptionInfo(Overload overload, int level)
	{
		return null;
	}

	public static string FormatOverloadDescription(Overload overload, int level, Color colorPlus, Color colorPhysical, Color colorEnergy, bool showUpgradeHints = false)
	{
		return null;
	}

	public void ActiveInfo(bool active)
	{
	}

	public void SetInfoText(string nameKey, string infoKey)
	{
	}

	public void SetInfoText(string nameKey)
	{
	}

	private BulletType GetResolvedBullet(Weapon weapon)
	{
		return null;
	}

	private string FormatWeaponDescription(Weapon weapon)
	{
		return null;
	}

	private void SetWeaponsStats(WeaponJoin weapon, int weaponLevel)
	{
	}

	private void SetWeaponsStats(Weapon weapon, int weaponLevel)
	{
	}

	private string FormatWeaponPowerText(int baseDamage, BulletType.BulletClassType bulletClassType, BulletType.TypeOfBullet typeOfBullet, int siegeDamagePercent = 0)
	{
		return null;
	}

	private void SetOverloadStats(OverloadInstalled overloadInstalled)
	{
	}

	private void SetStatusToApply(float onWeak, float onShock, float onFire, float onMark, int onMarkCriticalChanceBonus)
	{
	}

	private static void SetStatInfoKey(TextMeshProUGUI slot, string infoKey)
	{
	}

	private static void SetStatusSlot(TextMeshProUGUI slot, bool active, Color color, string wordKey, string valueText, string infoKey)
	{
	}

	private static ShowSimpleInfo GetOrAddShowSimpleInfo(TextMeshProUGUI slot)
	{
		return null;
	}

	private void ActiveCanvas(bool active)
	{
	}

	public void AvoidActivationByTime()
	{
	}

	[IteratorStateMachine(typeof(_003CAvoidActivation_003Ed__55))]
	private IEnumerator AvoidActivation()
	{
		return null;
	}
}
