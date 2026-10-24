using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class PlanetsUiController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShowActivePlanetQuest_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlanetsUiController _003C_003E4__this;

		public float delay;

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
		public _003CShowActivePlanetQuest_003Ed__40(int _003C_003E1__state)
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

	public CanvasGroup SelectorCanvasGroup;

	public CanvasGroup StartButton;

	public GameObject LockedAlert;

	public TextMeshProUGUI PlanetName;

	public List<Planet> Planets;

	public GameObject NewPlanetAlertOnButtonToPlanet;

	public GameObject NewPlanetAlertOnNext;

	[Header("Movement and positions")]
	public float Speed;

	public Transform CenterPointPosition;

	public Transform LeftPointPosition;

	public Transform RightPointPosition;

	public QuestOnPlanetController QuestOnPlanetController;

	public LeaderboardManager LeaderboardManagerBestHuntTime;

	private int _count;

	private int _activeTransitionOldIndex;

	private int _activeTransitionTargetIndex;

	private int _activeTransitionDirection;

	private bool _planetUiOpen;

	private Coroutine _showPlanetQuestCoroutine;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OpenPlanetUi()
	{
	}

	public void ClosePlanetUi(bool validatePlanet = true)
	{
	}

	public void NextPlanet()
	{
	}

	public void PreviousPlanet()
	{
	}

	public void ActivePlanet(int oldPlanetIndex, int direction)
	{
	}

	private void RefreshPlanetLeaderboard()
	{
	}

	private void HidePlanetLeaderboard()
	{
	}

	public void RefreshPlanetAlerts()
	{
	}

	private void MarkCurrentPlanetSeenIfNew()
	{
	}

	private bool HasUnseenNewPlanetNotCurrent()
	{
		return false;
	}

	public void UpdateStartButtonState()
	{
	}

	private void HideStartButton()
	{
	}

	private void ShowPlanetQuest(float delay = 0.2f)
	{
	}

	private void SnapCurrentTransitionToEnd()
	{
	}

	private void MoveAndDeactivateCurrentPlanet(int planetIndex, int direction)
	{
	}

	private void MoveAndActivePlanet(int planetIndex, int direction)
	{
	}

	private void UpdateValidPlanet()
	{
	}

	private void ResetSelectedQuestToPlanetDefault(int planetId)
	{
	}

	[IteratorStateMachine(typeof(_003CShowActivePlanetQuest_003Ed__40))]
	private IEnumerator ShowActivePlanetQuest(float delay = 0.2f)
	{
		return null;
	}
}
