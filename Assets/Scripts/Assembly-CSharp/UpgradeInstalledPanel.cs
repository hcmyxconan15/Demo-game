using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeInstalledPanel : MonoBehaviour
{
	private struct UpgradeOffer
	{
		public ItemToUnlock.UnlockType Type;

		public int Level;

		public Weapon Weapon;

		public Microchip Microchip;

		public Overload Overload;

		public DroneStats DroneStats;

		public static UpgradeOffer FromWeapon(Weapon weapon, int level)
		{
			return default;
		}

		public static UpgradeOffer FromMicrochip(Microchip microchip, int level)
		{
			return default;
		}

		public static UpgradeOffer FromOverload(Overload overload, int level)
		{
			return default;
		}

		public static UpgradeOffer FromDrone(DroneStats droneStats, int level)
		{
			return default;
		}
	}

	[CompilerGenerated]
	private sealed class _003CGetShopItemComponents_003Ed__30 : IEnumerable<ShopItemComponent>, IEnumerable, IEnumerator<ShopItemComponent>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ShopItemComponent _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UpgradeInstalledPanel _003C_003E4__this;

		private List<ShopItemComponent>.Enumerator _003C_003E7__wrap1;

		ShopItemComponent IEnumerator<ShopItemComponent>.Current
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
		public _003CGetShopItemComponents_003Ed__30(int _003C_003E1__state)
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

		[DebuggerHidden]
		IEnumerator<ShopItemComponent> IEnumerable<ShopItemComponent>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public Transform ItemComponentParent;

	public ShopItemComponent ShopItemComponentPrefab;

	public List<ShopItemComponent> ShopItemComponents;

	[Header("Joystick grid")]
	public int GridColumns;

	[Header("Info panels")]
	public InfoHelper InfoHelper;

	public TextMeshProUGUI TextSimpleName;

	public InfoHelperSimple InfoHelperSimple;

	public Button OpenBox;

	public BoxAnimation BoxAnimation;

	public List<NavigableButton> NavigableButtons;

	private ShopItemComponent _selectedItem;

	private void Awake()
	{
	}

	public bool HasUpgradableItems()
	{
		return false;
	}

	public bool FillAndShow()
	{
		return false;
	}

	public void Hide()
	{
	}

	public void SelectItem(ShopItemComponent itemSelected)
	{
	}

	public void ConfirmUpgrade(ShopItemComponent selected)
	{
	}

	private void CollectExistingItemsFromParent()
	{
	}

	private void CompactShopItemComponents()
	{
	}

	private void EnsureEnoughSlots(int neededCount)
	{
	}

	private void SetupUpgradeHost(ShopItemComponent shopItemComponent)
	{
	}

	private List<UpgradeOffer> CollectUpgradableItems(RobotParts robotParts)
	{
		return null;
	}

	private static void FillSlot(ShopItemComponent shopItem, UpgradeOffer offer)
	{
	}

	private void ClearAllSlots()
	{
	}

	private void SetItemsNavigation()
	{
	}

	private int GetGridColumns()
	{
		return 0;
	}

	private void SetUpgradeMenuNavigationButtons()
	{
	}

	private void DeselectAllItems()
	{
	}

	private void SelectFirstOnList()
	{
	}

	private ShopItemComponent GetFirstActiveShopItem()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetShopItemComponents_003Ed__30))]
	private IEnumerable<ShopItemComponent> GetShopItemComponents()
	{
		return null;
	}
}
