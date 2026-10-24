using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class StatPreviewText : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSmoothFill_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float targetValue;

		public TextMeshProUGUI textMeshProUGUI;

		public StatPreviewText _003C_003E4__this;

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
		public _003CSmoothFill_003Ed__19(int _003C_003E1__state)
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

	public TextMeshProUGUI StatName;

	public TextMeshProUGUI StatValue;

	public ShowSimpleInfo ShowSimpleInfo;

	public Color ValueColor;

	public Color NegativeValueColor;

	public Color CurrentValueColor;

	private Coroutine _smoothFillCoroutine;

	private float _smoothFillTarget;

	private bool _hasSmoothFillTarget;

	public void SetStat(string statNameKey, float value, bool isPercent, string hoverDescription = null)
	{
	}

	public void SetStatHidden(string statNameKey)
	{
	}

	public void SetStatCompared(string statNameKey, float selectedValue, float equippedValue, bool isPercent)
	{
	}

	public void SetStat(string statNameKey, float value, float maxValue)
	{
	}

	public void SetStatEndPanel(string statNameKey, float value, float value2)
	{
	}

	public void SetStatEndPanel(string statNameKey, string value, float value2)
	{
	}

	public void SetStatEndPanelSimple(string statNameKey, int value)
	{
	}

	public void SnapToFinalValue()
	{
	}

	private void StartSmoothFill(float targetValue, TextMeshProUGUI textMeshProUGUI)
	{
	}

	private void StopSmoothFill()
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothFill_003Ed__19))]
	private IEnumerator SmoothFill(float targetValue, TextMeshProUGUI textMeshProUGUI)
	{
		return null;
	}
}
