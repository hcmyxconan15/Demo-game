using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusEffectManager : MonoBehaviour
{
	public EnemyStatusEffectsUi StatusUiPrefab;

	public int PrewarmCount;

	private static EnemyStatusEffectManager _instance;

	private readonly List<StatsEnemy> _active;

	private readonly Dictionary<StatsEnemy, EnemyStatusEffectsUi> _uiByStats;

	private readonly Dictionary<StatsEnemy, ParticleSystem> _markFxByStats;

	private readonly Stack<EnemyStatusEffectsUi> _pool;

	private readonly List<StatsEnemy> _destroyedUiKeys;

	private Transform _poolRoot;

	public static void Register(StatsEnemy stats)
	{
	}

	public static void Unregister(StatsEnemy stats)
	{
	}

	private static EnemyStatusEffectManager GetOrCreate()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Prewarm()
	{
	}

	private EnemyStatusEffectsUi CreateInstance()
	{
		return null;
	}

	private void RegisterInternal(StatsEnemy stats)
	{
	}

	private void TryBindUi(StatsEnemy stats)
	{
	}

	private void UnregisterInternal(StatsEnemy stats)
	{
	}

	private void ReleaseUi(StatsEnemy stats)
	{
	}

	private void ReleaseMarkEffect(StatsEnemy stats)
	{
	}

	private EnemyStatusEffectsUi Rent()
	{
		return null;
	}

	private void ReleaseOrphanedBindings()
	{
	}

	private void Update()
	{
	}
}
