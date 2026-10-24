using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PlayfulSystems.ProgressBar
{
	[RequireComponent(typeof(RectTransform))]
	public class BarViewScale : ProgressBarProView
	{
		[CompilerGenerated]
		private sealed class _003CDoBarScaleAnim_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarViewScale _003C_003E4__this;

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
			public _003CDoBarScaleAnim_003Ed__9(int _003C_003E1__state)
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
		protected RectTransform graphic;

		[Header("Color Options")]
		[Tooltip("If true, then the scale animates for each change. Otherwise it scales constantly based on value")]
		[SerializeField]
		private bool animateOnChange;

		[SerializeField]
		private Vector3 minSize;

		[SerializeField]
		private Vector3 maxSize;

		[Tooltip("A value of 0 is minSize, a value of 1 is maxSize. Time goes from 0 to 1.")]
		[SerializeField]
		private AnimationCurve scale;

		[SerializeField]
		private float animDuration;

		private Coroutine scaleAnim;

		private void OnEnable()
		{
		}

		public override void NewChangeStarted(float currentValue, float targetValue)
		{
		}

		[IteratorStateMachine(typeof(_003CDoBarScaleAnim_003Ed__9))]
		private IEnumerator DoBarScaleAnim(float duration)
		{
			return null;
		}

		public override void UpdateView(float currentValue, float targetValue)
		{
		}

		private void UpdateScale(float value = 0f)
		{
		}

		private Vector3 GetCurrentScale(float percentage)
		{
			return default;
		}
	}
}
