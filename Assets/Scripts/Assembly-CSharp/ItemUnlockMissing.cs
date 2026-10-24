using System;
using UnityEngine;

[Serializable]
public class ItemUnlockMissing
{
	[NonSerialized]
	[HideInInspector]
	private UnlockDb _unlockDb;

	public string NameDescription;

	public int ItemId;

	public ItemToUnlock.UnlockType Type;

	private Sprite ItemIcon => null;

	public void BindEditorSources(UnlockDb unlockDb)
	{
	}
}
