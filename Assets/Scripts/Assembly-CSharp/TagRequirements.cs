using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TagRequirements
{
	[Tooltip("Build must have at least one of these tags")]
	public List<GameTag> RequiredAnyTags;

	[Tooltip("Build must have all of these tags")]
	public List<GameTag> RequiredAllTags;

	[Tooltip("Build must not have any of these tags")]
	public List<GameTag> IncompatibleTags;

	public bool HasRequirements => false;

	public TagRequirements Clone()
	{
		return null;
	}

	private static bool HasEntries(List<GameTag> tags)
	{
		return false;
	}

	private static List<GameTag> CopyList(List<GameTag> tags)
	{
		return null;
	}
}
