using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class GlobalVolumeController : MonoBehaviour
{
	public enum DepthOfFieldType
	{
		Disable = 0,
		Panels = 1,
		PilotView = 2,
		MechaView = 3
	}

	public Volume GameVolume;

	private DepthOfField _depthOfField;

	private Vignette _vignette;

	private ColorAdjustments _colorAdjustments;

	private float _previousSaturation;

	private float _previousVignetteIntensity;

	private const string VignetteIntensityTweenId = "VignetteIntensity";

	private void Awake()
	{
	}

	private static Volume FindGlobalVolume()
	{
		return null;
	}

	public void EnableDepthOfField(bool enable, DepthOfFieldType type = DepthOfFieldType.Panels)
	{
	}

	public void EnableGaussianDepthOfField(bool enable)
	{
	}

	public void EnableVignette(bool enable)
	{
	}

	public void SetVignetteIntensity(float duration = 1f)
	{
	}

	public void TweenVignetteIntensity(float intensity, float duration = 1f, bool unscaledTime = false)
	{
	}

	public void RestoreVignetteIntensity(float duration = 1f, bool unscaledTime = false)
	{
	}

	public void SetExposure(float exposure)
	{
	}

	public void SetSaturationToBlackAndWhite(float duration = 1f)
	{
	}

	public void RestorePostProcessingFromBlackAndWhite(float duration = 1f)
	{
	}

	private void GaussianDepthOfField()
	{
	}

	private void BockDepthOfField(DepthOfFieldType depthOfFieldType)
	{
	}
}
