using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemsInfoGameplayController : MonoBehaviour
{
	public enum TabActive
	{
		Weapons = 0,
		Chips = 1,
		Overloads = 2,
		Evolutions = 3
	}

	[CompilerGenerated]
	private sealed class _003CScrollToCoroutine_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemsInfoGameplayController _003C_003E4__this;

		public RectTransform target;

		public float offset;

		public float duration;

		private float _003CtargetNormalizedY_003E5__2;

		private float _003CstartNormalizedY_003E5__3;

		private float _003CelapsedTime_003E5__4;

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
		public _003CScrollToCoroutine_003Ed__51(int _003C_003E1__state)
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

	public bool Open;

	public CanvasGroup CanvasGroupPanel;

	public GameObject Panel;

	public GameObject BackButton;

	public List<ItemInfoGameplay> ItemInfoList;

	public int GridColumns;

	public TabActive CurrentTabActive;

	public List<TabButtonItems> TabButtons;

	[Header("Items info")]
	public InfoHelper InfoHelper;

	public TextMeshProUGUI TextSimpleName;

	public InfoHelperSimple InfoHelperSimple;

	public ProficiencyStatus ProficiencyStatus;

	public bool ShowWeaponProficiency;

	[Header("Unlock info")]
	public GameObject SliderFullComponent;

	public Slider SliderComponent;

	public TextMeshProUGUI StatusValue;

	[Header("Evolution info")]
	public EvolutionsInfoPanel EvolutionsInfoPanel;

	[Header("Scroll")]
	public ScrollRect ScrollRect;

	public RectTransform Viewport;

	public float ScrollOffset;

	public float ViewportPadding;

	private Coroutine _moveScroll;

	[Header("Tab input (Joystick)")]
	public List<MainMenuJoystickBase.PanelActive> UseOnPanelActive;

	public string ButtonNameLeft;

	public string SpriteId;

	public Image ButtonSpriteLeft;

	public string ButtonNameRight;

	public string SpriteIdRight;

	public Image ButtonSpriteRight;

	public MenuNavigation MenuNavigation;

	public RobotParts RobotParts => null;

	private MainMenuJoystickGamePlay MainMenuJoystick => null;

	public void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	public void SetWeaponList()
	{
	}

	public void SetChipList()
	{
	}

	public void SetOverloadList()
	{
	}

	public void SetEvolutionList()
	{
	}

	private static void SortUnlockBuckets<T>(bool notAvailable, UnlockItemData unlockData, T item, List<T> seen, List<T> unseen, List<T> toPurchase, List<T> locked, List<T> notAvailableList)
	{
	}

	private int PlaceWeapons(List<Weapon> list, int slotIndex)
	{
		return 0;
	}

	private int PlaceDrones(List<DroneStats> list, int slotIndex)
	{
		return 0;
	}

	private int PlaceChips(List<Microchip> list, int slotIndex)
	{
		return 0;
	}

	private int PlaceOverloads(List<Overload> list, int slotIndex)
	{
		return 0;
	}

	public void DeselectAllItems()
	{
	}

	public void HideProficiencyStatus()
	{
	}

	public void HideUnlockProgress()
	{
	}

	public void ShowLockedEvolutionUnlockInfo(Weapon evolutionWeapon)
	{
	}

	public void ShowUnlockInfo(int id, ItemToUnlock.UnlockType typeOfItem)
	{
	}

	private string GetFormattedUnlockString(string text, float value, int extraId, AchievementsDatabase.StatsApiName statsApiName)
	{
		return null;
	}

	private static string ResolveExtraIdDisplayName(AchievementsDatabase.StatsApiName statsApiName, int extraId)
	{
		return null;
	}

	public void ShowProficiencyStatusForWeapon(Weapon weapon)
	{
	}

	public void ShowEvolutionRequirements(Weapon evolutionWeapon)
	{
	}

	private void HideAllItems()
	{
	}

	private void SetTabStatus(int selectedIndex)
	{
	}

	private void SelectFirstOnList()
	{
	}

	public void EnsureItemInViewport(ItemInfoGameplay item)
	{
	}

	public bool IsElementInViewport(RectTransform componentRecTransform)
	{
		return false;
	}

	public void ScrollToSmooth(RectTransform target, float duration = 0.5f, float offset = 50f)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToCoroutine_003Ed__51))]
	private IEnumerator ScrollToCoroutine(RectTransform target, float duration, float offset)
	{
		return null;
	}

	private void SetItemsNavigation()
	{
	}

	private void Start()
	{
	}

	private void CacheUnlockProgressUi()
	{
	}

	private void Update()
	{
	}

	private void GoNextTab()
	{
	}

	private void GoBackTab()
	{
	}

	private void UpdateButtonSprite()
	{
	}
}
