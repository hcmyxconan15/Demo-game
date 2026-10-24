using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LightningSystemMeshEnchant : MonoBehaviour
{
	public enum lsmodes
	{
		RandomClosestCell = 0,
		RandomOtherCell = 1
	}

	private struct vertexData
	{
		public Vector3[] vertexPositions;

		public Vector3[] vertexNormals;
	}

	public lsmodes modes;

	public bool previewCellsInEditor;

	public float cellsScale;

	public float minDistance;

	[Space(10f)]
	public GameObject mesh;

	public bool meshScaleAutoScaleEnabled;

	public float meshAutoScaleMultiply;

	public float masterScale;

	private vertexData vd;

	private MeshFilter mf;

	private Dictionary<Vector3, List<Vector3>> cells;

	private Dictionary<Vector3, List<Vector3>> cellsNormal;

	private Vector3[] cellOffsets;

	[Space(10f)]
	public int maximumNumberOfAttempts;

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

	private VisualEffect visualEffect;

	private VFXEventAttribute eventAttribute;

	private float timerCurrent;

	private float autoScaleValue;

	private int howManyTimesVFXWasTriggered;

	private int bonusBranchProbabilityResult;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CreateCells()
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

	private void ProcessSpeedVariation()
	{
	}

	private void ProcessAutoScale()
	{
	}

	private void GenerateCellOffsets()
	{
	}

	private void ProcessBonusBranchProbability()
	{
	}
}
