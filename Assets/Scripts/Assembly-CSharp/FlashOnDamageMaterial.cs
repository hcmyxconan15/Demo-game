using System.Collections.Generic;
using UnityEngine;

public class FlashOnDamageMaterial : MonoBehaviour, IActiveEffectTick
{
	public bool DoNotFlashOnDamage;

	[Tooltip("When enabled, swaps sharedMaterial to flashMaterial (old behavior). When disabled, uses global flat MPB flash.")]
	public bool UseSwapMaterial;

	public Material flashMaterial;

	public List<Renderer> Renderer;

	public float flashDuration;

	public List<Material> originalMaterials;

	private readonly List<MaterialPropertyBlock> _flashBlocks;

	private float _timeLeft;

	private bool _isFlashing;

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	public void TickActiveEffect(float deltaTime)
	{
	}

	private void CacheOriginalMaterialsIfNeeded()
	{
	}

	private void CacheFlashBlocks()
	{
	}

	private static MaterialPropertyBlock BuildFlashBlock(Renderer render)
	{
		return null;
	}

	[ContextMenu("Collect Renderers")]
	public void CollectRenderers()
	{
	}

	public void AddMoreRenderForFlash(List<Renderer> rendererToAd)
	{
	}

	public void RemoveRenderFlash(List<Renderer> rendererToAd)
	{
	}

	public void Flash()
	{
	}

	public void FlashByCoroutine()
	{
	}

	private void StartFlash()
	{
	}

	private void ApplyFlash()
	{
	}

	private void RestoreFlash()
	{
	}

	private void ApplyMaterialSwap()
	{
	}

	private void RestoreMaterialSwap()
	{
	}

	private void RestoreRendererFlash(Renderer render, int index)
	{
	}

	private void ApplyFlatPropertyBlockFlash()
	{
	}

	private void ClearFlatPropertyBlockFlash()
	{
	}
}
