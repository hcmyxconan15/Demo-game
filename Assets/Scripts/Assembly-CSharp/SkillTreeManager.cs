using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreeManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpenUpgradeMenu_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool open;

		public SkillTreeManager _003C_003E4__this;

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
		public _003COpenUpgradeMenu_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CScrollToCoroutine_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillTreeManager _003C_003E4__this;

		public RectTransform target;

		public bool scrollVertically;

		public float offset;

		public bool scrollHorizontally;

		public float duration;

		private float _003CtargetNormalizedY_003E5__2;

		private float _003CtargetNormalizedX_003E5__3;

		private float _003CstartNormalizedY_003E5__4;

		private float _003CstartNormalizedX_003E5__5;

		private float _003CelapsedTime_003E5__6;

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
		public _003CScrollToCoroutine_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CScrollToNormalizedCenterCoroutine_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillTreeManager _003C_003E4__this;

		public float duration;

		private float _003CstartY_003E5__2;

		private float _003CstartX_003E5__3;

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
		public _003CScrollToNormalizedCenterCoroutine_003Ed__58(int _003C_003E1__state)
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

	public bool UseResetButton;

	public GameObject AlertForSpendSkillPoints;

	public Button ResetButton;

	public List<SkillTreeButton> SkillTreeButtons;

	[Header("Prefab")]
	public SkillTreeLine SkillTreeLinePrefab;

	public SkillTreeButton SkillTreeButtonPrefab;

	[Header("Runtime build")]
	public bool BuildFromConfig;

	public SkillTreeGraphConfig GraphConfig;

	public RectTransform NodesParent;

	public MenuNavigation MenuNavigation;

	[Header("Content fit")]
	public bool FitContentToNodes;

	public float ContentPaddingLeft;

	public float ContentPaddingRight;

	public float ContentPaddingTop;

	public float ContentPaddingBottom;

	[Header("Upgrade")]
	public CanvasGroup CanvasGroupPanel;

	public InOutFromBottom InOutFromBottomInfo;

	public TextMeshProUGUI Name;

	public TextMeshProUGUI Description;

	public TextMeshProUGUI Price;

	public List<GameObject> UpgradeImages;

	public List<Image> CompletedImage;

	public GameObject UpgradePanel;

	public TextMeshProUGUI UpgradeValue;

	public PowerUpsDb PowerUpsDb;

	[Header("Scroll rect")]
	public float OffsetVertical;

	public float OffsetHorizontal;

	public RectTransform VerticalViewport;

	public RectTransform HorizontalViewport;

	public ScrollRect ScrollRect;

	[Header("Colors")]
	public Color ColorPlus;

	[Header("Input")]
	public string SpriteId;

	public GameObject ComponentGameObject;

	public Image ButtonSprite;

	public TextMeshProUGUI UnlockText;

	private MainMenuJoystickBase _mainMenuJoystick;

	private Coroutine _moveScroll;

	private void Start()
	{
	}

	private void InitSkillTree()
	{
	}

	private void OptimizeRaycastTargets()
	{
	}

	public void CheckForSpendSkillPoints()
	{
	}

	public void ShowAvailablePowerUpsToUpgrade()
	{
	}

	[ContextMenu("Setup PowerUps")]
	public void SetupPowerUps()
	{
	}

	public void OpenSkillTreePanel()
	{
	}

	[ContextMenu("Close PowerUps Panel")]
	public void ClosePowerUpPanel()
	{
	}

	public void SelectPowerUp(int id, SkillTreeButton skillTreeButton = null)
	{
	}

	public bool UpgradePowerUp(int id, bool unlocked)
	{
		return false;
	}

	public void ResetPowerUp()
	{
	}

	private void UpdateSelectedPowerUp(int id, SkillTreeButton skillTreeButton = null)
	{
	}

	private void UpdatePowerUpsStatus()
	{
	}

	private void SetLockedButton()
	{
	}

	private bool IsPowerUpLockedForDemo(int id)
	{
		return false;
	}

	private SkillTreeButton FindSkillTreeButton(int id)
	{
		return null;
	}

	public bool CanSpendSkillsPoints()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003COpenUpgradeMenu_003Ed__54))]
	private IEnumerator OpenUpgradeMenu(bool open)
	{
		return null;
	}

	public bool IsElementInViewport(RectTransform componentRecTransform, RectTransform viewportToCheck)
	{
		return false;
	}

	public void ResetScrollToCenter(float duration)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToNormalizedCenterCoroutine_003Ed__58))]
	private IEnumerator ScrollToNormalizedCenterCoroutine(float duration)
	{
		return null;
	}

	public void ScrollToSmooth(RectTransform target, float duration, float offset, bool scrollVertically, bool scrollHorizontally)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToCoroutine_003Ed__60))]
	private IEnumerator ScrollToCoroutine(RectTransform target, float duration, float offset, bool scrollVertically, bool scrollHorizontally)
	{
		return null;
	}

	public void BuildFromGraphConfig()
	{
	}

	private void ResizeContentToFitNodes(RectTransform content)
	{
	}

	private void WireJoystickNavigation()
	{
	}

	private static NavigableButton FindDirectionalNeighbor(List<Vector2> positions, List<NavigableButton> navButtons, int index, Vector2 direction)
	{
		return null;
	}

	private void ClearGeneratedTree(Transform parent)
	{
	}

	[ContextMenu("Update Lines")]
	public void UpdateLines()
	{
	}

	private void UpdateButtonSprite()
	{
	}
}
