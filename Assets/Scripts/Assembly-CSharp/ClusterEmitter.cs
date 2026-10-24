using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ClusterEmitter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSpawner_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClusterEmitter _003C_003E4__this;

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
		public _003CSpawner_003Ed__10(int _003C_003E1__state)
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

	public List<Transform> Clusters;

	private List<Transform> _clusters;

	private List<float> _clustersLifetime;

	public int MaxClusters;

	public float ClusterAcceleration;

	public float SpawnRate;

	public float LifeTime;

	public Vector2 Size;

	public Vector2 Shape;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawner_003Ed__10))]
	private IEnumerator Spawner()
	{
		return null;
	}

	private void Update()
	{
	}
}
