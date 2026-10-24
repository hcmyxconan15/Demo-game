using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(Graphic))]
	public class BarViewColor : ProgressBarProView
	{
		[CompilerGenerated]
		private sealed class _003CDoBarColorAnim_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarViewColor _003C_003E4__this;

			public Color targetColor;

			public float duration;

			private float _003Ctime_003E5__2;

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
			public _003CDoBarColorAnim_003Ed__16(int _003C_003E1__state)
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
		protected Graphic graphic;

		[Header("Color Options")]
		[Tooltip("The default color of the bar can be set by the ProgressBar.SetbarColor()")]
		[SerializeField]
		private bool canOverrideColor;

		[SerializeField]
		private Color defaultColor;

		[Tooltip("Change color of the bar automatically based on it's value.")]
		[SerializeField]
		private bool useGradient;

		[SerializeField]
		private Gradient barGradient;

		private Color flashColor;

		private float flashcolorAlpha;

		private float currentValue;

		[Header("Color Animation")]
		[SerializeField]
		private bool flashOnGain;

		[SerializeField]
		private Color gainColor;

		[SerializeField]
		private bool flashOnLoss;

		[SerializeField]
		private Color lossColor;

		[SerializeField]
		private float flashTime;

		private Coroutine colorAnim;

		private void OnEnable()
		{
		}

		public override void NewChangeStarted(float currentValue, float targetValue)
		{
		}

		[IteratorStateMachine(typeof(_003CDoBarColorAnim_003Ed__16))]
		private IEnumerator DoBarColorAnim(Color targetColor, float duration)
		{
			return null;
		}

		public override void SetBarColor(Color color)
		{
		}

		private void SetOverrideColor(Color color, float alpha)
		{
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private void UpdateColor()
		{
		}

		private Color GetCurrentColor(float percentage)
		{
			return default;
		}
	}
}
