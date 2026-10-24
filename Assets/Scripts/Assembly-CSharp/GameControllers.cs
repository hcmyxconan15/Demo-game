using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameControllers : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFinishTheGameWinCondition_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameControllers _003C_003E4__this;

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
		public _003CFinishTheGameWinCondition_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameControllers _003C_003E4__this;

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
		public _003CStart_003Ed__33(int _003C_003E1__state)
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

	public bool GameActive;

	public float Timer;

	public UiController UiController;

	public MechPlayerController MeshPlayerController;

	public EnemiesController EnemiesController;

	public EnemyOnMapController EnemyOnMapController;

	public DamageOnLevelController DamageOnLevelController;

	public CameraController CameraController;

	public MapSelectorManager MapSelectorManager;

	public AlertBarsController AlertBarsController;

	public ItemsController ItemsController;

	public UnknownEventController UnknownEventController;

	public GlobalVolumeController GlobalVolumeController;

	public TriggerCopterAnimations StartCopterAnimator;

	public CollectionDrone CollectionDrone;

	public EventsOnMapController EventsOnMapController;

	public TutorialController TutorialController;

	public AdvanceMapConditionsController AdvanceMapConditionsController;

	public PointOfInterestMarkerUi PointOfInterestMarkerUi;

	public CameraEnemyFocus CameraEnemyFocus;

	public IconsOnScreenController IconsOnScreenController;

	public PilotDb PilotDb;

	[Header("Revival slow-mo")]
	public float RevivalTimeScale;

	public float RevivalSlowMoDuration;

	public static GameControllers Instance;

	private float _gameplayTimeScale;

	private bool _gamePaused;

	private TimeSpan _timeSpan;

	public bool IsGamePaused => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__33))]
	private IEnumerator Start()
	{
		return null;
	}

	public void SetupGameLevel()
	{
	}

	public void StartLevel()
	{
	}

	public void UserSelectNodeAndStartMap()
	{
	}

	public void WinGame()
	{
	}

	public void GameOver()
	{
	}

	public void AbandonGame()
	{
	}

	public void PauseTheGame(bool pause)
	{
	}

	public void SetGameplayTimeScale(float scale)
	{
	}

	private void UpdateClock()
	{
	}

	[IteratorStateMachine(typeof(_003CFinishTheGameWinCondition_003Ed__43))]
	private IEnumerator FinishTheGameWinCondition()
	{
		return null;
	}

	public int CurrentRobotIndex()
	{
		return 0;
	}

	public int GetPlayerLevel()
	{
		return 0;
	}

	public string GetCurrentWeapons()
	{
		return null;
	}

	public string GetCurrentOverload()
	{
		return null;
	}

	public string GetCurrentChips()
	{
		return null;
	}

	public static string FormatWeaponsForAnalytics(RobotParts parts)
	{
		return null;
	}

	public static string FormatOverloadForAnalytics(RobotParts parts)
	{
		return null;
	}

	public static string FormatChipsForAnalytics(RobotParts parts)
	{
		return null;
	}
}
