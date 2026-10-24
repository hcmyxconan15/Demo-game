using System.Collections.Generic;

public static class WeightedSelector
{
	public static T GetRandomWeightedItem<T>(List<(T item, float weight)> weightedItems)
	{
		return default;
	}

	public static List<T> GetMultipleRandomWeightedItems<T>(List<(T item, float weight)> weightedItems, int count)
	{
		return null;
	}

	public static List<T> GetMultipleRandomWeightedItems<T>(List<(T item, float weight)> weightedItems, int count, bool guaranteeOneTopWeightedPick, float topTierWeightRatio)
	{
		return null;
	}

	private static void Shuffle<T>(List<T> list)
	{
	}

	public static float GetTopTierWeightThreshold<T>(IReadOnlyList<(T item, float weight)> weightedItems, float topTierWeightRatio, out float maxWeight)
	{
		maxWeight = default;
		return 0f;
	}

	public static List<(T, float)> BuildTopTierPool<T>(IReadOnlyList<(T item, float weight)> weightedItems, float topTierWeightRatio)
	{
		return null;
	}

	private static void RemoveItem<T>(List<(T item, float weight)> workingList, T selected)
	{
	}
}
