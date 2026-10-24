using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Hovl
{
	public class HS_TargetShooting : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFlashRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public HS_TargetShooting _003C_003E4__this;

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
			public _003CFlashRoutine_003Ed__29(int _003C_003E1__state)
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

		[Header("Target")]
		public Collider targetCollider;

		[Header("Projectile")]
		public GameObject projectilePrefab;

		public Transform firePoint;

		public int poolSize;

		[Header("Shooting")]
		public float shootingRate;

		public bool shootOnStart;

		[Header("Rotation")]
		public bool rotateToTarget;

		[Header("Flash Material")]
		public MeshRenderer targetMeshRenderer;

		public int materialIndex;

		public string colorPropertyName;

		public Color shootFlashColor;

		public float flashDuration;

		private readonly List<GameObject> projectilePool;

		private float shootTimer;

		private float shootInterval;

		private Vector3 currentTargetPoint;

		private Material runtimeMaterialInstance;

		private Color originalColor;

		private bool hasValidColorProperty;

		private Coroutine flashRoutine;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void CreatePool()
		{
		}

		private GameObject GetPooledProjectile()
		{
			return null;
		}

		private void Shoot(Vector3 targetPoint)
		{
		}

		private void RotateToPoint(Vector3 point)
		{
		}

		private Vector3 GetRandomPointOnCollider(Collider col)
		{
			return default;
		}

		private void SetupMaterialInstance()
		{
		}

		private void TriggerFlash()
		{
		}

		[IteratorStateMachine(typeof(_003CFlashRoutine_003Ed__29))]
		private IEnumerator FlashRoutine()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
