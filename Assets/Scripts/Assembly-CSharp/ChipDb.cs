using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New StatsPowerUp DB", menuName = "GameData/StatsPowerUp")]
public class ChipDb : ScriptableObject, ISerializationCallbackReceiver
{
	public List<Microchip> Microchips;

	public UnlockDb UnlockDb;

	public Color ColorPlus;

	public List<UnlockItemData> UnlockList;

	[Multiline(10)]
	public string Names;

	public Microchip GetMicrochip(int id)
	{
		return null;
	}

	public string GetMicrochipStatsInfo(int microchipId)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void IsolateTagGates()
	{
	}

	private void RefreshMicrochipDescriptions()
	{
	}

	private string GetUnlockConditionText(int microchipId)
	{
		return null;
	}

	public void FillUnlockList()
	{
	}

	public void GetMicrochipsNames()
	{
	}

	public void SetUnlockPrice()
	{
	}
}
