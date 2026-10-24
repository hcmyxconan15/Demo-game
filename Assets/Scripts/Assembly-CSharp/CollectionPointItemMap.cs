using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CollectionPointItemMap : QuestItemOnMap
{
	public bool Active;

	public bool Completed;

	public float CompletionSpeed;

	public float GoBackSpeed;

	public float CompletionStatus;

	public float CompletionMaxStatus;

	public bool PlayerInside;

	public bool CanGoBack;

	[Header("Open box")]
	[Range(0f, 15f)]
	public float MinRadiusToDrop;

	[FormerlySerializedAs("RadiusToDrop")]
	[Range(0f, 15f)]
	public float MaxRadiusToDrop;

	public GameObject OpenBoxGameObject;

	public Transform CenterOfForce;

	public Rigidbody OpenBoxRigidBody;

	public float OpenBoxSideForce;

	public float OpenBoxUpForce;

	public float OpenBoxTorque;

	public List<Collider> BlockUserPathColliders;

	[Header("ToDrop")]
	public ItemsToDrop ItemsToDrop;

	public CanvasGroup CanvasGroup;

	public Transform FillerImage;

	public Image CircleFillerImage;

	public Transform PercentParent;

	public TextMeshProUGUI TextMeshProUGUI;

	public ParticleSystem CompletionEffect;

	public bool UseMapMarker;

	public MapMarker MapMarker;

	public GameObject NavMeshObstacle;

	private float _insideCount;

	private Tween _percentIdleTween;

	private void OnEnable()
	{
	}

	private void OnDisable()
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

	private void SetProgress(float normalizeStatus, float duration)
	{
	}

	private void StartPercentIdle()
	{
	}

	private void StopPercentIdle()
	{
	}

	private void CompleteCollectionPoint()
	{
	}

	private void Hide()
	{
	}

	private void OpenBox()
	{
	}

	private void ResetBox()
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
