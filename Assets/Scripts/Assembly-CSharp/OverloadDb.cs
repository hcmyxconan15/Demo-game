using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Overload DB", menuName = "GameData/new Overload db")]
public class OverloadDb : ScriptableObject, ISerializationCallbackReceiver
{
	public List<Overload> Overloads;

	public UnlockDb UnlockDb;

	public BulletsDb BulletsDb;

	public List<UnlockItemData> UnlockList;

	public Overload GetOverload(int id)
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

	private void RefreshOverloadDescriptions()
	{
	}

	private string GetUnlockConditionText(int overloadId)
	{
		return null;
	}

	public void FillUnlockList()
	{
	}

	public void SetUnlockPrice()
	{
	}
}
