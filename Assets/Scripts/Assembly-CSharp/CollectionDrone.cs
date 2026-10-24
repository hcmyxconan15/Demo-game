using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class CollectionDrone : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCollection_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CollectionDrone _003C_003E4__this;

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
		public _003CCollection_003Ed__16(int _003C_003E1__state)
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

	public CollectionObject TargetToCollect;

	public Transform ParentToLoad;

	public Animator ClawAnimator;

	public float MovementSpeedToCollect;

	public float MinRadius;

	public float MaxRadius;

	public float UpDistance;

	public Ease OutEase;

	public Ease InEase;

	private TweenerCore<Vector3, Vector3, VectorOptions> _tween;

	public void ActiveCollectionDrone(CollectionObject target)
	{
	}

	private void MoveToTarget()
	{
	}

	private void MoveUp()
	{
	}

	private void CollectTarget()
	{
	}

	public void CancelCollectionFor(CollectionObject target)
	{
	}

	private void EndCollection()
	{
	}

	[IteratorStateMachine(typeof(_003CCollection_003Ed__16))]
	private IEnumerator Collection()
	{
		return null;
	}
}
