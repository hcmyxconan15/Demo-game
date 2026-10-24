using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OverloadSlotUi : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CIdlePulseAnimation_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OverloadSlotUi _003C_003E4__this;

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
		public _003CIdlePulseAnimation_003Ed__18(int _003C_003E1__state)
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

	public int OverloadId;

	public int Level;

	public Image Icon;

	public Image OverloadSlotBackground;

	public Image MaxOverloadImage;

	public TextMeshProUGUI LevelText;

	public Sprite ActiveBackground;

	public Sprite EmptyBackground;

	public Color ColorPlus;

	public OverloadInstalled OverloadInstalledRef;

	private Vector3 _slotImageOriginalScale;

	private Coroutine _idleAnimCoroutine;

	private void Awake()
	{
	}

	public void SetExtraInfo(OverloadInstalled overloadInstalled)
	{
	}

	public void SetEmpty()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void SelectedAnimation(bool active, bool force = false)
	{
	}

	[IteratorStateMachine(typeof(_003CIdlePulseAnimation_003Ed__18))]
	private IEnumerator IdlePulseAnimation()
	{
		return null;
	}
}
