using System.Collections.Generic;

public sealed class BuildArchetypeIndex
{
	private readonly Dictionary<BuildArchetype, int> _counts;

	private readonly List<BuildArchetype> _activeArchetypes;

	public IReadOnlyList<BuildArchetype> ActiveArchetypes => null;

	public int Count(BuildArchetype archetype)
	{
		return 0;
	}

	public bool Has(BuildArchetype archetype)
	{
		return false;
	}

	public static BuildArchetypeIndex FromRobotParts(RobotParts robotParts)
	{
		return null;
	}

	public static BuildArchetypeIndex FromSeedRobotParts(RobotParts robotParts, IReadOnlyList<int> startingWeaponIds, int startingDroneId = -1)
	{
		return null;
	}

	public List<BuildArchetype> GetTopArchetypes(int maxCount)
	{
		return null;
	}

	private void AddArchetypes(List<BuildArchetype> archetypes)
	{
	}
}
