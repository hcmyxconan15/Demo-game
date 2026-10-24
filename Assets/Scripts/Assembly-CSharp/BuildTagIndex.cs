using System.Collections.Generic;

public sealed class BuildTagIndex
{
	private readonly Dictionary<GameTag, int> _counts;

	private readonly List<GameTag> _activeTags;

	public IReadOnlyList<GameTag> ActiveTags => null;

	public int Count(GameTag tag)
	{
		return 0;
	}

	public bool Has(GameTag tag)
	{
		return false;
	}

	public static BuildTagIndex FromRobotParts(RobotParts robotParts)
	{
		return null;
	}

	public List<GameTag> GetTopTags(int maxCount)
	{
		return null;
	}

	private void AddTags(List<GameTag> tags)
	{
	}
}
