using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class VirtualizedScroll : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFadeOutCanvas_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VirtualizedScroll _003C_003E4__this;

		public CanvasGroup group;

		public float duration;

		private float _003CstartAlpha_003E5__2;

		private float _003Ctime_003E5__3;

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
		public _003CFadeOutCanvas_003Ed__49(int _003C_003E1__state)
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

	public CanvasGroup CanvasGroup;

	public ScrollRect ScrollRect;

	public RectTransform Content;

	public RankPlayerComponent WorldItemPrefab;

	public LeaderboardScoreFormat ScoreFormat;

	public float ItemHeight;

	public float ItemSpacing;

	public int BufferRows;

	[Header("Options")]
	[Header("Navigation buttons")]
	public bool UseNavigationButtons;

	public int FadeTime;

	public CanvasGroup ToTopButton;

	public CanvasGroup ToBottomButton;

	[Header("Scroll Offsets")]
	[Tooltip("Extra padding (in px) inserted before the first (top-most) world.")]
	public float AdditionalTopOffset;

	[Tooltip("Extra padding (in px) appended after the last (bottom-most) world.")]
	public float AdditionalBottomOffset;

	public List<RankPlayerComponent> RankPlayersInstantiate;

	public List<RankPlayer> RankPlayersData;

	private int _visibleCount;

	private int _lowerIndex;

	private int _viewportRowCount;

	private bool _scrollListenerAdded;

	private float _delayToHideNavigationButtons;

	private bool _activeTopButton;

	private bool _activeBottomButton;

	private bool _ignoreFirstMovement;

	private bool _isAnimatingFade;

	private float EffectiveSpacing => 0f;

	private float RowStride => 0f;

	private float GetTopOffset(float rowStride)
	{
		return 0f;
	}

	private float GetBottomOffset()
	{
		return 0f;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSteamAvatarLoaded()
	{
	}

	public void RefreshVisibleItems()
	{
	}

	private void Update()
	{
	}

	public void FillData(List<RankPlayer> data)
	{
	}

	public void InitComponent()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void OnScroll()
	{
	}

	private void SnapToIndex(int index)
	{
	}

	public void ScrollToWorldIndex(int worldIndex)
	{
	}

	private void UpdateVisibleItems()
	{
	}

	private int GetLowerIndex()
	{
		return 0;
	}

	private float CalculateContentHeight(int worldCount)
	{
		return 0f;
	}

	private void UpdateNavigationButtons()
	{
	}

	private void HideShowNavigationButtons()
	{
	}

	private void HideNavigationButtonsSmooth()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOutCanvas_003Ed__49))]
	private IEnumerator FadeOutCanvas(CanvasGroup group, float duration)
	{
		return null;
	}
}
