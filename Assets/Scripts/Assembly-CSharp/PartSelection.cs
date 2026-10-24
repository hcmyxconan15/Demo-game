using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PartSelection : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdateLayoutGroups_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PartSelection _003C_003E4__this;

		private List<LayoutGroup>.Enumerator _003C_003E7__wrap1;

		private LayoutGroup _003ClayoutGroup_003E5__3;

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
		public _003CUpdateLayoutGroups_003Ed__4(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public List<LayoutGroup> LayoutGroups;

	public InOutFromLeft InOutFromLeft;

	private bool _open;

	public void OpenPartsPanel(bool open)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateLayoutGroups_003Ed__4))]
	private IEnumerator UpdateLayoutGroups()
	{
		return null;
	}
}
