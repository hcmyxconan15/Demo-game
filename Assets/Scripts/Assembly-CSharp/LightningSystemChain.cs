using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LightningSystemChain : MonoBehaviour
{
	public bool previewChainPointsInEditor;

	public bool vfxEnabled;

	[Space(10f)]
	public List<Transform> chainPoints;

	private Texture2D chainPointPositionsTexture;

	public float masterScale;

	public bool autoScaleEnabled;

	public Transform autoScaleAnchor;

	public float autoScaleMultiply;

	[Space(10f)]
	[Range(1f, 3f)]
	public int minNumberOfMainStrips;

	[Range(1f, 3f)]
	public int maxNumberOfMainStrips;

	[Space(10f)]
	[Range(0f, 1f)]
	public float bonusBranchProbability;

	[Space(10f)]
	public float speed;

	public AnimationCurve speedVariation;

	public float speedVariationTime;

	public float speedVariationTimeSpeed;

	[Space(10f)]
	public float randomBranchedCircleMinRadius;

	public float randomBranchedCircleMaxRadius;

	public VisualEffect visualEffect;

	private VFXEventAttribute eventAttribute;

	private float timerCurrent;

	private float autoScaleValue;

	private Color col;

	public int howManyTimesVFXWasTriggered;

	public int howManyTimesVFXWasTriggeredPerTrigger;

	private int bonusBranchProbabilityResult;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SpawnLightningEvent()
	{
	}

	private void OnDisable()
	{
	}

	private void ResetVFXParameters()
	{
	}

	private void ProcessBonusBranchProbability()
	{
	}

	private void ProcessSpeedVariation()
	{
	}

	private void ProcessAutoScale()
	{
	}
}
