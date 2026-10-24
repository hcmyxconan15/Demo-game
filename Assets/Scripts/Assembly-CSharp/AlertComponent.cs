using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AlertComponent : MonoBehaviour
{
	public enum AlertType
	{
		Blue = 0,
		Red = 1,
		Green = 2
	}

	[CompilerGenerated]
	private sealed class _003CShowAlerts_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlertComponent _003C_003E4__this;

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
		public _003CShowAlerts_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CShowLinealAlert_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlertComponent _003C_003E4__this;

		public string alertText;

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
		public _003CShowLinealAlert_003Ed__22(int _003C_003E1__state)
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
	private sealed class _003CShowNewPhaseCondition_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float timerDelay;

		public AlertComponent _003C_003E4__this;

		public string alertText;

		public string value;

		public Sprite icon;

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
		public _003CShowNewPhaseCondition_003Ed__23(int _003C_003E1__state)
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

	public bool RunningAlerts;

	public GameObject AlertPanel;

	public TextMeshProUGUI InfoText;

	public Image AlertPanelImage;

	public CanvasGroup PhaseCompletedPanel;

	public TextMeshProUGUI AlertTextMeshProUGUI;

	public TextMeshProUGUI AlertTextHeaderMeshProUGUI;

	public TextMeshProUGUI AlertTextValueMeshProUGUI;

	public Image AlertIconImage;

	public GameObject CenterComponent;

	public List<Alert> AlertsToShow;

	public List<AlertTypeSettings> AlertTypeSettingsList;

	public AlertDb AlertDb;

	public static AlertComponent Instance;

	private void Awake()
	{
	}

	public void QueueAlert(Alert alert)
	{
	}

	public void QueueAlertFromDb(string alertId)
	{
	}

	public void ShowNewPhaseAlert(string alertText, string value, Sprite icon)
	{
	}

	public void ShowEndPhaseAlert(string alertText)
	{
	}

	private void ShowAlert(Alert alert)
	{
	}

	[IteratorStateMachine(typeof(_003CShowAlerts_003Ed__21))]
	private IEnumerator ShowAlerts()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowLinealAlert_003Ed__22))]
	private IEnumerator ShowLinealAlert(string alertText)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CShowNewPhaseCondition_003Ed__23))]
	private IEnumerator ShowNewPhaseCondition(string alertText, string value, Sprite icon, float timerDelay = 1.5f)
	{
		return null;
	}
}
