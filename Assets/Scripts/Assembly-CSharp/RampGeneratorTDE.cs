using UnityEngine;

public class RampGeneratorTDE : MonoBehaviour
{
	public enum Mode
	{
		CreateAtStart = 0,
		UpdateEveryFrame = 1,
		BakeAndSaveAsTexture = 2
	}

	public Gradient procedrualGradientRamp;

	public string pathForPNG;

	public Renderer[] renderers;

	public Mode mode;

	private Texture2D rampTexture;

	private Texture2D tempTexture;

	private float width;

	private float height;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private Texture2D GenerateTextureFromGradient(Gradient grad, float textureheight)
	{
		return null;
	}

	public void UpdateRampTexture()
	{
	}

	public void BakeGradient()
	{
	}
}
