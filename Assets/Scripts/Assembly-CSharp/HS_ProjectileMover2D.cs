using UnityEngine;

public class HS_ProjectileMover2D : MonoBehaviour
{
	public float speed;

	public float hitOffset;

	public bool UseFirePointRotation;

	public Vector3 rotationOffset;

	public GameObject hit;

	public GameObject flash;

	private Rigidbody2D rb;

	public GameObject[] Detached;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
