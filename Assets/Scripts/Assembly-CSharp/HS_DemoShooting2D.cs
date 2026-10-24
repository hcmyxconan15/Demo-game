using UnityEngine;

public class HS_DemoShooting2D : MonoBehaviour
{
	public GameObject FirePoint;

	public Camera Cam;

	public float MaxLength;

	public GameObject[] Prefabs;

	private Ray RayMouse;

	private Vector3 direction;

	private Quaternion rotation;

	[Header("GUI")]
	private float windowDpi;

	private int Prefab;

	private GameObject Instance;

	private float hSliderValue;

	private float fireCountdown;

	private float buttonSaver;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void Counter(int count)
	{
	}
}
