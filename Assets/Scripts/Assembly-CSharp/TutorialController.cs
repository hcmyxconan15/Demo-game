using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
	public enum Tutorials
	{
		MapTutorial = 0,
		HowToPlay = 1,
		HowToDash = 2,
		ChipTutorial = 3,
		XpTutorial = 4,
		HowSkillsWork = 5,
		WeaponsTutorial = 6,
		HowToEvolveWeapons = 7
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public MovementController movementController;

		public TutorialController _003C_003E4__this;

		internal bool _003CShowHowToDashTutorialCoroutine_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CAvoidDashingAfterFastInput_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

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
		public _003CAvoidDashingAfterFastInput_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CHideShowMapTutorialCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

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
		public _003CHideShowMapTutorialCoroutine_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CShowFirstTutorial_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

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
		public _003CShowFirstTutorial_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CShowHowSkillsWorkTutorialPanel_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

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
		public _003CShowHowSkillsWorkTutorialPanel_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CShowHowToDashTutorialCoroutine_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		private int _003CdashCountAtShow_003E5__2;

		private float _003Celapsed_003E5__3;

		private bool _003CbreakByDash_003E5__4;

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
		public _003CShowHowToDashTutorialCoroutine_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CShowXpTutorialPanel_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

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
		public _003CShowXpTutorialPanel_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CWaitUntilCanShowTutorial_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialController _003C_003E4__this;

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
		public _003CWaitUntilCanShowTutorial_003Ed__21(int _003C_003E1__state)
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

	public bool TutorialActive;

	public Tutorials TutorialRunning;

	public CanvasGroup MapTutorial;

	[Header("Movement tutorial")]
	public HowToPlayTutorial HowToPlayTutorial;

	[Header("Xp Tutorial")]
	public HowToXpTutorial HowToXpTutorial;

	[Header("Dash tutorial")]
	public int DashTimeToNotTriggerTutorial;

	[Tooltip("After the dash tutorial UI is shown, hide when this many seconds pass or when the player dashes (dash count changes).")]
	public float DashTutorialMaxWaitAfterShowSeconds;

	public int DashLevelToTrigger;

	public HowToDashTutorial HowToDashTutorial;

	[Header("HowS kills Works Tutorial")]
	public HowSkillsWorksTutorial HowSkillsWorksTutorial;

	[Header("Skills chip tutorial")]
	public HowToAddSkillsTutorial HowToAddSkillsTutorial;

	[Header("New weapons tutorial")]
	public NewWeaponsTutorial NewWeaponsTutorial;

	public GameControllers GameControllers;

	private const float MovementDetectionThreshold = 0.5f;

	private const float AxisDetectionThreshold = 0.2f;

	private Vector3 _tutorialStartPlayerPosition;

	private bool _hasTutorialStartPlayerPosition;

	private bool GameplayAllowsTutorials()
	{
		return false;
	}

	private bool IsPauseMenuOpen()
	{
		return false;
	}

	private bool CanShowTutorial()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitUntilCanShowTutorial_003Ed__21))]
	private IEnumerator WaitUntilCanShowTutorial()
	{
		return null;
	}

	public void ShowMapTutorial()
	{
	}

	[IteratorStateMachine(typeof(_003CHideShowMapTutorialCoroutine_003Ed__23))]
	private IEnumerator HideShowMapTutorialCoroutine()
	{
		return null;
	}

	public void HideMapTutorial()
	{
	}

	public void ShowHowToPlayTutorial()
	{
	}

	public void CloseHowToPlayTutorial()
	{
	}

	public void ShowXpTutorial()
	{
	}

	public void CloseXpTutorial()
	{
	}

	public void ShowHowSkillsWorkTutorial()
	{
	}

	public void ContinueHowToSkillsWorkTutorial()
	{
	}

	private void CloseHowSkillsWorkTutorial()
	{
	}

	public void ShowWeaponTutorial()
	{
	}

	public void EndShowWeaponTutorial()
	{
	}

	public void ShowHowToDashTutorial()
	{
	}

	public void EndTutorialHowToDash(bool dashMade)
	{
	}

	public void ShowHowToSkillsTutorial()
	{
	}

	public void EndTutorialChipTutorial()
	{
	}

	private bool PlayerAlreadyUseMovement()
	{
		return false;
	}

	private void EndTutorialHowToMove()
	{
	}

	private bool PlayerAlreadyUseDash()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CShowFirstTutorial_003Ed__41))]
	private IEnumerator ShowFirstTutorial()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowXpTutorialPanel_003Ed__42))]
	private IEnumerator ShowXpTutorialPanel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHowSkillsWorkTutorialPanel_003Ed__43))]
	private IEnumerator ShowHowSkillsWorkTutorialPanel()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowHowToDashTutorialCoroutine_003Ed__44))]
	private IEnumerator ShowHowToDashTutorialCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAvoidDashingAfterFastInput_003Ed__45))]
	private IEnumerator AvoidDashingAfterFastInput(float time)
	{
		return null;
	}
}
