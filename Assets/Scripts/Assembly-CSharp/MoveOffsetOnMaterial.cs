using UnityEngine;

public class MoveOffsetOnMaterial : MonoBehaviour
{
	public bool IsActive;

	public Material Material;

	public float ScrollSpeed;

	private float _currentYOffset;

	private MaterialPropertyBlock _propertyBlock;

	private Vector4 _baseMapSt;

	private Renderer[] _renderers;

	private static readonly int BaseMapSt;

	private void Awake()
	{
	}

	private void CacheRenderers()
	{
	}

	private void Update()
	{
	}
}
