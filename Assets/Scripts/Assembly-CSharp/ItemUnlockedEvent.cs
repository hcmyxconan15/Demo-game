public class ItemUnlockedEvent : GamePlayBaseEvent
{
	public int ItemId
	{
		set
		{
		}
	}

	public string ItemType
	{
		set
		{
		}
	}

	public string UnlockMethod
	{
		set
		{
		}
	}

	public ItemUnlockedEvent()
		: base(null)
	{
	}
}
