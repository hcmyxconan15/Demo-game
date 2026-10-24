using System.Collections.Generic;

public static class TagOfferWeightCalculator
{
	public static float GetOfferWeight(int typeId, int itemId, float baseWeight, RobotParts robotParts, BuildTagIndex buildTags, BuildArchetypeIndex buildArchetypes, TagOfferWeightConfig config, List<GameTag> affinityScratch, List<BuildArchetype> archetypeScratch)
	{
		return 0f;
	}

	public static float ApplyOffArchetypeWeightPenalty(int typeId, int itemId, float weight, RobotParts robotParts, BuildArchetypeIndex seedArchetypes, TagOfferWeightConfig config, List<BuildArchetype> archetypeScratch)
	{
		return 0f;
	}

	public static bool ShouldApplyOffArchetypeWeightPenalty(int typeId, int itemId, RobotParts robotParts, BuildArchetypeIndex seedArchetypes, List<BuildArchetype> archetypeScratch)
	{
		return false;
	}

	public static bool HasSeedMechArchetypeOverlap(IReadOnlyList<BuildArchetype> itemArchetypes, BuildArchetypeIndex seedArchetypes)
	{
		return false;
	}

	public static bool HasNonCoreItemArchetype(IReadOnlyList<BuildArchetype> itemArchetypes)
	{
		return false;
	}

	public static float ComputeMultiplier(IReadOnlyList<GameTag> affinityTags, BuildTagIndex buildTags, TagOfferWeightConfig config)
	{
		return 0f;
	}

	public static float ComputeArchetypeMultiplier(IReadOnlyList<BuildArchetype> affinityArchetypes, BuildArchetypeIndex buildArchetypes, TagOfferWeightConfig config)
	{
		return 0f;
	}

	public static bool MeetsArchetypeWeightThreshold(int buildStackCount, TagOfferWeightConfig config)
	{
		return false;
	}

	public static float GetArchetypeStackMultiplier(int buildStackCount, TagOfferWeightConfig config)
	{
		return 0f;
	}

	public static float GetStackMultiplier(int buildStackCount, TagOfferWeightConfig config)
	{
		return 0f;
	}

	public static float ClampMultiplier(float multiplier, TagOfferWeightConfig config)
	{
		return 0f;
	}

	public static float GetMatchMultiplier(GameTag tag, TagOfferWeightConfig config)
	{
		return 0f;
	}
}
