using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShatterStone
{
	public class ShatterCleanUp : MonoBehaviour
	{
		private struct PieceData
		{
			public Transform transform;

			public Vector3 originalScale;

			public float startDelay;
		}

		[CompilerGenerated]
		private sealed class _003CHandleShrink_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShatterCleanUp _003C_003E4__this;

			private float _003Celapsed_003E5__2;

			private float _003CmaxDuration_003E5__3;

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
			public _003CHandleShrink_003Ed__7(int _003C_003E1__state)
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
		private float delayBeforeShrink;

		[SerializeField]
		private float shrinkDuration;

		[SerializeField]
		private float randomStartOffset;

		private List<PieceData> pieces;

		private void Start()
		{
		}

		private void CollectPiecesRecursive(Transform current)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleShrink_003Ed__7))]
		private IEnumerator HandleShrink()
		{
			return null;
		}
	}
}
