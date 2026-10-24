using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

public class EnemiesController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRelocateFarEnemiesOutsidePlayerViewSpreadRoutine_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemiesController _003C_003E4__this;

		private Vector3 _003CplayerPos_003E5__2;

		private float _003CfarSqr_003E5__3;

		private bool _003CenforceSpawnDisk_003E5__4;

		private int _003Cmoved_003E5__5;

		private EnemyBase[] _003C_003E7__wrap5;

		private int _003C_003E7__wrap6;

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
		public _003CRelocateFarEnemiesOutsidePlayerViewSpreadRoutine_003Ed__98(int _003C_003E1__state)
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

	public bool EnemyControllerActive;

	public float SpawnRadius;

	[Tooltip("Sampled points closer than this to any NavMesh edge are discarded (retries up to maxAttempts).")]
	public float MinDistanceFromNavMeshBorder;

	[Tooltip("Item drops (chests) must stay at least this far from NavMesh edges/corners.")]
	public float MinItemDropDistanceFromNavMeshBorder;

	[Tooltip("Reject item-drop samples farther than this (horizontal XZ) from the death position. Prevents chests snapping toward map center at corners.")]
	public float MaxItemDropDistanceFromAnchor;

	[Tooltip("Reject NavMesh.SamplePosition results that slid farther than this (horizontal XZ) from the intended ring point. Prevents snapping toward map interior when sampling near corners.")]
	public float MaxHorizontalNavMeshSnap;

	[Tooltip("Larger search when sampling directly at the player as a last resort (e.g. map corners).")]
	public float NavMeshFallbackSearchRadius;

	[Header("Enemy spawn & relocate ring")]
	[Tooltip("Horizontal distance from player for normal enemy spawns (ActiveEnemy). Relocation never places enemies closer than this.")]
	public float EnemySpamRadius;

	[Header("Relocate distant enemies")]
	[Tooltip("Alive enemies farther than this from the player are candidates for relocation.")]
	public float RelocateFarEnemyDistanceThreshold;

	[FormerlySerializedAs("MaxSummonRadiusOutsideView")]
	[Tooltip("Relocation samples a random horizontal distance from the player between EnemySpamRadius and this (keep below far threshold for a real pull-in).")]
	public float MaxRelocateRingRadius;

	[Tooltip("Attempts per enemy to find a valid NavMesh point in the relocate ring.")]
	public int RelocateMaxAttemptsPerEnemy;

	[Tooltip("Max successful teleports per call (0 = no limit). Keeps NavMesh spikes small when many enemies are far.")]
	public int MaxEnemiesRelocatedPerPass;

	[Header("Spatial grid (targeting)")]
	[Tooltip("XZ cell size for enemy targeting queries. ~12m works well for typical weapon ranges.")]
	public float SpatialGridCellSize;

	[Tooltip("Seconds between spatial grid refresh passes. 0 = refresh every frame. Small values (0.05-0.15) cut per-frame cost with large hordes; targeting stays accurate because queries re-check exact distances.")]
	public float SpatialGridRefreshInterval;

	[Header("Missile targeting")]
	[Tooltip("Maximum missile spatial retarget searches per frame. 0 = no limit.")]
	public int MaxMissileRetargetQueriesPerFrame;

	[Header("Offscreen enemy LOD (normal enemies only)")]
	[Tooltip("How often to test whether normal enemies are inside the gameplay camera view.")]
	public float OffscreenLodUpdateInterval;

	[Tooltip("Approximate enemy radius used for the camera visibility test (avoids collider.bounds).")]
	public float OffscreenLodVisibilityRadius;

	[Tooltip("Extra radius added so enemies restore AI shortly before entering the camera.")]
	public float OffscreenLodWakeBoundsPadding;

	[Tooltip("Highest NavMesh obstacle avoidance quality allowed for normal enemies. High quality is very CPU-heavy when agents cluster near the player; prefabs set above this are capped at runtime.")]
	public ObstacleAvoidanceType MaxNormalEnemyAvoidanceQuality;

	public MechPlayerController MechPlayerController;

	public AdvanceMapConditionsController AdvanceMapConditionsController;

	public HashSet<EnemyBase> Enemies;

	public HashSet<EnemyBase> AliveEnemies;

	public EnemiesDb EnemiesDb;

	private EnemyBase _nearestTarget;

	private Vector3 _difference;

	[Header("Enemies data")]
	public TextMeshProUGUI EnemyCountText;

	public int EnemyKilledCount;

	public int EnemiesCount;

	public int AliveEnemiesCount;

	public static EnemiesController Instance;

	public Dictionary<EnemyData.EnemyType, int> EnemyKillCounters;

	public Dictionary<int, int> EnemyKillCountersById;

	private readonly Dictionary<int, Stack<EnemyBase>> _enemyPoolById;

	private readonly Dictionary<int, int> _aliveCountByEnemyId;

	private readonly HashSet<EnemyBase> _pendingPoolReturn;

	private readonly List<EnemyBase> _staleAliveEnemies;

	private EnemySpatialGrid _spatialGrid;

	private readonly List<EnemyBase> _spatialQueryBuffer;

	private NavMeshPath _reachabilityPath;

	private const float EnemyCountTextUpdateInterval = 0.1f;

	private const float StaleAliveEnemyPruneInterval = 0.25f;

	private float _stalePruneTimer;

	private float _lastEnemyCountTextUpdateTime;

	private bool _enemyCountTextDirty;

	private float _offscreenLodUpdateTimer;

	private float _spatialRefreshTimer;

	private int _missileRetargetFrame;

	private int _missileRetargetQueriesThisFrame;

	private readonly Plane[] _cameraFrustumPlanes;

	private float _offscreenLodVisibilityExtent;

	private Camera _mainPlayerCamera;

	private const float NavMeshSampleRadius = 10f;

	private const int ReachabilityPathQueryBudget = 12;

	private const int ItemDropNavMeshMaxAttempts = 6;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	public void PreloadMapEnemies(EnemySetupToSelect enemySetupToSelect)
	{
	}

	public void EnemyKilled(EnemyBase enemyBase)
	{
	}

	public void EnemyKilledByOthers(EnemyBase enemyBase)
	{
	}

	public int GetPlayerDistance(Transform startPointTransform)
	{
		return 0;
	}

	public EnemyBase ActiveEnemy(int enemyId, bool needForNodeQuest)
	{
		return null;
	}

	public EnemyBase ActiveEnemyInCustomPosition(int enemyId, Vector3 positionToAdd, Quaternion enemyRotation)
	{
		return null;
	}

	public int GetAliveEnemyCount(int enemyId)
	{
		return 0;
	}

	private EnemyBase RentInactiveEnemy(int enemyId)
	{
		return null;
	}

	private EnemyBase CreateEnemy(int enemyId)
	{
		return null;
	}

	private bool TryRegisterActivatedEnemy(EnemyBase enemy)
	{
		return false;
	}

	private static bool IsEnemyActiveAndAlive(EnemyBase enemy)
	{
		return false;
	}

	private void PushToEnemyPool(EnemyBase enemy)
	{
	}

	public void ClearAliveQuestEnemyFlags()
	{
	}

	public void DeActiveEnemy(EnemyBase enemy)
	{
	}

	public void TryReturnEnemyToPool(EnemyBase enemy)
	{
	}

	private void SchedulePoolReturn(EnemyBase enemy)
	{
	}

	private void PruneStaleAliveEnemies()
	{
	}

	public EnemyBase GetMoreCloseEnemy(float minDistance, float maxDistance, bool preferSpecialEnemies)
	{
		return null;
	}

	public EnemyBase GetRandomEnemyOnMapByRange(float minDistance, float maxDistance)
	{
		return null;
	}

	public bool TryConsumeMissileRetargetQuery()
	{
		return false;
	}

	public EnemyBase GetCloseEnemyToPosition(Transform pointPosition, float minDistance, float maxDistance)
	{
		return null;
	}

	public EnemyBase GetCloseEnemyToPosition(Transform pointPosition, float minDistance, float maxDistance, bool horizontalOnly)
	{
		return null;
	}

	private static float HorizontalSqrDistance(float ax, float az, float bx, float bz)
	{
		return 0f;
	}

	public EnemyBase GetCloseEnemyToPositionEnemy(HashSet<EnemyBase> excludedEnemies, EnemyBase anchorEnemy, float minDistance, float maxDistance)
	{
		return null;
	}

	private bool ShouldApplySpawnRadiusConstraint(Vector3 anchorPosition)
	{
		return false;
	}

	private bool IsWorldPositionInsideSpawnDisk(Vector3 worldPos)
	{
		return false;
	}

	private Vector3 ClampHorizontalToSpawnDisk(Vector3 worldPos)
	{
		return default;
	}

	private bool TrySampleNavMeshNearIntendedPoint(Vector3 intendedWorldPoint, float searchRadius, out NavMeshHit hit)
	{
		hit = default;
		return false;
	}

	private bool TrySampleFallbackPoint(Vector3 sampleAt, float searchRadius, float minBorderDist, out Vector3 position, out bool meetsConstraints)
	{
		position = default;
		meetsConstraints = default;
		return false;
	}

	private Vector3 FallbackNavMeshClosestToAnchor(Vector3 anchorPosition)
	{
		return default;
	}

	public Vector3 GetPointAroundPlayer()
	{
		return default;
	}

	public Vector3 GetPointAroundPlayer(float radius, int maxAttempts = 16)
	{
		return default;
	}

	public Vector3 GetPointAroundPosition(int radius, Transform transformPosition)
	{
		return default;
	}

	public Vector3 GetPointAroundPositionAndInsideMapRadius(float radius, Transform transformPosition, int maxAttempts = 16)
	{
		return default;
	}

	private bool IsReachableFrom(Vector3 sourceOnNavMesh, Vector3 targetOnNavMesh)
	{
		return false;
	}

	public Vector3 GetFarthestValidPointAroundPosition(float maxRadius, Transform transformPosition, float minBorderDistance = 6f, int angleSteps = 24)
	{
		return default;
	}

	public Vector3 GetValidatedNavMeshPositionNear(Vector3 intendedWorldPoint, int maxAttempts = 8, Vector3? constraintAnchor = null)
	{
		return default;
	}

	public void StopEnemies()
	{
	}

	public void MoveEnemiesToRandomDestination()
	{
	}

	public int RelocateFarEnemiesOutsidePlayerView()
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CRelocateFarEnemiesOutsidePlayerViewSpreadRoutine_003Ed__98))]
	public IEnumerator RelocateFarEnemiesOutsidePlayerViewSpreadRoutine()
	{
		return null;
	}

	private bool TryGetRelocatePointInSpamRing(Vector3 playerPos, bool enforceSpawnDisk, out Vector3 result)
	{
		result = default;
		return false;
	}

	private bool TryPrepareOffscreenLodCamera()
	{
		return false;
	}

	private void UpdateOffscreenLodForEnemy(EnemyBase enemy)
	{
	}

	private bool IsEnemyVisibleToCamera(Vector3 worldPosition)
	{
		return false;
	}

	private static bool ShouldApplyOffscreenLod(EnemyBase enemy)
	{
		return false;
	}

	private static void TeleportEnemyToPosition(EnemyBase enemy, Vector3 navMeshPosition)
	{
	}
}
