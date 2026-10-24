using UnityEngine;

public class FlashOnDamage : MonoBehaviour
{
	public Color DamageColor;

	public float DamageBorderPulseAmount;

	public float DamageFadeDuration;

	private float _fadeTime;

	public Renderer[] BorderRenderer;

	private MaterialPropertyBlock _propertyBlock;

	private static readonly int OutlineWidthId;

	private static readonly int BaseColorId;

	private static readonly int ColorId;

	public void StartDamageFlash()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
