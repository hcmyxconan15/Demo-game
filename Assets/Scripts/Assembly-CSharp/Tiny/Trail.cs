using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Tiny
{
	public class Trail : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPhysicsUpdate_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Trail _003C_003E4__this;

			private YieldInstruction _003Cwait_003E5__2;

			private Action _003Caction_003E5__3;

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
			public _003CPhysicsUpdate_003Ed__27(int _003C_003E1__state)
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
		private sealed class _003CStart_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Trail _003C_003E4__this;

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
			public _003CStart_003Ed__21(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("The material to apply to the trail.")]
		private Material material;

		[SerializeField]
		[Tooltip("Define the lifetime of a point in the trail, in seconds.")]
		private float duration;

		[SerializeField]
		[Tooltip("Start delay before the trail starts drawing.")]
		private float StartDelay;

		[SerializeField]
		[Tooltip("Increase this value to make the trail corners appear rounder.")]
		private int corner;

		[SerializeField]
		[Tooltip("Enable this to connect the first and last positions of the line, and form a closed loop.")]
		private bool loop;

		[SerializeField]
		[Tooltip("The array of Vector3 points to connect.")]
		private Vector3[] points;

		[NonSerialized]
		private GameObject trailGo;

		[NonSerialized]
		private Mesh mesh;

		[NonSerialized]
		private Vector3[] vertices;

		[NonSerialized]
		private Transform cacheTM;

		[NonSerialized]
		private int lastSegmentCount;

		[NonSerialized]
		private int lastCorner;

		[NonSerialized]
		private int pointCount;

		[NonSerialized]
		private float toCornerT;

		private Coroutine update;

		public Vector3[] Points
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Loop => false;

		public void Clear()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__21))]
		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetVerticesAndCorner()
		{
		}

		private void SetVertices()
		{
		}

		[IteratorStateMachine(typeof(_003CPhysicsUpdate_003Ed__27))]
		private IEnumerator PhysicsUpdate()
		{
			return null;
		}

		private void LateUpdate()
		{
		}

		private void TransformVertices()
		{
		}

		private void ClearVertices()
		{
		}

		private void Initialize(int segment)
		{
		}

		private static Vector3 CatmullRomSpline(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default;
		}
	}
}
