using System.Collections.Generic;
using UnityEngine;

public class HS_CameraHolder : MonoBehaviour
{
	public struct SVA
	{
		public float S;

		public float V;

		public float A;
	}

	public Transform Holder;

	public Vector3 cameraPos;

	public float currDistance;

	public float xRotate;

	public float yRotate;

	public float yMinLimit;

	public float yMaxLimit;

	public float prevDistance;

	private float x;

	private float y;

	[Header("GUI")]
	private float windowDpi;

	public GameObject[] Prefabs;

	private int Prefab;

	private GameObject Instance;

	private float StartColor;

	private float HueColor;

	public Texture HueTexture;

	public bool disableHue;

	private ParticleSystem[] particleSystems;

	private List<SVA> svList;

	private float H;

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void Counter(int count)
	{
	}

	private void LateUpdate()
	{
	}

	private static float ClampAngle(float angle, float min, float max)
	{
		return 0f;
	}
}
