using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TreeOnMap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFallTree_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TreeOnMap _003C_003E4__this;

		public Vector3 fallDirection;

		private Quaternion _003CstartRot_003E5__2;

		private Quaternion _003CendRot_003E5__3;

		private Vector3 _003CstartPos_003E5__4;

		private Vector3 _003CendPos_003E5__5;

		private float _003Celapsed_003E5__6;

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
		public _003CFallTree_003Ed__9(int _003C_003E1__state)
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

	public bool Destroyed;

	public bool DestroyAtStart;

	public float FallDuration;

	public float FallAngle;

	public float LiftHeight;

	public MeshRenderer OriginalMeshRender;

	public Transform DestructiblePart;

	public RuntimeMeshDestruction RuntimeMeshDestruction;

	private void OnTriggerEnter(Collider other)
	{
	}

	[IteratorStateMachine(typeof(_003CFallTree_003Ed__9))]
	private IEnumerator FallTree(Vector3 fallDirection)
	{
		return null;
	}
}
