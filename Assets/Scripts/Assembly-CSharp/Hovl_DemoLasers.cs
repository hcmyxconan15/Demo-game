using UnityEngine;

public class Hovl_DemoLasers : MonoBehaviour
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

	private Hovl_Laser LaserScript;

	private Hovl_Laser2 LaserScript2;

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

	private void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
	}
}
