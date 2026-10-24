using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnParts : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CHideParts_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpawnParts _003C_003E4__this;

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
		public _003CHideParts_003Ed__16(int _003C_003E1__state)
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

	public int MonsterPartId;

	public float TimeToHide;

	public float HideOnGroundTimer;

	public float ExplosionForce;

	public float ExplosionRadius;

	public float UpwardModifier;

	public Transform CenterPont;

	public List<Transform> PartTransforms;

	public List<Rigidbody> PartRigidbodies;

	private List<Vector3> _partInitialPosition;

	private List<Quaternion> _partInitialRotations;

	private List<Collider> _partColliders;

	[Header("Effects")]
	public List<ParticleSystem> EffectsParticles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CHideParts_003Ed__16))]
	private IEnumerator HideParts()
	{
		return null;
	}
}
