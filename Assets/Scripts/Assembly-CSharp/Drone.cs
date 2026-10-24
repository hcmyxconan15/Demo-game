using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Drone : MonoBehaviour
{
	private enum CollectorState
	{
		Traveling = 0,
		Ascending = 1,
		Collecting = 2,
		Delivering = 3
	}

	[CompilerGenerated]
	private sealed class _003CDischargeCollectionBarsRoutine_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Drone _003C_003E4__this;

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
		public _003CDischargeCollectionBarsRoutine_003Ed__87(int _003C_003E1__state)
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

	public bool Active;

	public int DroneId;

	public int Level;

	public DroneRole Role;

	public bool IsSlotOwner;

	public float DroneFollowSpeed;

	[Header("Enemies")]
	public EnemyBase SelectedNearestTarget;

	public float RotationSpeed;

	public Transform TurretTargetToLook;

	public Transform TurretTransform;

	public List<Transform> TurretStartPosition;

	public Transform DroneToFollowPosition;

	public List<WeaponJoin> WeaponJoins;

	public MechPlayerController MechPlayerController;

	[Header("Main Menu Hover")]
	public Vector3 AxisToOscillate;

	public float OscillateAmplitude;

	public float OscillateFrequency;

	public Vector3 OscillateRotationAmplitude;

	public Vector3 OscillateRotationFrequency;

	[Header("Collector — timing / flight")]
	[Tooltip("How long the collect particle stays on before the drone leaves the pile (seconds).")]
	public float CollectionTime;

	[Tooltip("Delay after the collect particle starts before XP/coins begin getting pulled in (seconds).")]
	public float SuckStartDelay;

	[Tooltip("World Y height the drone climbs to above the pile before sucking loot.")]
	public float CollectHeight;

	[Header("Collector — search radii (from player)")]
	[Tooltip("MAX hunt range from the player. Drone only targets XP/coins inside this circle.")]
	public float CollectRadius;

	[Tooltip("Player 'easy pickup' dead zone. Drone prefers loot farther than this (up to CollectRadius). Also skips sucking items inside this distance of the player. Falls back to closer loot only if the outer ring is empty.")]
	public float CollectPreferMinRadius;

	[Header("Collector — suck / cargo")]
	[Tooltip("While hovering over a pile: horizontal radius around CollectCenter used to detect and pull nearby loot.")]
	public float CollectAbsorbRadius;

	[Tooltip("How many XP/coin pickups the drone can carry before it must return and deposit.")]
	public int CollectCapacity;

	[Tooltip("Combat only: max enemy search range. Unused by collector.")]
	public float DroneTargetRadius;

	[Tooltip("World point loot is pulled toward while sucking (intake).")]
	public Transform CollectorEndPosition;

	[Tooltip("VFX played for the full CollectionTime window while sucking.")]
	public ParticleSystem CollectParticleEffect;

	[Tooltip("Center used with CollectAbsorbRadius to detect loot under the drone.")]
	public Transform CollectCenter;

	[Header("Collection bars")]
	[Tooltip("World-space UI group for the collect progress bar. Alpha 0 when not collecting.")]
	public CanvasGroup CollectionBarsCanvasGroup;

	[Tooltip("Fills from 0 → CollectCapacity based on how many pickups the drone is currently carrying.")]
	public ProgressBarPro CollectionBars;

	public Outline DroneOutline;

	private const float CollectPickupRadius = 3f;

	private const float CollectAbsorbSnapRadius = 1.5f;

	private const float CollectDeliverStopMin = 3f;

	private const float CollectDeliverStopMax = 4f;

	private const float CollectMoveSpeed = 10f;

	private const float CollectDeliverMoveSpeed = 14f;

	private const float CollectPullSpeed = 16f;

	private const float MaxFollowSpeed = 3f;

	private const float MaxFollowStepPerSecond = 8f;

	private const float CollectionBarsDischargeDuration = 0.8f;

	private const float CollectionBarsDischargeHold = 0.4f;

	private const float CollectionBarsFadeOutDuration = 0.3f;

	private EnemyBase _lastSelectedNearestTarget;

	private EnemyBase _nearestTarget;

	private float _searchTimer;

	private float changeFollowSpeed;

	private Vector3 _collectTargetPosition;

	private bool _hasCollectTarget;

	private CollectorState _collectorState;

	private float _collectTimer;

	private int _cargoXp;

	private int _cargoCoins;

	private int _cargoCount;

	private bool _depositDoneThisTrip;

	private float _deliverStopRadius;

	private Vector3 _oscillateInitialLocalPosition;

	private Quaternion _oscillateInitialLocalRotation;

	private float _oscillateElapsed;

	private bool _oscillateWasActive;

	private bool _mainMenuHover;

	private Coroutine _collectionBarsDischargeCoroutine;

	private bool _collectionBarsDischarging;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void SetupFromStats(DroneStats stats)
	{
	}

	public void ActiveDrone(Transform toFollowTransform, bool mainMenuHover = false)
	{
	}

	public void ShotDroneWeapons()
	{
	}

	private void UpdateCombat()
	{
	}

	private void UpdateCollector()
	{
	}

	private void UpdateCollectorTraveling()
	{
	}

	private void UpdateCollectorAscending()
	{
	}

	private void BeginCollecting()
	{
	}

	private bool HasLootAtCollectSpot()
	{
		return false;
	}

	private float GetCollectPlayerAvoidRadius()
	{
		return 0f;
	}

	private void AbortCollectSpot()
	{
	}

	private void ReleaseCollectClaim()
	{
	}

	private void UpdateCollectorCollecting()
	{
	}

	private void BeginDelivery()
	{
	}

	private void RefreshCollectionBars()
	{
	}

	private void HideCollectionBars()
	{
	}

	private void PlayCollectionBarsDischarge()
	{
	}

	private void StopCollectionBarsDischarge()
	{
	}

	[IteratorStateMachine(typeof(_003CDischargeCollectionBarsRoutine_003Ed__87))]
	private IEnumerator DischargeCollectionBarsRoutine()
	{
		return null;
	}

	private void StopCollectParticle()
	{
	}

	private void UpdateCollectorDelivering()
	{
	}

	private void DepositCargoToPlayer()
	{
	}

	private void LookCollectorToward(Vector3 worldTarget)
	{
	}

	private void ResetMainMenuHover()
	{
	}

	private void UpdateMainMenuHover()
	{
	}

	private void RandomizeFollowSpeedIfNeeded()
	{
	}

	private void ClampFollowSpeed()
	{
	}

	private void MoveCollectorTowards(Vector3 target, float speed = 10f)
	{
	}

	private void KeepDroneCloseToRobot()
	{
	}

	private EnemyBase GetMoreCloseEnemy(float minDistance, float maxDistance)
	{
		return null;
	}
}
