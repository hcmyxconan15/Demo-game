using System.Collections.Generic;
using UnityEngine;

public static class PositionsTools
{
	public static Vector3[] GetPoisonDiscPositions(Transform center, int positionCount, float radius = 5f)
	{
		return null;
	}

	public static Vector3[] GetPoisonDiscPositions(Transform center, int positionCount, bool autoRadius = false, float separation = 3f)
	{
		return null;
	}

	public static Vector3[] Get4SpacedPositions(Transform center, float separation, bool diamondShape = true)
	{
		return null;
	}

	public static Vector3[] GetFilledPoisonDisc(Transform center, int positionCount, float radius = 6f)
	{
		return null;
	}

	public static Vector3[] GetFilledPoisonDisc(Transform center, float density = 1f, float radius = 6f)
	{
		return null;
	}

	public static Vector3 GetPolePointAtTargetHeight(Vector3 polePoint, Vector3 target)
	{
		return default;
	}

	public static Vector3 GetPolePointClampedBetweenTurretAndTop(Vector3 polePoint, Vector3 target, Vector3 turretLaunchPos, float? poleTopY = null)
	{
		return default;
	}

	public static Vector3 GetPlayerPredictedPosition(CharacterController controller, float predictionTime = 0.5f)
	{
		return default;
	}

	public static Vector3 GetRandomPointInCircle(Vector3 center, float radius)
	{
		return default;
	}

	public static Vector3 GetRandomPointInAnnulus(Vector3 center, float minRadius, float maxRadius)
	{
		return default;
	}

	public static Vector3 GetSpacedPointInAnnulus(Vector3 center, float minRadius, float maxRadius, List<Vector3> placed, float minSeparation, int maxAttempts = 16)
	{
		return default;
	}

	private static float GetMinDistanceSqr(Vector3 candidate, List<Vector3> placed)
	{
		return 0f;
	}
}
