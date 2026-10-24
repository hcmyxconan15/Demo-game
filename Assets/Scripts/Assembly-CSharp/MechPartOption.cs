using System;
using UnityEngine;

[Serializable]
public class MechPartOption
{
	[NonSerialized]
	[HideInInspector]
	private Func<int, Sprite> _resolveIcon;

	[NonSerialized]
	[HideInInspector]
	private Func<MechPartOption, Sprite> _resolveStartIcon;

	public MechStartOptionKind Kind;

	public int Id;

	public Sprite Icon => null;

	public void BindResolver(Func<int, Sprite> resolveIcon)
	{
	}

	public void BindResolver(Func<MechPartOption, Sprite> resolveStartIcon)
	{
	}
}
