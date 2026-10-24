using System.Collections.Generic;

public static class TagRequirementsEvaluator
{
	public static bool MeetsRequirements(RobotParts robotParts, List<int> requiredChipsId, List<int> requiredWeaponsId, List<int> requiredOverloadId, List<int> incompatibleChipsId, TagRequirements tagRequirements, List<int> requiredDronesId = null)
	{
		return false;
	}

	public static bool MeetsTagRequirements(BuildTagIndex buildTags, TagRequirements tagRequirements)
	{
		return false;
	}

	public static string ExplainFailure(RobotParts robotParts, List<int> requiredChipsId, List<int> requiredWeaponsId, List<int> requiredOverloadId, List<int> incompatibleChipsId, TagRequirements tagRequirements, List<int> requiredDronesId = null)
	{
		return null;
	}

	private static List<int> CollectInstalledDroneIds(RobotParts robotParts)
	{
		return null;
	}

	private static string ExplainTagFailure(BuildTagIndex buildTags, TagRequirements tagRequirements)
	{
		return null;
	}

	private static string FormatIdList(List<int> ids)
	{
		return null;
	}

	private static string FormatTagList(List<GameTag> tags)
	{
		return null;
	}
}
