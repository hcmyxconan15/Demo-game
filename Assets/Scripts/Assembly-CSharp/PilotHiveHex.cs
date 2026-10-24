using System.Collections.Generic;
using UnityEngine;

public static class PilotHiveHex
{
	public static readonly Vector2Int[] AxialDirections;

	public static Vector2 HexToPixel(int q, int r, float size)
	{
		return default;
	}

	public static Vector2Int PixelToHex(Vector2 pixel, float size)
	{
		return default;
	}

	public static Vector2Int CubeRound(float q, float r)
	{
		return default;
	}

	public static List<Vector2Int> Spiral(int count)
	{
		return null;
	}

	public static PilotHiveEdgeData MakeEdge(string nodeIdA, string nodeIdB)
	{
		return null;
	}

	public static bool SameUndirectedEdge(PilotHiveEdgeData edge, string nodeIdA, string nodeIdB)
	{
		return false;
	}
}
