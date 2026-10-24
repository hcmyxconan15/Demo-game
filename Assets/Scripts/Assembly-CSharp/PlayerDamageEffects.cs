using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageEffects : MonoBehaviour
{
	public Material FlashMaterial;

	public List<Renderer> Renderer;

	public float FlashDuration;

	private MaterialPropertyBlock _propertyBlock;

	private float _timeLeft;

	private bool _isFlashing;

	private static readonly int BaseColorId;

	private static readonly int ColorId;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void CleanMaterialsAndRenders()
	{
	}

	public void UpdateRendererList(Renderer partRender)
	{
	}

	public void FlashOnDamage(bool lifeDamage)
	{
	}

	public void SetLockMaterialToBlack(bool lockMaterial)
	{
	}

	private void ApplyFlashPropertyBlock()
	{
	}

	private void ClearFlashPropertyBlock()
	{
	}
}
