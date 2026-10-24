using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraShakeManager : MonoBehaviour
{
	public bool UseCameraShake;

	public CinemachineImpulseSource CinemachineImpulseSource;

	public List<CinemachineImpulseListener> CinemachineImpulseListeners;

	public List<ScreenShakeProfile> ScreenShakeProfiles;

	[Header("Player combat shake gate")]
	[Tooltip("Profile index used by player bullets/explosions. Damage/enemy shakes use a different index.")]
	[SerializeField]
	private int PlayerCombatShakeProfileIndex;

	[Tooltip("Disable player combat shakes when CurrentLevel >= this. 0 = never disable.")]
	[SerializeField]
	private int DisablePlayerCombatShakeFromLevel;

	private CinemachineImpulseDefinition _impulseDefinition;

	public static CameraShakeManager Instance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CheckCurrentCameraShakeSettingsStatus()
	{
	}

	public void CameraShakeFromProfile(int screenShakeProfileIndex)
	{
	}

	private bool ShouldSkipPlayerCombatShake(int screenShakeProfileIndex)
	{
		return false;
	}

	private void ApplyShakeSettings(ScreenShakeProfile profile)
	{
	}
}
