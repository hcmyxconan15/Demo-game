using UnityEngine;

namespace FIMSpace.FTex
{
	public static class FTex_ScaleLanczos
	{
		private class LanczosKernel
		{
			public int Size;

			public float[] SampleWeights;

			public float Normalizer;

			public LanczosKernel(int size, float[] weights, float normalization)
			{
			}
		}

		public static Color32[] ScaleTexture(Color32[] textureBytes, int sourceWidth, int sourceHeight, int targetWidth, int targetHeight, int quality = 4, bool alpha = true)
		{
			return null;
		}

		private static Color32 FastConvolve(Color32[] textureBytes, int sourceWidth, int sourceHeight, int x, int y, LanczosKernel xKernel, LanczosKernel yKernel, ref float[] cbr, ref float[] cbg, ref float[] cbb, ref float[] cba, bool alpha = true)
		{
			return default;
		}

		private static LanczosKernel GetKernel(LanczosKernel[] kernels, double scale, double mid, ref int samples, ref float[] cbr, ref float[] cbg, ref float[] cbb, ref float[] cba)
		{
			return null;
		}

		private static LanczosKernel ComputeKernel(double scale, double mid, ref int samples)
		{
			return null;
		}

		private static double GetContribution(double sampling, double s)
		{
			return 0.0;
		}

		private static void CleanArray(float[] array)
		{
		}
	}
}
