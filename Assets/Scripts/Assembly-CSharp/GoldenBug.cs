using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GoldenBug : EnemyMovement
{
	[CompilerGenerated]
	private sealed class _003CArriveAtBeaconRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoldenBug _003C_003E4__this;

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
		public _003CArriveAtBeaconRoutine_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CFleeFromSpawnRoutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoldenBug _003C_003E4__this;

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
		public _003CFleeFromSpawnRoutine_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CWatchArriveRoutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoldenBug _003C_003E4__this;

		private float _003CarriveDistanceSqr_003E5__2;

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
		public _003CWatchArriveRoutine_003Ed__23(int _003C_003E1__state)
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

	public GameObject BeaconPortalPrefab;

	public int FleeRadius;

	public float BeaconMinBorderDistance;

	public float ArriveDistance;

	public float EscapeScaleDuration;

	public ParticleSystem EscapeParticles;

	private BeaconPortal _beacon;

	private Vector3 _fleePoint;

	private Vector3 _originalScale;

	private bool _escaped;

	private bool _arrivalStarted;

	private bool _scaleCached;

	private Coroutine _fleeRoutine;

	private Coroutine _arriveWatchRoutine;

	private Coroutine _escapeRoutine;

	private StatsEnemy _statsEnemy;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public override void OnEnableActivation()
	{
	}

	private void ResetForReuse()
	{
	}

	private void CacheOriginalScale()
	{
	}

	[IteratorStateMachine(typeof(_003CFleeFromSpawnRoutine_003Ed__21))]
	private IEnumerator FleeFromSpawnRoutine()
	{
		return null;
	}

	private void SpawnBeacon(Vector3 farPoint)
	{
	}

	[IteratorStateMachine(typeof(_003CWatchArriveRoutine_003Ed__23))]
	private IEnumerator WatchArriveRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CArriveAtBeaconRoutine_003Ed__24))]
	private IEnumerator ArriveAtBeaconRoutine()
	{
		return null;
	}

	private void OnBugKilled()
	{
	}

	private void StopArriveWatch()
	{
	}

	private void StopAllBugRoutines()
	{
	}

	private void CleanupBeaconImmediate()
	{
	}
}
