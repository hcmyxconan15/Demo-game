using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InitGameServices : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InitGameServices _003C_003E4__this;

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
		public _003CInit_003Ed__9(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadSceneAsync_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InitGameServices _003C_003E4__this;

		public bool waitExtraCondition;

		public string sceneName;

		private AsyncOperation _003CasyncOperation_003E5__2;

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
		public _003CLoadSceneAsync_003Ed__11(int _003C_003E1__state)
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

	public bool IsSceneLoaded;

	public bool ReadyToMoveShips;

	public string SceneToLoad;

	public bool WaitLoad;

	public bool ReadyToStart;

	[SerializeField]
	private CanvasGroup LoadingScreenBackground;

	public static InitGameServices Instance;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CInit_003Ed__9))]
	public IEnumerator Init()
	{
		return null;
	}

	public void LoadScene(string sceneName, bool waitExtraCondition)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadSceneAsync_003Ed__11))]
	private IEnumerator LoadSceneAsync(string sceneName, bool waitExtraCondition)
	{
		return null;
	}
}
