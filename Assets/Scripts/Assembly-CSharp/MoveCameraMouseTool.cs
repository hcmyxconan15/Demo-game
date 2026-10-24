using UnityEngine;

public class MoveCameraMouseTool : MonoBehaviour
{
	public float Radius;

	public float SmoothTime;

	private Vector3 _centerLocalPosition;

	private Vector3 _velocity;

	private bool _centerReady;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private static bool IsPointerInsideScreen()
	{
		return false;
	}
}
