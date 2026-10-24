using System.Collections.Generic;
using UnityEngine;

public class DamageEnemyOnTriggerStayComponent : MonoBehaviour
{
	public DamageBase DamageBase;

	[Tooltip("Seconds between damage ticks per enemy while they stay inside the flame.")]
	public float DamageInterval;

	[Tooltip("Seconds an enemy must stay inside the trigger before the first damage tick.")]
	public float MinTouchTimeBeforeDamage;

	private readonly HashSet<StatsBase> _overlappingTargets;

	private readonly Dictionary<StatsBase, float> _nextDamageTimeByTarget;

	private readonly Dictionary<StatsBase, float> _touchStartTimeByTarget;

	private readonly List<StatsBase> _tickBuffer;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private bool TryDamageEnemy(StatsBase stats)
	{
		return false;
	}
}
