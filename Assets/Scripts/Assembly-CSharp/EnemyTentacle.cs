using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyTentacle : MonoBehaviour
{
	public enum EnemyPhases
	{
		UnderGround = 0,
		Idle = 1,
		Attacking = 2,
		Dead = 3
	}

	[CompilerGenerated]
	private sealed class _003CAttacking_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CAttacking_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CBurrowRoutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CBurrowRoutine_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CCycleRoutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CCycleRoutine_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CIdleAttack_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CIdleAttack_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CIdleRoutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CIdleRoutine_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CRelocateAndEmergeRoutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

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
		public _003CRelocateAndEmergeRoutine_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CWaitForCurrentAnimation_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

		public float minimumTime;

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
		public _003CWaitForCurrentAnimation_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CWaitOrDead_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyTentacle _003C_003E4__this;

		public float duration;

		private float _003Celapsed_003E5__2;

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
		public _003CWaitOrDead_003Ed__38(int _003C_003E1__state)
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

	public float DistanceToAttack;

	public float AnimationTime;

	public float IdleTime;

	public float HideAnimationTime;

	public float UndergroundTime;

	public float AlertTime;

	public float EmergeAnimationTime;

	public int AlertId;

	public Transform Body;

	public float BodyRotationSpeed;

	public EnemyPhases CurrentPhase;

	public EnemyMovement EnemyMovement;

	[Header("Range check")]
	[SerializeField]
	private float RangeCheckInterval;

	private const float TargetMoveThresholdSqr = 4f;

	private const float NavMeshSampleRadius = 3f;

	private const int RingSampleCount = 8;

	private static readonly List<EnemyTentacle> ActiveTentacles;

	private BarsAlertComponent _barsAlertComponent;

	private Coroutine _attackRoutine;

	private float _rangeCheckTimer;

	private Vector3 _lastRangeCheckTargetPos;

	private bool _hasRangeCheckTargetPos;

	private float _distanceToAttackSqr;

	private float _idleElapsed;

	private bool _isEmerging;

	public bool IsActing => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void RotateBodyTowardsPlayer()
	{
	}

	[IteratorStateMachine(typeof(_003CCycleRoutine_003Ed__32))]
	private IEnumerator CycleRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRelocateAndEmergeRoutine_003Ed__33))]
	private IEnumerator RelocateAndEmergeRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIdleRoutine_003Ed__34))]
	private IEnumerator IdleRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBurrowRoutine_003Ed__35))]
	private IEnumerator BurrowRoutine()
	{
		return null;
	}

	private float GetRandomUndergroundTime()
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CWaitForCurrentAnimation_003Ed__37))]
	private IEnumerator WaitForCurrentAnimation(float minimumTime)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitOrDead_003Ed__38))]
	private IEnumerator WaitOrDead(float duration)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAttacking_003Ed__39))]
	private IEnumerator Attacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CIdleAttack_003Ed__40))]
	private IEnumerator IdleAttack()
	{
		return null;
	}

	private void Attack()
	{
	}

	private void TryAttackIfInRange()
	{
	}

	private bool ShouldEvaluateRangeToTarget()
	{
		return false;
	}

	private void WarpToEmergePosition()
	{
	}

	private Vector3 PickWarpPosition()
	{
		return default;
	}

	private Vector3 GetPredictedPlayerPosition(Vector3 playerPosition)
	{
		return default;
	}

	private bool TryRingSamples(Vector3 center, out Vector3 sampled)
	{
		sampled = default;
		return false;
	}

	private bool TryRingSamplesAtRadius(Vector3 center, float radius, out Vector3 sampled)
	{
		sampled = default;
		return false;
	}

	private bool TrySampleClearPosition(Vector3 intended, out Vector3 sampled)
	{
		sampled = default;
		return false;
	}

	private bool IsWarpPositionClear(Vector3 position)
	{
		return false;
	}

	private void SetBuried(bool buried)
	{
	}

	private void ShowAlert()
	{
	}

	private void HideAlert()
	{
	}

	private void OnShockStateChange(bool onShock)
	{
	}

	private bool TryHandleDeath()
	{
		return false;
	}

	private void SetDead()
	{
	}
}
