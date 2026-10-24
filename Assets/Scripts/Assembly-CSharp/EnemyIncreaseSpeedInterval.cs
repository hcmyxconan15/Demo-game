using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyIncreaseSpeedInterval : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CIncreaseSpeedRoutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyIncreaseSpeedInterval _003C_003E4__this;

		private NavMeshAgent _003Cagent_003E5__2;

		private float _003Cremaining_003E5__3;

		private float _003CrecoverRemaining_003E5__4;

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
		public _003CIncreaseSpeedRoutine_003Ed__18(int _003C_003E1__state)
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

	public float SpeedIncreaseStarDistance;

	public float SpeedIncreaseValue;

	public float SpeedIncreaseTime;

	public float RecoverTime;

	public CanvasGroup SpeedBarCanvasGroup;

	public CanvasGroup FullCanvasGroup;

	public ProgressBarPro SpeedBar;

	public EnemyMovement EnemyMovement;

	public ParticleSystem EndSpeedEffect;

	public ParticleSystem SpeedEffect;

	private static readonly int Disable;

	private float _baseSpeed;

	private bool _active;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void IncreaseSpeed()
	{
	}

	public void StopParticles()
	{
	}

	[IteratorStateMachine(typeof(_003CIncreaseSpeedRoutine_003Ed__18))]
	private IEnumerator IncreaseSpeedRoutine()
	{
		return null;
	}

	private bool CanActivate()
	{
		return false;
	}

	private bool ShouldInterrupt()
	{
		return false;
	}

	private bool IsPlayerInRange()
	{
		return false;
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private void RestoreMovementState()
	{
	}

	private void SetSpeedBarActive(bool active)
	{
	}

	private void SetDisabled(bool disabled)
	{
	}
}
