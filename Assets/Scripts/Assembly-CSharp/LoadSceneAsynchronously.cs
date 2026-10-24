using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneAsynchronously : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDismissLoadingScreen_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadSceneAsynchronously _003C_003E4__this;

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
		public _003CDismissLoadingScreen_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CLoadAndActivateScene_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string sceneName;

		public LoadSceneMode mode;

		public LoadSceneAsynchronously _003C_003E4__this;

		public bool killTweensOnActivate;

		public bool disableFallbackCameraOnActivate;

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
		public _003CLoadAndActivateScene_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003CLoadScenesAsync_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadSceneAsynchronously _003C_003E4__this;

		public bool waitExtraCondition;

		public string sceneName;

		public string additiveSceneName;

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
		public _003CLoadScenesAsync_003Ed__15(int _003C_003E1__state)
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

	public const string GameplaySceneName = "GameplayScene";

	public bool IsSceneLoaded;

	public bool WaitLoad;

	[SerializeField]
	private GameObject LoadingScreen;

	[SerializeField]
	private Image LoadingScreenBackground;

	public static LoadSceneAsynchronously Instance;

	private bool _isLoading;

	private bool _loadFailed;

	private Camera _fallbackCamera;

	private AudioListener _fallbackListener;

	private void Awake()
	{
	}

	public static string GetPlanetSceneName()
	{
		return null;
	}

	public bool LoadScene(string sceneName, bool waitExtraCondition)
	{
		return false;
	}

	public bool LoadRunScenes(bool waitExtraCondition)
	{
		return false;
	}

	private bool BeginLoad(string sceneName, string additiveSceneName, bool waitExtraCondition)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CLoadScenesAsync_003Ed__15))]
	private IEnumerator LoadScenesAsync(string sceneName, string additiveSceneName, bool waitExtraCondition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadAndActivateScene_003Ed__16))]
	private IEnumerator LoadAndActivateScene(string sceneName, LoadSceneMode mode, bool killTweensOnActivate, bool disableFallbackCameraOnActivate = false)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDismissLoadingScreen_003Ed__17))]
	private IEnumerator DismissLoadingScreen()
	{
		return null;
	}

	private static bool CanLoadScene(string sceneName)
	{
		return false;
	}

	private void NotifyLoadFailed()
	{
	}

	private void EnsureFallbackCamera()
	{
	}

	private void SetFallbackCameraActive(bool active)
	{
	}
}
