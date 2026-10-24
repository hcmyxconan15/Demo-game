using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemInfoMain : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CIdlePulseAnimation_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemInfoMain _003C_003E4__this;

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
		public _003CIdlePulseAnimation_003Ed__51(int _003C_003E1__state)
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

	public bool Unlocked;

	public bool NotAvailable;

	public bool AlreadySeen;

	public bool NewUnlock;

	public bool Purchased;

	public int Id;

	public ItemToUnlock.UnlockType TypeOfItem;

	public GameObject LockedMark;

	public GameObject SelectedObject;

	public Image Icon;

	public Image SlotImage;

	public GameObject NewItemText;

	public GameObject ToPurchaseObject;

	public TextMeshProUGUI PriceToPurchaseText;

	public Sprite UnlockSprite;

	public Sprite LockSprite;

	public Sprite NotAvailableSprite;

	[Header("Items info")]
	public UnlockItemsManager UnlockItemsManager;

	private Weapon _weaponReference;

	private Overload _overloadReference;

	private Microchip _microchipReference;

	private DroneStats _droneStatsReference;

	private BodyType _bodyTypeReference;

	private BaseType _baseTypeReference;

	public Color ColorName;

	public Color ColorPlus;

	public Color ColorLocked;

	public Color NotEnoughColor;

	private Vector3 _slotImageOriginalScale;

	private Coroutine _idleAnimCoroutine;

	private Color _originalTextColor;

	private void Awake()
	{
	}

	public void SetWeapon(Weapon weapon)
	{
	}

	public void SetOverload(Overload overload)
	{
	}

	public void SetChip(Microchip microchip)
	{
	}

	public void SetDrone(DroneStats droneStats)
	{
	}

	public void SetBody(BodyType bodyType)
	{
	}

	public void SetBase(BaseType baseType)
	{
	}

	private void SetLockedStatus(bool locked, bool alreadySee, bool canBeUnlocked, bool newUnlock, bool alreadyPurchased = true)
	{
	}

	private UnlockItemData GetUnlockStatusData()
	{
		return null;
	}

	private void ClearNewUnlockBadge()
	{
	}

	public void SelectThisItem()
	{
	}

	private void ShowItemGameplayInfo()
	{
	}

	private void TryShowEvolutionRequirements()
	{
	}

	private void TryShowProficiencyStatus()
	{
	}

	public bool CanBePurchased()
	{
		return false;
	}

	public int GetUnlockPrice()
	{
		return 0;
	}

	public void SetPurchasedStatus(bool purchased)
	{
	}

	public void RefreshPurchaseDisplay()
	{
	}

	public void DeselectThisItem()
	{
	}

	public void SelectedAnimation(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CIdlePulseAnimation_003Ed__51))]
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
