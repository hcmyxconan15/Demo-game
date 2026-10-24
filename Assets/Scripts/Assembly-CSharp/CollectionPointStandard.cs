using UnityEngine;

public class CollectionPointStandard : QuestItemOnMap
{
	public bool Active;

	public bool Completed;

	public bool ActiveCollectionDrone;

	public float CompletionSpeed;

	public float GoBackSpeed;

	public float CompletionStatus;

	public float CompletionMaxStatus;

	public bool PlayerInside;

	public bool UseDestructionTimer;

	[Header("Coins")]
	public int Coins;

	public CanvasGroup CanvasGroup;

	public Transform FillerImage;

	public CollectionObject CollectionObject;

	public Transform ItemParent;

	public Transform BaseFixed;

	public ParticleSystem CompletionEffect;

	public MapMarker MapMarker;

	private float _insideCount;

	private void OnEnable()
	{
	}

	public void Update()
	{
	}

	private void InitComponent()
	{
	}

	private void FillCompletionBars()
	{
	}

	private void GoingBack()
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
