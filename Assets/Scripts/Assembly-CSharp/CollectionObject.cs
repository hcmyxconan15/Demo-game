using UnityEngine;

public class CollectionObject : MonoBehaviour
{
	public enum WhichWayToRotate
	{
		AroundX = 0,
		AroundY = 1,
		AroundZ = 2
	}

	public bool Active;

	public float RotationSpeed;

	public WhichWayToRotate Way;

	private void Update()
	{
	}
}
