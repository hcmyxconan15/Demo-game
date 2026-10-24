using UnityEngine;

public class EnvironmentalDamageZone : MonoBehaviour
{
	public int DamagePerSecond;

	public float TickInterval;

	public string RequiredTag;

	public int EffectIdOnTick;

	public int SoundIdOnTick;

	private float _ticksTime;

	private bool _playerInside;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void ApplyDamage()
	{
	}
}
