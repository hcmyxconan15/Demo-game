using UnityEngine;
using UnityEngine.UI;

namespace PlayfulSystems
{
	public class ImageSlicedMirror : Image
	{
		private static readonly Vector2[] s_VertScratch;

		private static readonly Vector2[] s_UVScratch;

		private static readonly float[] s_UVMultiplierScratch;

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		private void GenerateSlicedFilledSprite(VertexHelper toFill)
		{
		}

		private void SetSlicedVerts(Rect rect, Vector4 border, Vector4 padding)
		{
		}

		private void SetSlicedUVs(Vector4 outer, Vector4 inner, Vector4 border)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{
			return default;
		}
	}
}
