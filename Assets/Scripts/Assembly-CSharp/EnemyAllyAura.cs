using System.Collections.Generic;
using UnityEngine;

public class EnemyAllyAura : MonoBehaviour
{
	private static readonly Collider[] SharedColliderBuffer;

	public EnemyBase EnemyBase;

	public float Radius;

	public float LingerSeconds;

	public int SpeedBonusPercent;

	public int DamageBonusPercent;

	public int RegenPerTick;

	public float RegenIntervalSeconds;

	public bool AffectSelf;

	public float ScanInterval;

	public LayerMask EnemyLayer;

	public CanvasGroup CanvasGroup;

	public ParticleSystem AuraParticles;

	private readonly HashSet<StatsEnemy> _alliesInside;

	private readonly HashSet<StatsEnemy> _insideThisScan;

	private readonly List<StatsEnemy> _leftBuffer;

	private float _nextScanTime;

	private ulong _sourceId;

	private StatsEnemy _stats;

	private bool _auraActive;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	public void StartAura()
	{
	}

	public void StopAura()
	{
	}

	private void ShowCanvasGroup(bool show)
	{
	}

	private bool CanScan()
	{
		return false;
	}

	private void Scan()
	{
	}

	private void ReleaseAllAllies()
	{
	}
}
