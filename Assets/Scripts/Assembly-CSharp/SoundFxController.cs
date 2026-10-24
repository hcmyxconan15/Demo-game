using UnityEngine;

public class SoundFxController : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] SoundClips;

	[SerializeField]
	public AudioSource AudioSource;

	[SerializeField]
	[Range(0f, 0.25f)]
	private float OneShotPitchJitter;

	[SerializeField]
	[Range(0f, 0.25f)]
	private float OneShotVolumeJitter;

	public static SoundFxController Instance;

	private float _timeForSoundRepeat;

	private float _avoidSoundOnLoad;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private static void SetAudioPausedByApplicationFocus(bool paused)
	{
	}

	public void PlaySound(int index)
	{
	}

	public void PlaySoundNotVariation(int index)
	{
	}

	public void PlaySoundCheckRepeat(int index, float waitTime)
	{
	}

	private void PlayOneShotWithVariation(AudioClip clip)
	{
	}
}
