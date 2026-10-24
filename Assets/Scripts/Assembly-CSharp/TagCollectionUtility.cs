using System.Collections.Generic;

public static class TagCollectionUtility
{
	public static void AddUnique(List<GameTag> tags, GameTag tag)
	{
	}

	public static bool HasValidEntries(IReadOnlyList<GameTag> tags)
	{
		return false;
	}

	public static bool MeetsRequiredAny(IReadOnlyList<GameTag> requiredTags, BuildTagIndex buildTags)
	{
		return false;
	}

	public static bool MeetsRequiredAll(IReadOnlyList<GameTag> requiredTags, BuildTagIndex buildTags)
	{
		return false;
	}

	public static bool BuildHasIncompatibleTag(IReadOnlyList<GameTag> incompatibleTags, BuildTagIndex buildTags)
	{
		return false;
	}

	public static bool ItemMatchesAnyRequiredTag(IReadOnlyList<GameTag> requiredTags, IReadOnlyList<GameTag> itemTags)
	{
		return false;
	}

	public static bool HasAnyTag(IReadOnlyList<GameTag> requiredTags, BuildTagIndex buildTags)
	{
		return false;
	}

	public static bool HasAllTags(IReadOnlyList<GameTag> requiredTags, BuildTagIndex buildTags)
	{
		return false;
	}

	public static bool HasAnyTag(IReadOnlyList<GameTag> requiredTags, IReadOnlyList<GameTag> itemTags)
	{
		return false;
	}

	private static bool BuildContainsAny(IReadOnlyList<GameTag> tags, BuildTagIndex buildTags)
	{
		return false;
	}
}
