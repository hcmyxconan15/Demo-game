using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

public class CameraEnemyFocus : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFocusRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CameraEnemyFocus _003C_003E4__this;

		public Transform enemyTransform;

		private Transform _003CplayerTransform_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

		private float _003Celapsed_003E5__4;

		private float _003CmoveDuration_003E5__5;

		private Vector3 _003CreturnStart_003E5__6;

		private Vector3 _003CreturnTarget_003E5__7;

		private float _003CreturnDuration_003E5__8;

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
		public _003CFocusRoutine_003Ed__28(int _003C_003E1__state)
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

	public bool FollowTarget;

	public Transform CameraTransformToLookAndFollow;

	public Transform Target;

	public GameObject EnemyFocusCamera;

	public float FocusDuration;

	public float CameraMoveDuration;

	public float FocusVignetteIntensity;

	public float PostFocusImmuneTime;

	private bool _isFocusing;

	private bool _waitingForNodeFocus;

	private bool _nodeFocusPlayed;

	private bool _followDuringFocus;

	private CinemachineBrain _brain;

	private bool _previousIgnoreTimeScale;

	private EnemyBase _pendingEnemy;

	public bool IsFocusing => false;

	public bool HasPendingFocus => false;

	public bool BlocksRewards => false;

	public void SetTarget(Transform target)
	{
	}

	public void BeginNodeFocusGate()
	{
	}

	public void EndNodeFocusGate()
	{
	}

	public void NotifySpecialSpawnAttempted()
	{
	}

	public void TryFocusSpecialEnemy(EnemyBase enemy)
	{
	}

	public bool TryStartPendingFocus()
	{
		return false;
	}

	private void StartFocus(Transform enemyTransform)
	{
	}

	[IteratorStateMachine(typeof(_003CFocusRoutine_003Ed__28))]
	private IEnumerator FocusRoutine(Transform enemyTransform)
	{
		return null;
	}

	private static void FaceEnemyTowardPlayer(Transform enemyTransform, Transform playerTransform)
	{
	}

	private static bool IsRewardPanelActivelyOpen()
	{
		return false;
	}

	private static bool HasHardUiBlocking()
	{
		return false;
	}

	private static bool ShouldKeepPausedAfterFocus()
	{
		return false;
	}

	private void LateUpdate()
	{
	}
}
