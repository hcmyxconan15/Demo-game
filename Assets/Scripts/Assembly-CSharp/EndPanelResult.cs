using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndPanelResult : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetEndPanelResults_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndPanelResult _003C_003E4__this;

		public float startWaitTime;

		public int unlockPoints;

		public int enemiesSlain;

		public bool firstGameOverShow;

		public int pilotPoints;

		private List<ItemToUnlock> _003CunlockedItems_003E5__2;

		private List<WeaponProficiencyGain> _003CproficiencyGains_003E5__3;

		private bool _003CsnappedOnSkip_003E5__4;

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
		public _003CSetEndPanelResults_003Ed__60(int _003C_003E1__state)
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
	private sealed class _003CShowContinueButtonAfterResults_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndPanelResult _003C_003E4__this;

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
		public _003CShowContinueButtonAfterResults_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CSmoothFillBars_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EndPanelResult _003C_003E4__this;

		public int currentProgress;

		public int progress;

		public int maxValue;

		public float duration;

		private bool _003ClevelUp_003E5__2;

		private float _003Celapsed_003E5__3;

		private float _003CstartValue_003E5__4;

		private int _003Ctarget_003E5__5;

		private int _003Cleftover_003E5__6;

		private PilotData _003CcurrentPilotData_003E5__7;

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
		public _003CSmoothFillBars_003Ed__51(int _003C_003E1__state)
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
	private sealed class _003CWaitOrSkip_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public EndPanelResult _003C_003E4__this;

		private float _003Celapsed_003E5__2;

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
		public _003CWaitOrSkip_003Ed__57(int _003C_003E1__state)
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

	public StatPreviewText NormalEnemyKilled;

	public StatPreviewText EliteEnemyKilled;

	public StatPreviewText MercenaryEnemyKilled;

	public StatPreviewText BossEnemyKilled;

	public StatPreviewText Chest;

	public StatPreviewText QuestCompleted;

	public StatPreviewText TimePlayed;

	public StatPreviewText SkillPoints;

	public StatPreviewText DiamondsPoints;

	public StatPreviewText TotalScore;

	public TextMeshProUGUI NextButtonText;

	public Button NextButton;

	[Header("Pilot progress")]
	public Image AvatarImage;

	public RectTransform PilotUi;

	public TextMeshProUGUI ProgressBarStatus;

	public TextMeshProUGUI PilotLevelText;

	public Slider PilotProgressBar;

	[Header("Pilot level stamp")]
	public float PilotStampPopInDuration;

	public float PilotStampDuration;

	public float PilotStampPopScale;

	public float PilotStampSettleScale;

	public float SkipToContinueHideDuration;

	[Header("Unlocks area")]
	public UnlockPanelReveal UnlockPanelReveal;

	private bool _continue;

	private bool _pilotUpdate;

	private bool _skipRequested;

	private bool _resultsReady;

	private bool _endOfRunRewardsApplied;

	private Sequence _pilotLevelStampSequence;

	private Vector3 _pilotUiRestScale;

	private bool _pilotUiRestScaleCached;

	private bool _pilotStampPlayedThisReveal;

	private Coroutine _resultsCoroutine;

	private Coroutine _pilotFillCoroutine;

	public void SetEndPanelResults(bool isWin)
	{
	}

	public void NextButtonClick()
	{
	}

	private void SetNextButtonLabel(bool skip)
	{
	}

	[IteratorStateMachine(typeof(_003CShowContinueButtonAfterResults_003Ed__37))]
	private IEnumerator ShowContinueButtonAfterResults()
	{
		return null;
	}

	private void UpdateHuntInfoOnData(int huntId, int runTimes, int completed, TimeSpan bestTimePlayed, int killsOnRun)
	{
	}

	private void ShowAndAddDiamondsPoints(int diamondPoints)
	{
	}

	private void ShowAndAddSkillPoints(int skillPoints)
	{
	}

	private void UpdateBestScoreAndLeaderboard(int score)
	{
	}

	private void UpdateBestScoreLeaderboard(int score)
	{
	}

	private void UpdatePlanetTimeLeaderboard(TimeSpan timePlayed)
	{
	}

	private Pilot GetSelectedPilot()
	{
		return null;
	}

	private int PilotLevelDisplay(PilotData pilotData)
	{
		return 0;
	}

	private void ApplyPilotMaxProgressUi(PilotData currentPilotData, Pilot pilot)
	{
	}

	private void SetPilotCurrentStatus()
	{
	}

	private void SetPilotProgressUpdate(int progress)
	{
	}

	private void StopResultsPresentation()
	{
	}

	private void ApplyAllRemainingPilotXp(int progress, int currentProgress, int maxValue)
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothFillBars_003Ed__51))]
	private IEnumerator SmoothFillBars(int progress, int currentProgress, int maxValue, float duration = 1f)
	{
		return null;
	}

	private void CachePilotUiRestScale()
	{
	}

	private void KillPilotLevelStampSequence()
	{
	}

	private void PlayPilotLevelStampIfNeeded()
	{
	}

	private void PlayPilotLevelStampAnimation()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitOrSkip_003Ed__57))]
	private IEnumerator WaitOrSkip(float seconds)
	{
		return null;
	}

	private void SnapAllEndPanelStats()
	{
	}

	private void ApplyEndOfRunRewards(int enemiesSlain, bool firstGameOverShow, out List<ItemToUnlock> unlockedItems, out List<WeaponProficiencyGain> proficiencyGains)
	{
		unlockedItems = null;
		proficiencyGains = null;
	}

	[IteratorStateMachine(typeof(_003CSetEndPanelResults_003Ed__60))]
	private IEnumerator SetEndPanelResults(int unlockPoints, int pilotPoints, int enemiesSlain, float startWaitTime, bool firstGameOverShow)
	{
		return null;
	}
}
