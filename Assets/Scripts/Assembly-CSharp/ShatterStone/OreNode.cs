using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShatterStone
{
	public class OreNode : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAnimate_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OreNode _003C_003E4__this;

			private Transform _003CanimatedTransform_003E5__2;

			private Quaternion _003CoriginalRotation_003E5__3;

			private Quaternion _003CknockRotation_003E5__4;

			private float _003Ct_003E5__5;

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
			public _003CAnimate_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CDelayDestroy_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OreNode _003C_003E4__this;

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
			public _003CDelayDestroy_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CResetAsync_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float respawnDelay;

			public OreNode _003C_003E4__this;

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
			public _003CResetAsync_003Ed__37(int _003C_003E1__state)
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

		[Header("Drop Settings")]
		[SerializeField]
		protected GameObject pieces;

		[SerializeField]
		protected GameObject refinedPickup;

		[SerializeField]
		[Min(0f)]
		protected int dropOnHit;

		[SerializeField]
		[Min(1f)]
		protected int hitsToDestroy;

		[SerializeField]
		[Min(0f)]
		protected int dropOnDestroy;

		[Header("Knockback Settings")]
		[SerializeField]
		protected Vector3 knockAngle;

		[SerializeField]
		protected AnimationCurve knockCurve;

		[SerializeField]
		protected float knockDuration;

		[Header("Respawn Settings")]
		[SerializeField]
		protected bool enableRespawn;

		[SerializeField]
		protected float respawnDelay;

		[Header("Configuration")]
		[SerializeField]
		protected bool cacheVisualBoundaries;

		[SerializeField]
		protected MiningNodeAudio nodeAudio;

		[SerializeField]
		protected Collider nodeCollider;

		[SerializeField]
		protected Renderer[] childRenderers;

		[SerializeField]
		protected Transform modelTransform;

		private OreNodeBounds nodeBounds;

		private int hitIndex;

		private const float DelayDestroySeconds = 5f;

		public bool IsDestroyed => false;

		public int HitIndex => 0;

		public int HitsToDestroy => 0;

		protected virtual void Start()
		{
		}

		public virtual void Interact()
		{
		}

		public virtual void Interact(int hits)
		{
		}

		[Obsolete("Use Interact(hits) instead")]
		public void oreHit()
		{
		}

		protected virtual int GetDropCount(int hits)
		{
			return 0;
		}

		protected virtual bool ShouldCalculateNodeBounds()
		{
			return false;
		}

		protected virtual OreNodeBounds CalculateNodeBounds()
		{
			return default;
		}

		protected virtual void InflictHit(int dropCount)
		{
		}

		protected virtual void SpawnDrop(Vector3 dropPos)
		{
		}

		protected virtual Vector3 CalculateRandomDropPosition(OreNodeBounds bounds)
		{
			return default;
		}

		protected virtual void ReplaceNodeVisualsWithBrokenOne()
		{
		}

		protected virtual void OnPiecesInstantiated(GameObject shatteredPieces)
		{
		}

		[IteratorStateMachine(typeof(_003CAnimate_003Ed__35))]
		protected virtual IEnumerator Animate()
		{
			return null;
		}

		public virtual void ResetNode(float respawnDelay)
		{
		}

		[IteratorStateMachine(typeof(_003CResetAsync_003Ed__37))]
		public virtual IEnumerator ResetAsync(float respawnDelay)
		{
			return null;
		}

		public virtual void ResetMiningState()
		{
		}

		protected virtual void RevertToInitialState()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayDestroy_003Ed__41))]
		protected virtual IEnumerator DelayDestroy()
		{
			return null;
		}
	}
}
