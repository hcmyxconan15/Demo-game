using System.Collections.Generic;

public static class TagOfferWeightDebugLog
{
	private const string WeightColor = "#4CFF4C";

	private const string BreakdownColor = "#5EB3FF";

	private const string ProbabilityColor = "#FFB84C";

	private const string BlockedColor = "#FF6B6B";

	private static string GreenWeight(string value)
	{
		return null;
	}

	private static string BlueBreakdown(string value)
	{
		return null;
	}

	private static string OrangeProbability(string value)
	{
		return null;
	}

	private static string RedBlocked(string value)
	{
		return null;
	}

	public static void LogLevelUpPools(RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, IReadOnlyList<(OptionToSelect option, float weight)> rollPool, IReadOnlyList<(OptionToSelect option, float weight)> normalPool, bool rollPoolNewWeaponsOnly, TagOfferWeightConfig config, List<GameTag> affinityScratch, List<BuildArchetype> archetypeScratch, int pickCount, LevelUpOfferEligibilityContext eligibilityContext, bool freshOfferLevel = false, bool usedFilteredPool = false, bool isReroll = false, int levelUpsUntilFreshOffer = 0, IReadOnlyList<OptionToSelect> excludedOffers = null)
	{
	}

	public static void LogShopPools(RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, IReadOnlyList<(int itemId, float weight)> weaponPool, IReadOnlyList<(int itemId, float weight)> chipPool, IReadOnlyList<(int itemId, float weight)> overloadPool, TagOfferWeightConfig config, List<GameTag> affinityScratch, List<BuildArchetype> archetypeScratch, int weaponPickCount, int chipPickCount, int overloadPickCount)
	{
	}

	private static string FormatShopPool(RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, IReadOnlyList<(int itemId, float weight)> pool, int typeId, TagOfferWeightConfig config, List<GameTag> affinityScratch, List<BuildArchetype> archetypeScratch, int pickCount)
	{
		return null;
	}

	private static string FormatBlockedOffers(RobotParts robotParts, LevelUpOfferEligibilityContext eligibilityContext)
	{
		return null;
	}

	private static string FormatBuildTagWeights(BuildTagIndex buildTags)
	{
		return null;
	}

	private static string FormatWeightingConfig(TagOfferWeightConfig config)
	{
		return null;
	}

	private static string FormatFreshOfferRotation(bool freshOfferLevel, bool usedFilteredPool, bool isReroll, int levelUpsUntilFreshOffer, IReadOnlyList<OptionToSelect> excludedOffers)
	{
		return null;
	}

	private static string FormatOfferType(int typeId)
	{
		return null;
	}

	private static string FormatBuildArchetypeWeights(BuildArchetypeIndex buildArchetypes)
	{
		return null;
	}

	private static string FormatPool(RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, IReadOnlyList<(OptionToSelect option, float weight)> pool, string poolLabel, TagOfferWeightConfig config, List<GameTag> affinityScratch, List<BuildArchetype> archetypeScratch, int pickCount)
	{
		return null;
	}

	private static string FormatMatchedAffinityTags(RobotParts robotParts, BuildTagIndex buildTags, int typeId, int itemId, TagOfferWeightConfig config, List<GameTag> affinityScratch)
	{
		return null;
	}

	private static string FormatMatchedAffinityArchetypes(RobotParts robotParts, BuildArchetypeIndex buildArchetypes, int typeId, int itemId, TagOfferWeightConfig config, List<BuildArchetype> archetypeScratch)
	{
		return null;
	}

	private static string FormatSuppressedAffinityArchetypes(RobotParts robotParts, BuildArchetypeIndex buildArchetypes, int typeId, int itemId, TagOfferWeightConfig config, List<BuildArchetype> archetypeScratch)
	{
		return null;
	}

	private static string FormatPercent(float probability)
	{
		return null;
	}

	private static string GetOfferLabel(RobotParts robotParts, int typeId, int itemId)
	{
		return null;
	}
}
