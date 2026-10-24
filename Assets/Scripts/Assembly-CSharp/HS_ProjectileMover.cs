using UnityEngine;

public class HS_ProjectileMover : MonoBehaviour
{
	public float speed;

	public float hitOffset;

	public bool UseFirePointRotation;

	public Vector3 rotationOffset;

	public GameObject hit;

	public GameObject flash;

	private Rigidbody rb;

	public GameObject[] Detached;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
