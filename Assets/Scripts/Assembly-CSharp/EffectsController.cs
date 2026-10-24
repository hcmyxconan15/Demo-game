using System.Collections.Generic;
using UnityEngine;

public class EffectsController : MonoBehaviour
{
	public enum BloodColor
	{
		Red = 0,
		Green = 1,
		Metal = 2
	}

	public static EffectsController Instance;

	public bool InstanceEnemyParts;

	[SerializeField]
	private Transform PartsParent;

	public SpawnPartsDb SpawnPartsDb;

	public List<SpawnParts> SpawnPartsListInMap;

	[SerializeField]
	private int MaxSpawnPartsPerId;

	[SerializeField]
	private Transform ParticlesParent;

	[SerializeField]
	private List<Effect> Effects;

	[SerializeField]
	private List<ParticleEffect> ParticleSystemEffects;

	[SerializeField]
	private List<GameObject> ComplexEffects;

	[SerializeField]
	public List<AudioClip> SoundEffects;

	[SerializeField]
	private AudioSource AudioSource;

	[SerializeField]
	public AudioSource[] AudioSources;

	public const float DroneShotVolumeScale = 0.75f;

	public const float MonsterDeathVolumeScale = 0.75f;

	[Header("Sound distance")]
	[Tooltip("At or below this distance from the player, impact sound uses full volume (before random jitter).")]
	public float SoundFullVolumeDistance;

	[Tooltip("At or beyond this distance, impact sound volume reaches zero. Between full and silent distance, volume falls off linearly.")]
	public float SoundSilentDistance;

	[SerializeField]
	public AudioSource[] ByDistanceAudioSources;

	private int _byDistanceIndex;

	[Header("Blood settings")]
	public bool UseBlood;

	public List<int> RedBloodParticles;

	public List<int> RedDeadBloodParticles;

	public List<int> GreenBloodParticles;

	public List<int> GreenDeadBloodParticles;

	[SerializeField]
	private List<Effect> BloodEffects;

	[SerializeField]
	private List<ParticleEffect> ParticleSystemBloodEffects;

	private float _soundTimer;

	private float _soundTimerXp;

	[SerializeField]
	private float SameEffectSoundCooldown;

	private readonly Dictionary<int, float> _lastPlayedEffectSoundTime;

	private int _bloodIndex;

	private int _index;

	private Dictionary<short, Effect> _effectsById;

	private Dictionary<short, Effect> _bloodEffectsById;

	private const int MaxParticlePoolSize = 32;

	private readonly HashSet<ParticleSystem> _attachedParticles;

	private readonly Dictionary<int, List<SpawnParts>> _partsById;

	private readonly Dictionary<int, Stack<SpawnParts>> _inactiveById;

	private readonly Dictionary<int, int> _stealCursorById;

	private bool _suppressPartRelease;

	[SerializeField]
	private MechPlayerController MechPlayerController;

	private void Awake()
	{
	}

	private void BuildEffectLookups()
	{
	}

	private ParticleSystem RentParticle(ParticleEffect particleEffect)
	{
		return null;
	}

	private ParticleSystem RentNextNonAttached(ParticleEffect particleEffect)
	{
		return null;
	}

	private void PlayParticleEffect(Effect effect, List<ParticleEffect> particleSources, Vector3 position, Quaternion rotation)
	{
	}

	public ParticleSystem RentAttachedEffect(int effectId, Transform parent)
	{
		return null;
	}

	public void ReleaseAttachedEffect(ParticleSystem particle)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CheckCurrentEffectsSettingsStatus()
	{
	}

	public void PlayEffect(Vector3 position, int effectId, bool doNotSound = false, bool volumeByDistance = false)
	{
	}

	public void PlayEffect(Vector3 position, Quaternion rotation, int effectId, float volumeScale = 1f)
	{
	}

	private bool CanPlayEffectSound(int effectId)
	{
		return false;
	}

	public void PlayBloodEffect(Vector3 position, Quaternion rotation, BloodColor bloodColor)
	{
	}

	public void PlayDeadBloodEffect(Vector3 position, Quaternion rotation, BloodColor bloodColor)
	{
	}

	public void PlaySoundClip(AudioClip audioClip)
	{
	}

	public void PlaySound(int id, float volumeScale = 1f)
	{
	}

	public void PlayBulletSound(int id)
	{
	}

	public void PlaySoundMinTime(int id)
	{
	}

	public void PlayCollectXpEffectSound(Vector3 position, int effectId)
	{
	}

	public void MuteAudioSource(bool mute)
	{
	}

	public void InstanceParts(Transform transformPosition, int monsterPartId, bool forcePart)
	{
	}

	public void ReleaseSpawnPart(SpawnParts part)
	{
	}

	private void RentSpawnPart(int monsterPartId, Transform transformPosition)
	{
	}

	private void EnsureSpawnPartPool(int monsterPartId)
	{
	}

	private SpawnParts PopInactiveSpawnPart(int monsterPartId)
	{
		return null;
	}

	private SpawnParts StealSpawnPart(int monsterPartId)
	{
		return null;
	}

	private void FixedSoundOnPosition(int id, Vector3 soundPosition)
	{
	}

	private float GetDistanceToPlayerVolumeMultiplier(Vector3 soundPosition)
	{
		return 0f;
	}
}
