using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EvolutionRequirementOption
{
	[NonSerialized]
	[HideInInspector]
	private Func<int, Sprite> _resolveIcon;

	public int Id;

	public Sprite Icon => null;

	public void BindResolver(Func<int, Sprite> resolveIcon)
	{
	}

	public static void BindOptions(List<EvolutionRequirementOption> options, Func<int, Sprite> resolveIcon)
	{
	}
}
