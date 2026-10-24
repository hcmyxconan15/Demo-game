using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WeaponSlotUi : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CReloading_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponSlotUi _003C_003E4__this;

		public float reloadTime;

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
		public _003CReloading_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CReloadingFireRate_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponSlotUi _003C_003E4__this;

		public float reloadTime;

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
		public _003CReloadingFireRate_003Ed__29(int _003C_003E1__state)
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

	public int WeaponId;

	public int WeaponLevel;

	public bool Used;

	public RectTransform Target;

	public Image WeaponIcon;

	public Image MaxWeaponImage;

	public Image SlotImage;

	public Sprite ActiveImage;

	public Sprite ReloadingImage;

	public TextMeshProUGUI LevelText;

	public TextMeshProUGUI BulletCount;

	public CanvasGroup ProgressBarCanvasGroup;

	public ProgressBarPro ProgressBarPro;

	public CanvasGroup ProgressBarFireRateCanvasGroup;

	public ProgressBarPro ProgressBarProFireRate;

	public WeaponJoin WeaponJoin;

	public bool IsDrone;

	public DroneStats Drone;

	private float _reloadingTimer;

	private float _reloadingTimerFireRate;

	private int _magazine;

	private bool _reloading;

	private Coroutine _reloadFireRateCoroutine;

	[SerializeField]
	private float PopScaleAmount;

	[SerializeField]
	private float Duration;

	public void ReloadBars(float reloadTime, int magazine)
	{
	}

	public void ReloadBarsFireRate(float reloadTime)
	{
	}

	public void CancelReloadUi()
	{
	}

	[IteratorStateMachine(typeof(_003CReloading_003Ed__28))]
	private IEnumerator Reloading(float reloadTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReloadingFireRate_003Ed__29))]
	private IEnumerator ReloadingFireRate(float reloadTime)
	{
		return null;
	}

	private void CompleteAnimation()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
