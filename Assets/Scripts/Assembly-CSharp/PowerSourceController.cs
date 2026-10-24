using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerSourceController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCloseRestSiteCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerSourceController _003C_003E4__this;

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
		public _003CCloseRestSiteCoroutine_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003COpenPowerSourceCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PowerSourceController _003C_003E4__this;

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
		public _003COpenPowerSourceCoroutine_003Ed__18(int _003C_003E1__state)
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

	public GameObject Panel;

	public CanvasGroup Background;

	public Button RepairButton;

	public string RepairButtonTextKey;

	public Button UpgradeButton;

	public string UpgradeButtonTextKey;

	public TextMeshProUGUI InfoText;

	public bool BlocksRewardPanels { get; private set; }

	public void ActivePowerUpSourcePanel()
	{
	}

	public void Repair()
	{
	}

	public void Upgrade()
	{
	}

	public void SetInfoText(int optionIndex)
	{
	}

	private void ActiveCanvas(bool active)
	{
	}

	private void CloseRestSite()
	{
	}

	[IteratorStateMachine(typeof(_003CCloseRestSiteCoroutine_003Ed__17))]
	private IEnumerator CloseRestSiteCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenPowerSourceCoroutine_003Ed__18))]
	private IEnumerator OpenPowerSourceCoroutine()
	{
		return null;
	}
}
