using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class InfoHelperSimple : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAvoidActivation_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InfoHelperSimple _003C_003E4__this;

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
		public _003CAvoidActivation_003Ed__18(int _003C_003E1__state)
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

	public bool AvoidUpdatePosition;

	public CanvasGroup CanvasGroup;

	public RectTransform MainCanvas;

	public RectTransform ComponentRectRectTransform;

	public RectTransform BackgroundRectTransform;

	public TextMeshProUGUI InfoText;

	[SerializeField]
	private Vector2 PaddingSize;

	private Vector2 _anchoredPosition;

	private Vector2 _textSize;

	private bool _avoidActivation;

	private float _safeTimer;

	private void Update()
	{
	}

	public void ActiveInfo(bool active)
	{
	}

	public void SetInfoText(string infoKey)
	{
	}

	public void SetInfoTextDirectText(string fullInfoString)
	{
	}

	public void SetInfoText(string infoKey, string plusString)
	{
	}

	private void ActiveCanvas(bool active)
	{
	}

	public void AvoidActivationByTime()
	{
	}

	[IteratorStateMachine(typeof(_003CAvoidActivation_003Ed__18))]
	private IEnumerator AvoidActivation()
	{
		return null;
	}
}
