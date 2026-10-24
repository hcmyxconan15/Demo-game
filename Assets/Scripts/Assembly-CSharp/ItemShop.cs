using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
	private struct PendingShopIconFlight
	{
		public Sprite Icon;

		public float StartWorldWidth;

		public ItemToUnlock.UnlockType Type;

		public int Id;
	}

	[CompilerGenerated]
	private sealed class _003CCloseShopCoroutine_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemShop _003C_003E4__this;

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
		public _003CCloseShopCoroutine_003Ed__70(int _003C_003E1__state)
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
	private sealed class _003CGetAllShopItemComponents_003Ed__59 : IEnumerable<ShopItemComponent>, IEnumerable, IEnumerator<ShopItemComponent>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ShopItemComponent _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public ItemShop _003C_003E4__this;

		private IEnumerator<ShopItemComponent> _003C_003E7__wrap1;

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
		public _003CGetAllShopItemComponents_003Ed__59(int _003C_003E1__state)
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

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
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

	[CompilerGenerated]
	private sealed class _003CGetShopItemComponents_003Ed__60 : IEnumerable<ShopItemComponent>, IEnumerable, IEnumerator<ShopItemComponent>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ShopItemComponent _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private List<ShopItemComponent> shopItemComponents;

		public List<ShopItemComponent> _003C_003E3__shopItemComponents;

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
		public _003CGetShopItemComponents_003Ed__60(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COpenShopCoroutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemShop _003C_003E4__this;

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
		public _003COpenShopCoroutine_003Ed__69(int _003C_003E1__state)
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

	public bool ShopPanelOpen;

	public CanvasGroup CanvasGroup;

	public GameObject CurrencyComponent;

	public CanvasGroup BackGround;

	public List<ShopItemComponent> ShopItemWeaponsComponents;

	public List<ShopItemComponent> ShopItemMicrochipsComponents;

	public List<ShopItemComponent> ShopItemOverloadComponents;

	public List<NavigableButton> NavigableButtons;

	[Header("Joystick grid")]
	public int GridColumns;

	public InOutFromLeft InOutFromLeft;

	public Button ContinueButton;

	[Header("Reroll")]
	public int RerollCount;

	public int RerollPrice;

	public int RerollBasePrice;

	public TextMeshProUGUI RerollPriceText;

	public Button RerollButton;

	public Color NotEnoughColor;

	[Header("Shop item properties")]
	public int DiscountNumber;

	public int DiscountPercent;

	public int WeaponsToShow;

	public int MicrochipsToShow;

	public int OverloadsToShow;

	public InfoHelper InfoHelper;

	public TextMeshProUGUI TextSimpleName;

	public InfoHelperSimple InfoHelperSimple;

	private List<int> _weaponsOnDbToSelect;

	private List<int> _weaponsToSelect;

	private List<int> _microchipsOnDbToSelect;

	private List<int> _microchipsToSelect;

	private List<int> _overloadOnDbToSelect;

	private List<int> _overloadToSelect;

	private readonly List<GameTag> _offerAffinityScratch;

	private readonly List<BuildArchetype> _offerArchetypeScratch;

	private ShopItemComponent _selectedItem;

	private Color _originalRerollPriceColor;

	private readonly List<PendingShopIconFlight> _pendingIconFlights;

	private bool _open;

	private void Awake()
	{
	}

	public void OpenShop()
	{
	}

	public void SelectItem(ShopItemComponent itemSelected)
	{
	}

	public void BuySelected(ShopItemComponent selected)
	{
	}

	public void Continue()
	{
	}

	private void ActiveShopCanvas(bool active)
	{
	}

	private void FillLevelUpChoices()
	{
	}

	private void SetItemsNavigation()
	{
	}

	private void SetShopMenuNavigationButtons()
	{
	}

	private int GetGridColumns()
	{
		return 0;
	}

	private Transform GetShopItemContent()
	{
		return null;
	}

	private List<ShopItemComponent> GetShopItemsInVisualOrder()
	{
		return null;
	}

	private List<ShopItemComponent> GetActiveShopItemsInVisualOrder()
	{
		return null;
	}

	private void AddButtonWithWeapon(int buttonIndex)
	{
	}

	private void AddButtonWithMicrochip(int buttonIndex)
	{
	}

	private void AddButtonWithOverload(int buttonIndex)
	{
	}

	private void CheckSlotForItemsAfterPurchase()
	{
	}

	private void DeselectAllItems()
	{
	}

	private void SelectFirstOnList()
	{
	}

	private void SelectShopItemWithNavigation(ShopItemComponent item)
	{
	}

	private ShopItemComponent GetNextItemAfterPurchase(ShopItemComponent purchasedItem)
	{
		return null;
	}

	private ShopItemComponent GetFirstActiveShopItem()
	{
		return null;
	}

	private bool HasActiveShopItems()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CGetAllShopItemComponents_003Ed__59))]
	private IEnumerable<ShopItemComponent> GetAllShopItemComponents()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetShopItemComponents_003Ed__60))]
	private IEnumerable<ShopItemComponent> GetShopItemComponents(List<ShopItemComponent> shopItemComponents)
	{
		return null;
	}

	private int GetShopItemCount(List<ShopItemComponent> shopItemComponents)
	{
		return 0;
	}

	private int GetItemsToShowCount(int itemsToShow, List<ShopItemComponent> shopItemComponents)
	{
		return 0;
	}

	private void ApplyShopDiscounts()
	{
	}

	private int GetCurrentRerollPrice()
	{
		return 0;
	}

	private void UpdateRerollUi()
	{
	}

	public void RerollOffers()
	{
	}

	public void OpenShopPanelAnimationPanel(bool open)
	{
	}

	[IteratorStateMachine(typeof(_003COpenShopCoroutine_003Ed__69))]
	private IEnumerator OpenShopCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCloseShopCoroutine_003Ed__70))]
	private IEnumerator CloseShopCoroutine()
	{
		return null;
	}

	private void BringCurrencyToFront()
	{
	}

	private void RestoreCurrencyComponent()
	{
	}

	private float GetShopOfferBaseWeight(int typeId, RobotParts robotParts)
	{
		return 0f;
	}

	private List<int> SelectWeightedShopItems(List<int> pool, int typeId, float baseWeight, int count, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes)
	{
		return null;
	}

	private List<(int, float)> BuildShopOfferPool(List<int> pool, int typeId, float baseWeight, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes)
	{
		return null;
	}

	private float GetShopOfferWeight(int typeId, int itemId, float baseWeight, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes)
	{
		return 0f;
	}

	private void QueueIconFlight(ShopItemComponent selected)
	{
	}

	private void PlayPendingIconFlights()
	{
	}
}
