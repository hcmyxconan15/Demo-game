using UnityEngine;

public static class DamageFlashRendererUtility
{
	private static readonly int EmissionColorId;

	private static readonly int EmissionMapId;

	private static readonly int BaseColorId;

	private static readonly int BaseMapId;

	private static readonly int ColorId;

	private static readonly int MainTexId;

	private static readonly int BumpMapId;

	private static readonly int MetallicGlossMapId;

	private static readonly int OcclusionMapId;

	private static readonly int MetallicId;

	private static readonly int SmoothnessId;

	private static readonly int SpecularHighlightsId;

	private static readonly int EnvironmentReflectionsId;

	private static readonly int ReceiveShadowsId;

	private static Texture2D _flatNormalTexture;

	private static Color GlobalFlatFlashColor;

	private static float GlobalFlatFlashIntensityEmissive;

	private static float GlobalFlatFlashIntensityNonEmissive;

	public static void ApplyFlatFlash(Renderer render, MaterialPropertyBlock block)
	{
	}

	public static MaterialPropertyBlock GetFlatFlashBlock(Material shared)
	{
		return null;
	}

	public static Color ExtractFlashTint(Material flashMaterial)
	{
		return default;
	}

	public static Color ToVisibleBaseTint(Color flashTint)
	{
		return default;
	}

	public static void ApplyFlash(Renderer render, MaterialPropertyBlock block, Color flashTint)
	{
	}

	public static void ApplyFlashNormalize(Renderer render, MaterialPropertyBlock block, Color flashColor)
	{
	}

	private static void FillFlashBlock(MaterialPropertyBlock block, Material shared, Color flashColor)
	{
	}

	public static void ClearFlash(Renderer render)
	{
	}

	private static float GetFlashIntensity(Material shared)
	{
		return 0f;
	}

	private static Texture2D GetFlatNormalTexture()
	{
		return null;
	}
}
