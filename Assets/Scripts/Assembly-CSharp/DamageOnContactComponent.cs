using UnityEngine;
using UnityEngine.Serialization;

public class DamageOnContactComponent : MonoBehaviour
{
	public int DamageValue;

	public float DamageCooldown;

	public float PushDistance;

	public float PushDuration;

	public float ControlDisableTime;

	public float RotationSpeedDuringPush;

	public bool RandomizeRotationDirection;

	public bool EjectIfInside;

	public float MaxEjectSpeed;

	[FormerlySerializedAs("EffectIdeOnContact")]
	public int EffectIdOnContact;

	public int SoundIdOnContact;

	private StatsBase _stats;

	private float _nextDamageTime;

	private Collider _contactCollider;

	private MechPlayerController _overlappingPlayer;

	private CharacterController _overlappingCharacterController;

	private bool _pendingDashHit;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void HitPlayer(MechPlayerController mechPlayerController, Collider other)
	{
	}

	private void LateUpdate()
	{
	}

	private static bool TryGetPlayer(Collider other, out MechPlayerController mechPlayerController)
	{
		mechPlayerController = null;
		return false;
	}

	private void TrackOverlappingPlayer(MechPlayerController mechPlayerController, Collider other)
	{
	}

	private void ClearOverlappingPlayer()
	{
	}

	private void EjectOverlappingPlayer()
	{
	}
}
