using UnityEngine;

public class RotateIgnorePause : MonoBehaviour
{
	public enum WhichWayToRotate
	{
		AroundX = 0,
		AroundY = 1,
		AroundZ = 2
	}

	public float RotationSpeed;

	public WhichWayToRotate Way;

	private void Update()
	{
	}
}
