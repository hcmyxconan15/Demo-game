using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PlayfulSystems.ProgressBar;
using UnityEngine;

[ExecuteInEditMode]
public class ProgressBarPro : MonoBehaviour
{
	public enum AnimationType
	{
		FixedTimeForChange = 0,
		ChangeSpeed = 1
	}

	[CompilerGenerated]
	private sealed class _003CDoBarSizeAnim_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressBarPro _003C_003E4__this;

		private float _003CstartValue_003E5__2;

		private float _003Ctime_003E5__3;

		private float _003Cchange_003E5__4;

		private float _003Cduration_003E5__5;

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
		public _003CDoBarSizeAnim_003Ed__23(int _003C_003E1__state)
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

	public bool DontUseTimeScale;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_value;

	private float displayValue;

	[Space(10f)]
	[Tooltip("Smoothes out the animation of the bar.")]
	[SerializeField]
	private bool animateBar;

	[SerializeField]
	private AnimationType animationType;

	[SerializeField]
	private float animTime;

	[Space(10f)]
	[SerializeField]
	private ProgressBarProView[] views;

	private Coroutine sizeAnim;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DisplayValue => 0f;

	public void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void SetValue(float value, float maxValue)
	{
	}

	public void SetValue(int value, int maxValue)
	{
	}

	public void SetValue(float percentage, bool forceUpdate = false)
	{
	}

	public bool IsAnimating()
	{
		return false;
	}

	public void SetValueImmediate(float percentage)
	{
	}

	public void SetBarColor(Color color)
	{
	}

	private void StartSizeAnim(float percentage)
	{
	}

	[IteratorStateMachine(typeof(_003CDoBarSizeAnim_003Ed__23))]
	private IEnumerator DoBarSizeAnim()
	{
		return null;
	}

	private void SetDisplayValue(float value, bool forceUpdate = false)
	{
	}

	private void UpdateBarViews(float currentValue, float targetValue, bool forceUpdate = false)
	{
	}

	private void OnDidApplyAnimationProperties()
	{
	}
}
