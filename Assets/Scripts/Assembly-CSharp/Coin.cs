using UnityEngine;

public class Coin : MonoBehaviour
{
	public int Value;

	public int CoinType;

	public short EffectId;

	public bool Taken;

	public bool UseParticle;

	public MagnetForce MagnetForce;

	public float Radius;

	public float JumpPower;

	public float JumpDuration;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void PlayDropAnimation(Vector3 pointA)
	{
	}

	private void EndDrop()
	{
	}
}
