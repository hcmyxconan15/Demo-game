using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UiXpLevelController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateForward_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiXpLevelController _003C_003E4__this;

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
		public _003CAnimateForward_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CLevelUpHoldRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UiXpLevelController _003C_003E4__this;

		private int _003CprevCount_003E5__2;

		private bool _003CpanelResolved_003E5__3;

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
		public _003CLevelUpHoldRoutine_003Ed__13(int _003C_003E1__state)
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

	[SerializeField]
	private TextMeshProUGUI LevelText;

	[SerializeField]
	private TextMeshProUGUI LevelTextInGame;

	[SerializeField]
	private ProgressBarPro LevelXpBar;

	[Tooltip("Bar fill speed in normalized units per second (1 = full bar in 1s).")]
	[SerializeField]
	private float FillSpeed;

	private float _targetValue;

	private float _currentValue;

	private float _pendingTarget;

	private bool _initialized;

	private bool _holdingForLevelUp;

	private Coroutine _animRoutine;

	public void UpdateLevel(int currentLevel)
	{
	}

	public void UpdateSlider(int currentValue, int maxValue)
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateForward_003Ed__12))]
	private IEnumerator AnimateForward()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLevelUpHoldRoutine_003Ed__13))]
	private IEnumerator LevelUpHoldRoutine()
	{
		return null;
	}

	private bool IsLevelUpInProgress()
	{
		return false;
	}

	private bool IsLevelUpPanelOpen()
	{
		return false;
	}

	private int GetQueueCount()
	{
		return 0;
	}

	private void StopAnimRoutine()
	{
	}

	private void OnDisable()
	{
	}
}
