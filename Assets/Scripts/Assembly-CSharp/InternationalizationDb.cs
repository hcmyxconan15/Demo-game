using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Internationalization DB", menuName = "GameData/new Internationalization DB")]
public class InternationalizationDb : ScriptableObject
{
	public List<LanKey> Words;

	public string GetWord(int langIndex, string keyId)
	{
		return null;
	}
}
