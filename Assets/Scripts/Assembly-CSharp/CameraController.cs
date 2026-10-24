using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public CinemachineVirtualCamera BossVirtualCamera;

	public GameObject DashCamera;

	public GameObject ZoomCamera;

	[Header("Camera effects")]
	public ParticleSystem CameraEffectLevelUp;

	public float LevelUpEffectFadeDuration;

	private bool _levelUpEffectActive;

	private bool _levelUpStopping;

	private float _levelUpPauseScrollTime;

	private float _levelUpOpacityNormalized;

	private float _levelUpOpacityTarget;

	private float[] _levelUpInitialOpacities;

	private ParticleSystemRenderer[] _levelUpRenderers;

	private MaterialPropertyBlock _levelUpMpb;

	private static readonly int SpeedMainTexUVNoiseZw;

	private static readonly int OpacityId;

	public void ActiveDashCamera(bool active)
	{
	}

	public void ActiveZoomCamera(bool active)
	{
	}

	public void ActiveToBossCamera(bool active)
	{
	}

	private void Awake()
	{
	}

	public void ActiveLevelUpCameraEffect(bool active)
	{
	}

	private void LateUpdate()
	{
	}

	private void CaptureLevelUpInitialOpacities()
	{
	}

	private void FinishLevelUpCameraEffectStop()
	{
	}

	private void ApplyLevelUpMaterialProperties()
	{
	}

	private void SetTextureSt(Material material, string textureProperty, Vector2 scrollSpeed)
	{
	}

	private void ClearLevelUpUvScroll()
	{
	}
}
