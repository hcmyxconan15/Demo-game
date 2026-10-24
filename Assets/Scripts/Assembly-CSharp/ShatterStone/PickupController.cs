using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ShatterStone
{
	public class PickupController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCollectDestroy_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform target;

			private float _003Cduration_003E5__2;

			private float _003Celapsed_003E5__3;

			private Vector3 _003CstartPos_003E5__4;

			private Vector3 _003CendPos_003E5__5;

			private Vector3 _003CstartScale_003E5__6;

			private Vector3 _003CendScale_003E5__7;

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
			public _003CCollectDestroy_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CDespawnTimer_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PickupController _003C_003E4__this;

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
			public _003CDespawnTimer_003Ed__19(int _003C_003E1__state)
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
		private sealed class _003CSpawnAnimate_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PickupController _003C_003E4__this;

			private float _003Ct_003E5__2;

			private Vector3 _003Corigin_003E5__3;

			private Vector3 _003CjumpTo_003E5__4;

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
			public _003CSpawnAnimate_003Ed__14(int _003C_003E1__state)
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

		[Header("Animation Settings")]
		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private float jumpDistance;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		private float spinRate;

		[SerializeField]
		private AnimationCurve jumpCurve;

		[Space]
		[Header("Despawn Settings")]
		[SerializeField]
		private bool enableDespawn;

		[SerializeField]
		private float timeToDespawn;

		[Space]
		[Header("Audio Settings")]
		[SerializeField]
		private float volume;

		[SerializeField]
		private Vector2 pitchRange;

		[SerializeField]
		private AudioClip[] pickupClips;

		private bool jumpTrigger;

		private AudioSource audioSource;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnAnimate_003Ed__14))]
		private IEnumerator SpawnAnimate()
		{
			return null;
		}

		public void CollectItem()
		{
		}

		[IteratorStateMachine(typeof(_003CCollectDestroy_003Ed__16))]
		public IEnumerator CollectDestroy(Transform target)
		{
			return null;
		}

		private void PlayRandomClip(AudioClip[] clipArray)
		{
		}

		public void DespawnItem()
		{
		}

		[IteratorStateMachine(typeof(_003CDespawnTimer_003Ed__19))]
		private IEnumerator DespawnTimer()
		{
			return null;
		}
	}
}
