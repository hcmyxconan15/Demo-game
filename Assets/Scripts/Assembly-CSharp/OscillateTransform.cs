using UnityEngine;

public class OscillateTransform : MonoBehaviour
{
	public EnemyBase EnemyBase;

	public Vector3 AxisToOscillate;

	public float Amplitude;

	public float Frequency;

	private Vector3 _initialPosition;

	private float _oscillationOffset;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
