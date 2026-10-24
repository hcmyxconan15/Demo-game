using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UpgradePowerUpsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpenUpgradeMenu_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool open;

		public UpgradePowerUpsController _003C_003E4__this;

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
		public _003COpenUpgradeMenu_003Ed__31(int _003C_003E1__state)
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

	public TextMeshProUGUI PowerUpTitle;

	public int SelectedPowerUpId;

	public InOutFromBottom InOutFromBottom;

	public List<PowerUpElement> PowerUpElements;

	[Header("Upgrade")]
	public CanvasGroup CanvasGroupPanel;

	public InOutFromBottom InOutFromBottomInfo;

	public TextMeshProUGUI Name;

	public TextMeshProUGUI Description;

	public TextMeshProUGUI Price;

	public GameObject UpgradePanel;

	public TextMeshProUGUI UpgradeValue;

	public PowerUpsDb PowerUpsDb;

	[Header("Buttons")]
	public InOutFromLeft Reset;

	public InOutFromLeft Back;

	[Header("Colors")]
	public Color ColorPlus;

	public Color ColorPhysical;

	public Color ColorEnergy;

	public Color ColorStatusWeak;

	public Color ColorStatusBurn;

	public Color ColorStatusShock;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetupPowerUps()
	{
	}

	public void OpenPowerUpsPanel()
	{
	}

	public void ClosePowerUpPanel()
	{
	}

	public void SelectPowerUp(int id)
	{
	}

	public void UpgradePowerUp()
	{
	}

	public void ResetPowerUp()
	{
	}

	private void UpdateSelectedPowerUp()
	{
	}

	private void UpdatePowerUpsStatus()
	{
	}

	[IteratorStateMachine(typeof(_003COpenUpgradeMenu_003Ed__31))]
	private IEnumerator OpenUpgradeMenu(bool open)
	{
		return null;
	}
}
