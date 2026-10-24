using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class EmissionYoyo : MonoBehaviour
{
	public Renderer TargetRenderer;

	public float MinIntensity;

	public float MaxIntensity;

	public float Duration;

	private Material _mat;

	private TweenerCore<float, float, FloatOptions> _dtween;

	private Color _originalEmission;

	private static readonly int EmissionColorID;

	private bool _initialized;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void StartEmission()
	{
	}
}
