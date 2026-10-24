using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Hovl
{
	public class HS_ObjectActivator : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CActivateObjectsWithDelay_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HS_ObjectActivator _003C_003E4__this;

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
			public _003CActivateObjectsWithDelay_003Ed__22(int _003C_003E1__state)
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

		[Header("Targets")]
		[SerializeField]
		private List<Renderer> targetRenderers;

		[SerializeField]
		private Collider targetCollider;

		[SerializeField]
		private List<ParticleSystem> targetParticleSystems;

		[SerializeField]
		private List<GameObject> objectsToToggle;

		[Header("Shader")]
		[SerializeField]
		private string shaderProperty;

		[Header("Animation")]
		[SerializeField]
		private float transitionSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float colliderDisableValue;

		[Header("Objects Toggle")]
		[SerializeField]
		private float objectsActivateDelay;

		private MaterialPropertyBlock propertyBlock;

		private int propertyID;

		private float currentValue;

		private float targetValue;

		private bool isOn;

		private bool particlesPlaying;

		private bool objectsActive;

		private Coroutine objectsActivateCoroutine;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void ApplyValue(float value)
		{
		}

		private void UpdateColliderState(bool forceUpdate)
		{
		}

		private void UpdateParticlesState(bool forceUpdate)
		{
		}

		private void UpdateObjectsState(bool forceUpdate)
		{
		}

		[IteratorStateMachine(typeof(_003CActivateObjectsWithDelay_003Ed__22))]
		private IEnumerator ActivateObjectsWithDelay()
		{
			return null;
		}

		private void CancelObjectsActivation()
		{
		}

		private void PlayParticles()
		{
		}

		private void StopParticles()
		{
		}

		private void SetObjectsActive(bool state)
		{
		}

		private void RemoveNullRenderers()
		{
		}

		private void RemoveNullParticles()
		{
		}

		private void RemoveNullObjects()
		{
		}
	}
}
