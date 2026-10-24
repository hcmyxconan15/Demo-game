using System.Collections.Generic;

public static class TagOfferProbabilityCalculator
{
	public static float GetTotalWeight(IReadOnlyList<(OptionToSelect option, float weight)> pool)
	{
		return 0f;
	}

	public static float GetFirstPickProbability(float itemWeight, float totalWeight)
	{
		return 0f;
	}

	public static float GetAnyPickProbability(IReadOnlyList<(OptionToSelect option, float weight)> pool, OptionToSelect target, int pickCount)
	{
		return 0f;
	}

	private static float GetAnyPickProbabilityRecursive(IReadOnlyList<(OptionToSelect option, float weight)> pool, OptionToSelect target, int picksLeft)
	{
		return 0f;
	}

	private static bool TryGetWeight(IReadOnlyList<(OptionToSelect option, float weight)> pool, OptionToSelect target, out float weight)
	{
		weight = default;
		return false;
	}

	private static List<(OptionToSelect, float)> CopyPoolWithoutIndex(IReadOnlyList<(OptionToSelect option, float weight)> pool, int skipIndex)
	{
		return null;
	}

	private static bool OptionKeyEquals(OptionToSelect a, OptionToSelect b)
	{
		return false;
	}
}
