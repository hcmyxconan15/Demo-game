using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotInfo : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CIdlePulseAnimation_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SlotInfo _003C_003E4__this;

		private float _003Cspeed_003E5__2;

		private float _003CscaleAmount_003E5__3;

		private float _003Ct_003E5__4;

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
		public _003CIdlePulseAnimation_003Ed__29(int _003C_003E1__state)
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

	public int SlotId;

	public bool DontShowToolTip;

	public bool IsDrone;

	public Image WeaponIcon;

	public Image WeaponSlot;

	public Image WeaponFullLevelImage;

	public Weapon.SlotType WeaponSlotType;

	public TextMeshProUGUI InfoText;

	public TextMeshProUGUI SlotType;

	public Sprite WeaponSlotFilled;

	public Sprite WeaponSlotEmpty;

	public Color SelectedColor;

	private WeaponJoin _weaponJoin;

	private DroneStats _drone;

	private Weapon _weaponPreview;

	private int _weaponPreviewLevel;

	private Vector3 _slotTypeOriginalScale;

	private Vector3 _slotImageOriginalScale;

	private Coroutine _idleAnimCoroutine;

	private Color _originalTypeColor;

	private void Awake()
	{
	}

	public void SetInfoDrone(DroneStats droneStats, WeaponJoin weapon, Sprite image, int droneLevel)
	{
	}

	public void SetInfo(WeaponJoin weapon, string info, Sprite image, Weapon.SlotType slotType)
	{
	}

	public void SetInfo(Weapon weapon, int level)
	{
	}

	public void SetInfoOnlyString(string info, Sprite image, Weapon.SlotType slotType)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void ClearWeaponPreview()
	{
	}

	public void SelectedAnimation(bool active, bool force = false)
	{
	}

	[IteratorStateMachine(typeof(_003CIdlePulseAnimation_003Ed__29))]
	private IEnumerator IdlePulseAnimation()
	{
		return null;
	}
}
