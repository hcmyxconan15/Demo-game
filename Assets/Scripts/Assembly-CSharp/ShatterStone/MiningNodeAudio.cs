using UnityEngine;

namespace ShatterStone
{
	public class MiningNodeAudio : MonoBehaviour
	{
		[Header("Clip Pools")]
		public AudioClip[] impactClips;

		public AudioClip[] shatterClips;

		[Header("Audio Settings")]
		public float volume;

		public Vector2 pitchRange;

		[SerializeField]
		private AudioSource audioSource;

		private void Start()
		{
		}

		public void PlayImpactSound()
		{
		}

		public void PlayShatterSound()
		{
		}

		private void PlayRandomClip(AudioClip[] clipArray)
		{
		}
	}
}
