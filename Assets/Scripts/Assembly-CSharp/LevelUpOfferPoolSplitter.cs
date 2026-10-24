using System.Collections.Generic;

public static class LevelUpOfferPoolSplitter
{
	private const float WeightEpsilon = 0.001f;

	public static List<(OptionToSelect, float)> ApplySidePoolWildcardMerge(List<(OptionToSelect option, float weight)> fullPool, RobotParts robotParts, BuildTagIndex buildTags, TagOfferWeightConfig config, List<GameTag> affinityScratch, bool useTagOfferWeighting)
	{
		return null;
	}

	public static int GetTotalBuildTagStacks(BuildTagIndex buildTags)
	{
		return 0;
	}

	public static bool HasBuildTagOverlap(OptionToSelect option, RobotParts robotParts, BuildTagIndex buildTags, TagOfferWeightConfig config, List<GameTag> affinityScratch)
	{
		return false;
	}

	public static bool IsInstalledOffer(OptionToSelect option, RobotParts robotParts)
	{
		return false;
	}

	private static void AddRandomSamplesFromSide(List<(OptionToSelect option, float weight)> mainPool, List<(OptionToSelect option, float weight)> sidePool, int count)
	{
	}
}
