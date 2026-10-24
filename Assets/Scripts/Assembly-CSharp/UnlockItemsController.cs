using System.Collections.Generic;
using UnityEngine;

public class UnlockItemsController : MonoBehaviour
{
	public UnlockDb UnlockDb;

	public static UnlockItemsController Instance;

	private void Awake()
	{
	}

	public List<ItemToUnlock> CheckItemsUnlocked()
	{
		return null;
	}

	private static void ReportItemUnlocked(ItemToUnlock itemToUnlock, string typeKey)
	{
	}
}
