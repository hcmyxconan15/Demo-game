using UnityEngine;

namespace FIMSpace.FTex
{
	public static class FTex_AdditionalEncoders
	{
		public enum FEColorChannel
		{
			R = 0,
			G = 1,
			B = 2,
			A = 3,
			White = 4,
			Black = 5,
			Gray = 6
		}

		private static class TIFFEncoder
		{
			public static byte[] EncodeToTIFF(Texture2D texture)
			{
				return null;
			}
		}

		private static class TGAEncoder
		{
			private static readonly byte[] TGA_FOOTER;

			public static byte[] EncodeToTGA(Texture2D texture, FEColorChannel[] colorChannels = null)
			{
				return null;
			}

			private static byte[] CreateTGAHeader(int width, int height, bool fourChannels = true)
			{
				return null;
			}

			private static byte GetChannel(Color32 color, FEColorChannel colorChannel)
			{
				return 0;
			}
		}

		public static byte[] EncodeToTGA(Texture2D texture, FEColorChannel[] colorChannels = null)
		{
			return null;
		}

		public static byte[] EncodeToTIFF(Texture2D texture)
		{
			return null;
		}
	}
}
