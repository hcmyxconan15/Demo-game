using UnityEngine;

public class XpItem : MonoBehaviour
{
	public int Value;

	public bool Taken;

	public short EffectOnCollectId;

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
