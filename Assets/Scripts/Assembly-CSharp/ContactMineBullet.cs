using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ContactMineBullet : DamageBase, IOverloadDeployable
{
	[CompilerGenerated]
	private sealed class _003CDeployToDestination_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ContactMineBullet _003C_003E4__this;

		private Vector3 _003Cstart_003E5__2;

		private float _003Celapsed_003E5__3;

		private Vector3 _003CpreviousPosition_003E5__4;

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
		public _003CDeployToDestination_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003CManageLifetime_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ContactMineBullet _003C_003E4__this;

		private WaitForSeconds _003Cwait_003E5__2;

		private float _003Celapsed_003E5__3;

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
		public _003CManageLifetime_003Ed__59(int _003C_003E1__state)
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

	public MineLandingMode LandingMode;

	public float PerimeterRadius;

	public float ThrowRadiusMin;

	public float ThrowRadiusMax;

	public float ContactTriggerRadius;

	public float DamageRadius;

	public float ContactCheckInterval;

	public float DeployTravelTime;

	public float DeployArcHeight;

	[Tooltip("Random angle offset within each ring sector (0-1 = fraction of sector width).")]
	[Range(0f, 1f)]
	public float LandingAngleJitterFactor;

	[Tooltip("Random radius offset applied around PerimeterRadius.")]
	public float LandingRadiusJitter;

	[Tooltip("Extra horizontal offset around the slot landing point.")]
	public float LandingPositionJitter;

	[Tooltip("Min XZ distance between dash-burst mine landings from the same trigger.")]
	public float BurstLandingSeparation;

	public Transform MineBody;

	[Tooltip("Extra local Y spin during deploy arc (degrees/sec). 0 = only turn to face travel direction.")]
	public float DeployBodySpinSpeed;

	public float LandingScaleMultiplier;

	public float LandingScaleUpDuration;

	public float LandingScaleDownDuration;

	public LayerMask RayCasterLayer;

	public ParticleSystem ParticleSystem;

	public short LandEffectId;

	public short EffectId;

	public List<int> ExplosionSoundIds;

	private int _overloadId;

	private int _slotIndex;

	private int _maxSlots;

	private float _maxLifetime;

	private Transform _deployAnchor;

	private bool _useFixedLandingAnchor;

	private Vector3 _fixedLandingAnchor;

	private List<Vector3> _burstReservedLandings;

	private float _burstLandingSeparation;

	private Vector3 _launchOrigin;

	private Vector3 _landingPosition;

	private Vector3 _mineBodyOriginalLocalScale;

	private Quaternion _mineBodyBaseLocalRotation;

	private float _deployBodyYAngle;

	private float _deployBodySpinAngle;

	private bool _armed;

	private bool _exploded;

	private bool UsesSlotTracker => false;

	private void Awake()
	{
	}

	public void SetupDeployable(OverloadDeployContext context)
	{
	}

	private Vector3 GetLaunchOrigin()
	{
		return default;
	}

	private Vector3 GetLandingAnchor()
	{
		return default;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetMineBodyVisuals()
	{
	}

	private Vector3 GetLandingPosition()
	{
		return default;
	}

	private Vector3 GetRandomLandingAroundOrigin(Vector3 origin)
	{
		return default;
	}

	private Vector3 PickUniqueLandingAroundOrigin(Vector3 origin, List<Vector3> reserved, float minSeparation)
	{
		return default;
	}

	private static bool IsLandingFarEnough(Vector3 candidate, List<Vector3> reserved, float minSeparationSqr)
	{
		return false;
	}

	private static float GetMinLandingDistanceSqr(Vector3 candidate, List<Vector3> reserved)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CDeployToDestination_003Ed__54))]
	private IEnumerator DeployToDestination()
	{
		return null;
	}

	private void UpdateMineBodyFacing(Vector3 worldDirection, bool applySpin)
	{
	}

	private void FinalizeMineBodyFacing()
	{
	}

	private void PlayLandingScaleAnimation()
	{
	}

	private void ArmMine()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifetime_003Ed__59))]
	private IEnumerator ManageLifetime()
	{
		return null;
	}

	private bool HasEnemyInContactRange()
	{
		return false;
	}

	private void Explode(bool fromContact)
	{
	}

	public override void ApplyExpandDamage()
	{
	}
}
