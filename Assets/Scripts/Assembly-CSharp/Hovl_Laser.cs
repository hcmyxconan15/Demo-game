using UnityEngine;

public class Hovl_Laser : MonoBehaviour
{
	public int damageOverTime;

	public GameObject HitEffect;

	public float HitOffset;

	public bool useLaserRotation;

	public float MaxLength;

	private LineRenderer Laser;

	public float MainTextureLength;

	public float NoiseTextureLength;

	private Vector4 Length;

	private bool LaserSaver;

	private bool UpdateSaver;

	private ParticleSystem[] Effects;

	private ParticleSystem[] Hit;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void DisablePrepare()
	{
	}
}
