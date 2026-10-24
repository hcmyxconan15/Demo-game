using UnityEngine;

public class SineCameraControllerTopDownEffects : MonoBehaviour
{
	public Camera camera;

	public Transform basePivot;

	public Transform farPivot;

	public float scrollSpeed;

	public float rotationSpeed;

	public float rotationAmount;

	[Range(10f, 40f)]
	public float maximumAngle;

	private float closeFar;

	private float closeFarLerp;

	private Vector3 mouseAxisToVector;

	private float x;

	private float y;

	private Quaternion rotation;

	private bool rotationPossible;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
