using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ProficiencyEndGameComponent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class _003CSmoothFillBars_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int startLevel;

		public int startProgress;

		public int xpToAdd;

		public WeaponProficiencyConfig config;

		public ProficiencyEndGameComponent _003C_003E4__this;

		public float duration;

		private int _003Clevel_003E5__2;

		private int _003Cprogress_003E5__3;

		private int _003Cremaining_003E5__4;

		private int _003CmaxValue_003E5__5;

		private int _003Ctarget_003E5__6;

		private int _003Cleftover_003E5__7;

		private bool _003ClevelUp_003E5__8;

		private float _003CstartValue_003E5__9;

		private float _003Celapsed_003E5__10;

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
		public _003CSmoothFillBars_003Ed__9(int _003C_003E1__state)
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

	public Image ItemIcon;

	public Slider ProficiencyStatusSlider;

	public TextMeshProUGUI ProficiencyStatusText;

	public TextMeshProUGUI ProficiencyLevelText;

	private int _weaponId;

	public void SetWeaponIcon(Sprite sprite, int weaponId)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void SetProficiencyStatus(int currentLevel, float proficiency, float proficiencyMax)
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothFillBars_003Ed__9))]
	public IEnumerator SmoothFillBars(int xpToAdd, int startLevel, int startProgress, WeaponProficiencyConfig config, float duration = 1f)
	{
		return null;
	}
}
