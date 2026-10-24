using TMPro;
using UnityEngine;

public class CollectionPointHitPoints : QuestItemOnMap
{
	public bool Active;

	public bool Completed;

	public float CompletionSpeed;

	public float GoBackSpeed;

	public float CompletionStatus;

	public float CompletionMaxStatus;

	public bool PlayerInside;

	public bool CanGoBack;

	public Transform ObjectBase;

	public Transform ObjectBase2;

	public Vector3 ObjectBasePosition;

	public Vector3 ObjectBase2Position;

	public GameObject HealGameObject;

	public CanvasGroup CanvasGroup;

	public Transform FillerImage;

	public TextMeshProUGUI TextMeshProUGUI;

	public ParticleSystem CompletionEffect;

	public bool UseMapMarker;

	public MapMarker MapMarker;

	public GameObject NavMeshObstacle;

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

	public void Hide()
	{
	}

	private void DeactivateComponent()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
