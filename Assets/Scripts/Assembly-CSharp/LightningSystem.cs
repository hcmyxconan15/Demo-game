using UnityEngine;
using UnityEngine.VFX;

public class LightningSystem : MonoBehaviour
{
	public enum lsmodes
	{
		Spherical = 0,
		Cone = 1
	}

	public bool previewGizmosInEditor;

	public lsmodes modes;

	[Range(0f, 1f)]
	public float hemisphereDistance;

	[Space(10f)]
	public float maxDistance;

	public bool maxDistanceAutoScaleEnabled;

	public bool maxDistanceAffectedByAnchor;

	public Transform maxDistanceAnchor;

	public float maxDistanceAnchorMultiply;

	[Space(10f)]
	public float autoScaleMultiply;

	[Space(10f)]
	public float coneModeCircleMinRadius;

	public float coneModeCircleMaxRadius;

	public int maximumNumberOfAttempts;

	public int maximumNumberOfBranchedAttempts;

	[Space(10f)]
	[Range(1f, 3f)]
	public int minNumberOfMainStrips;

	[Range(1f, 3f)]
	public int maxNumberOfMainStrips;

	[Range(0f, 3f)]
	public int minNumberOfBranchedStrips;

	[Range(0f, 3f)]
	public int maxNumberOfBranchedStrips;

	[Space(10f)]
	public float speed;

	public AnimationCurve speedVariation;

	public float speedVariationTime;

	public float speedVariationTimeSpeed;

	[Space(10f)]
	public float randomBranchedCircleMinRadius;

	public float randomBranchedCircleMaxRadius;

	private VisualEffect visualEffect;

	private VFXEventAttribute eventAttribute;

	private float timerCurrent;

	private float autoScaleValue;

	private float actualPossibleHitDistance;

	private float meshAutoScaleFactor;

	private float processedMaxDistance;

	private int howManyTimesBranchesWereTriggered;

	private int howManyTimesVFXWasTriggered;

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

	public void ManualSpawnLightningEventFromRandomVertex(Vector3 HitPosition, int NumberOfMainStrips)
	{
	}

	public void ManualSpawnLightningEventRandomVertex(Vector3 BranchedHitPosition0, Vector3 BranchedHitPosition1, Vector3 BranchedHitPosition2, int BranchesCount, Vector3 HitPosition, int NumberOfMainStrips, float AutoScaleValue)
	{
	}

	private void ProcessMaxDistance()
	{
	}

	private void ProcessSpeedVariation()
	{
	}

	private void ProcessAutoScale()
	{
	}
}
