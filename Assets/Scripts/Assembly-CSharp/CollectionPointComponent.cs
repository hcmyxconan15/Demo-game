using UnityEngine;

public class CollectionPointComponent : MonoBehaviour
{
	public int ItemId;

	public bool Active;

	public bool Completed;

	public bool Destroyed;

	public float CompletionSpeed;

	public float CompletionStatus;

	public float CompletionMaxStatus;

	public float LiveTimeSpeed;

	public float LiveTime;

	public float LiveTimeMax;

	public bool PlayerInside;

	[Header("Coins")]
	public int Coins;

	public PillarComponent PillarComponent;

	public GameObject SlidersComponents;

	public ProgressBarPro CompletionSlider;

	public bool UseDestructionTimer;

	public ProgressBarPro DestructionSlider;

	public ParticleSystem CompletionEffect;

	public ParticleSystem FailedEffect;

	private float _insideCount;

	private void Start()
	{
	}

	public void SetupCollectionPoint()
	{
	}

	public void Update()
	{
	}

	private void CompleteCollectionPoint()
	{
	}

	private void DestroyCollection()
	{
	}

	private void FillCompletionBars()
	{
	}

	private void FillDestructionBars()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void Hide()
	{
	}
}
