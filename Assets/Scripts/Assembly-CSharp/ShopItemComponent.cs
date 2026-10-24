using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopItemComponent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CIdlePulseAnimation_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopItemComponent _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private float _003CscaleAmount_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CIdlePulseAnimation_003Ed__52(int _003C_003E1__state)
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

	public int Id;

	public int ItemLevel;

	public int BasePrice;

	public int CurrentPrice;

	public bool DoNotShowToolTip;

	public ItemToUnlock.UnlockType TypeOfItem;

	public GameObject LockedMark;

	public GameObject NewItemText;

	public GameObject Discount;

	public TextMeshProUGUI DiscountText;

	public GameObject SelectedObject;

	public Image Icon;

	public Image SlotImage;

	public Button Button;

	public Sprite WeaponSlotImage;

	public Sprite MicrochipSlotImage;

	public Sprite OverloadSlotImage;

	public Sprite NotSlotImage;

	public Weapon.SlotType WeaponSlotType;

	public GameObject ToPurchaseObject;

	public TextMeshProUGUI PriceToPurchaseText;

	public TextMeshProUGUI NotMoreSlotText;

	public PlaySoundButton PlaySoundButton;

	private Weapon _weaponReference;

	private Overload _overloadReference;

	private Microchip _microchipReference;

	private DroneStats _droneStatsReference;

	public ItemShop ItemShop;

	public UpgradeInstalledPanel UpgradePanel;

	public Color NotEnoughColor;

	private Vector3 _slotImageOriginalScale;

	private Coroutine _idleAnimCoroutine;

	private Color _originalTextColor;

	private int _discountPercent;

	private void Awake()
	{
	}

	public void SetWeapon(Weapon weapon, int weaponLevel)
	{
	}

	public void SetOverload(Overload overload, int overloadLevel)
	{
	}

	public void SetChip(Microchip microchip, int chipLevel)
	{
	}

	public void SetDrone(DroneStats droneStats, int droneLevel)
	{
	}

	private void SetBaseStatus(bool isNewItem)
	{
	}

	public void SelectThis()
	{
	}

	public void DeselectThisItem()
	{
	}

	public void HidePrice()
	{
	}

	public void ShowSelectedInfo()
	{
	}

	private int GetCurrentPrice(int basePrice)
	{
		return 0;
	}

	public void SetDiscount(int discountPercent)
	{
	}

	public void SetupItemPrice()
	{
	}

	public void SetCanBuy(bool canBuy, bool canBePlace)
	{
	}

	public void BuyThisItem()
	{
	}

	public void PlayIconFlightToCurrentWeaponsUi()
	{
	}

	public void ShowSlotOnStatForThis(bool show)
	{
	}

	public void SelectedAnimation(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CIdlePulseAnimation_003Ed__52))]
	private IEnumerator IdlePulseAnimation()
	{
		return null;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
