using ShatterStone;
using UnityEngine;

public class CollectionPointCrystal : QuestItemOnMap
{
	public OreNode OreNode;

	public bool Active;

	public bool Completed;

	public bool PlayerInside;

	public float HitInterval;

	public CanvasGroup CanvasGroup;

	public Collider Collider;

	public MapMarker MapMarker;

	public ParticleSystem CompletionEffect;

	public ParticleSystem ParticleIdleEffect;

	public Transform MiningPointPosition;

	private float _insideCount;

	private float _hitTimer;

	private void OnEnable()
	{
	}

	private void InitComponent()
	{
	}

	private void Update()
	{
	}

	public void Hit()
	{
	}

	private void SetMiningLightning(bool mining)
	{
	}

	private void CompleteCollectionPoint()
	{
	}

	private void Hide()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
