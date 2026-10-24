using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemInfoGameplay : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CIdlePulseAnimation_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemInfoGameplay _003C_003E4__this;

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
		public _003CIdlePulseAnimation_003Ed__37(int _003C_003E1__state)
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

	public ItemToUnlock.UnlockType TypeOfItem;

	public GameObject LockedMark;

	public GameObject SelectedObject;

	public Image Icon;

	public Image SlotImage;

	public GameObject NewItemText;

	public GameObject ToPurchaseObject;

	public Sprite UnlockSprite;

	public Sprite LockSprite;

	public Sprite NotAvailableSprite;

	public Color ColorLocked;

	[Header("Items info")]
	public ItemsInfoGameplayController Controller;

	public bool AlreadySeen;

	public bool Unlocked;

	public bool Purchased;

	public bool NotAvailable;

	private Weapon _weaponReference;

	private Overload _overloadReference;

	private Microchip _microchipReference;

	private DroneStats _droneStatsReference;

	private Vector3 _slotImageOriginalScale;

	private Coroutine _idleAnimCoroutine;

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

	private void ClearReferences()
	{
	}

	private void ApplyUnlockVisualState()
	{
	}

	private UnlockItemData GetUnlockData()
	{
		return null;
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

	public void DeselectThisItem()
	{
	}

	public void SelectedAnimation(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CIdlePulseAnimation_003Ed__37))]
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
