using UnityEngine;

public class OscillateDrone : MonoBehaviour
{
	public Vector3 AxisToOscillate;

	public float Amplitude;

	public float Frequency;

	private Vector3 _initialPosition;

	private float _elapsed;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
