using UnityEngine;

public class HS_EffectSound : MonoBehaviour
{
	public bool Repeating;

	public float RepeatTime;

	public float StartTime;

	public bool RandomVolume;

	public float minVolume;

	public float maxVolume;

	private AudioClip clip;

	private AudioSource soundComponent;

	private void Start()
	{
	}

	private void RepeatSound()
	{
	}
}
