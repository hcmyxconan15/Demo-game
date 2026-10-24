using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpenDropDownComponent_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DropdownController _003C_003E4__this;

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
		public _003COpenDropDownComponent_003Ed__17(int _003C_003E1__state)
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

	public TMP_Dropdown DropdownToChange;

	public DropdownComponent DropdownComponentPrefab;

	public Transform OptionsParent;

	public CanvasGroup CanvasGroup;

	public List<DropdownComponent> DropdownComponents;

	public MenuNavigation DropDownMenuNavigation;

	public MenuNavigation ParentMenuNavigation;

	public float ScrollSpeed;

	public ScrollRect ScrollRect;

	public bool IsOpen => false;

	public void OpenDropDown()
	{
	}

	public void CloseDropDown()
	{
	}

	public void ForceClose()
	{
	}

	public void SelectThisIndex(int index)
	{
	}

	private void ActiveCanvasGroup(bool active)
	{
	}

	public void ScrollTo(RectTransform target)
	{
	}

	[IteratorStateMachine(typeof(_003COpenDropDownComponent_003Ed__17))]
	private IEnumerator OpenDropDownComponent()
	{
		return null;
	}
}
