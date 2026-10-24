using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class MoveShipMainMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayWhenStartPanelReady_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoveShipMainMenu _003C_003E4__this;

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
		public _003CPlayWhenStartPanelReady_003Ed__11(int _003C_003E1__state)
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

	public float Duration;

	public float Delay;

	public float Distance;

	public StartPanel StartPanel;

	private Sequence _arrival;

	private MoveCameraMouseTool _mouseTool;

	private bool _resumeMouseTool;

	private Vector3 _endPosition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayBack()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayWhenStartPanelReady_003Ed__11))]
	private IEnumerator PlayWhenStartPanelReady()
	{
		return null;
	}

	private void PlayArrival()
	{
	}

	private void OnArrived()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
