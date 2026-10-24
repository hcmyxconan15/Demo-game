using UnityEngine;

public class Hovl_Laser2 : MonoBehaviour
{
	public float laserScale;

	public Color laserColor;

	public GameObject HitEffect;

	public GameObject FlashEffect;

	public float HitOffset;

	public float MaxLength;

	private bool UpdateSaver;

	private ParticleSystem laserPS;

	private ParticleSystem[] Flash;

	private ParticleSystem[] Hit;

	private Material laserMat;

	private int particleCount;

	private ParticleSystem.Particle[] particles;

	private Vector3[] particlesPositions;

	private float dissovleTimer;

	private bool startDissovle;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AddParticles()
	{
	}

	public void DisablePrepare()
	{
	}
}
