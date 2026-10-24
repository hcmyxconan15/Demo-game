using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using PlayFab.ClientModels;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{
	public enum LeaderboardBoardKind
	{
		HuntScore = 0,
		PlanetTime = 1
	}

	public enum LeaderboardType
	{
		Steam = 0,
		PlayFab = 2
	}

	public enum LeaderboardTab
	{
		Global = 0,
		Friend = 1
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CFillPlayerDataAsync_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public LeaderboardManager _003C_003E4__this;

		public RankPlayer rankPlayer;

		private TaskAwaiter<GetLeaderboardAroundPlayerResult> _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CInitLeaderboardAsync_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LeaderboardManager _003C_003E4__this;

		private int _003Cattempt_003E5__2;

		private float _003Celapsed_003E5__3;

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
		public _003CInitLeaderboardAsync_003Ed__44(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadCurrentPlayerData_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public LeaderboardManager _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public CanvasGroup LeaderboardCanvasGroup;

	public InOutFromRight InOutFromRight;

	public List<RankPlayer> RankPlayersData;

	public VirtualizedScroll VirtualizedScroll;

	public CanvasGroup RankPlayerCanvasGroup;

	public RankPlayerComponent RankPlayerComponent;

	public TabButtonItems GlobalButton;

	public TabButtonItems FriendButton;

	[Header("Board")]
	public LeaderboardBoardKind BoardKind;

	public LeaderboardFakePlayers FakePlayers;

	private LeaderboardType _leaderboardType;

	private RankPlayer _planetCurrentPlayerData;

	private int _planetId;

	public static LeaderboardManager Instance;

	private bool _open;

	private const int LegacyUnityLeaderboardValue = 1;

	[Header("Tab manager")]
	public Transform TabParent;

	public LeaderboardTab LeaderboardTabActive;

	public List<TabButtonItems> TabButtons;

	[Header("Tab input (Joystick)")]
	public List<MainMenuJoystickBase.PanelActive> UseOnPanelActive;

	public string ButtonNameLeft;

	public string SpriteId;

	public Image ButtonSpriteLeft;

	public string ButtonNameRight;

	public string SpriteIdRight;

	public Image ButtonSpriteRight;

	public MainMenuJoystickBase MainMenuJoystick;

	private bool _buttonLeft;

	private bool _buttonRight;

	public bool IsAvailable { get; private set; }

	private bool IsPlanetTimeBoard => false;

	private LeaderboardScoreFormat ScoreFormat => LeaderboardScoreFormat.Points;

	public static LeaderboardType ResolveLeaderboardType(LeaderboardType configured)
	{
		return LeaderboardType.Steam;
	}

	public void SetUnavailable(string reason = null)
	{
	}

	public void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void InitLeaderboard()
	{
	}

	private void SetTabStatus(int selectedIndex)
	{
	}

	public void GetPlayersGlobal()
	{
	}

	public void GetPlayersFriends()
	{
	}

	public void LoadPlanetLeaderboard(int planetId)
	{
	}

	private void RequestPlanetScores(bool friends)
	{
	}

	public void OpenLeaderboard(bool open)
	{
	}

	public void FillVirtualScrollLeaderBoard(List<RankPlayer> rankPlayersData)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadCurrentPlayerData_003Ed__40))]
	private void LoadCurrentPlayerData()
	{
	}

	[AsyncStateMachine(typeof(_003CFillPlayerDataAsync_003Ed__41))]
	private Task FillPlayerDataAsync(RankPlayer rankPlayer)
	{
		return null;
	}

	public void FillPlayerData(RankPlayer rankPlayer)
	{
	}

	public void UpdatePlayerNickname(string nickname)
	{
	}

	[IteratorStateMachine(typeof(_003CInitLeaderboardAsync_003Ed__44))]
	private IEnumerator InitLeaderboardAsync()
	{
		return null;
	}

	private void SetTabVisibility(LeaderboardType leaderboardType)
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
