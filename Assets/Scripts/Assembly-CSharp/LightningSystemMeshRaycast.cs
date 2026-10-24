using UnityEngine;
using UnityEngine.VFX;

public class LightningSystemMeshRaycast : MonoBehaviour
{
	private struct vertexData
	{
		public Vector3[] vertexPositions;

		public Vector3[] vertexNormals;
	}

	public bool previewNormalsInEditor;

	public bool showNormalHitDistance;

	public GameObject mesh;

	private vertexData vd;

	[Space(10f)]
	public float maxDistance;

	public bool maxDistanceAffectedByMeshScale;

	public float maxDistanceAffectedByMeshScaleMultiply;

	public bool meshScaleAutoScaleEnabled;

	public float meshAutoScaleMultiply;

	public float autoScaleMultiply;

	[Space(10f)]
	public bool normalAdjustEnabled;

	public Vector3 normalAdjust;

	[Range(0f, 1f)]
	public float normalAdjustAmount;

	[Space(10f)]
	[Range(1f, 2f)]
	public int maximumNumberOfAttempts;

	[Range(1f, 4f)]
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

	private float normalSlerpValue;

	private Vector3 normalAdjustPreviousValue;

	private int howManyTimesBranchesWereTriggered;

	private int howManyTimesVFXWasTriggered;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void ProcessLightningEvent()
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

	public void ManualSpawnLightningEventRandomVertex(Vector3 BranchedHitPosition0, Vector3 BranchedHitPosition1, Vector3 BranchedHitPosition2, int BranchesCount, Vector3 HitSourcePosition, Vector3 HitSourceLocalPosition, Vector3 HitPosition, int NumberOfMainStrips, float AutoScaleValue)
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

	private void ProcessNormalSlerpValue()
	{
	}
}
