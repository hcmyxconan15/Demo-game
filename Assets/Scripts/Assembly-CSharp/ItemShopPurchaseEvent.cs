public class ItemShopPurchaseEvent : GamePlayBaseEvent
{
	public string ItemType
	{
		set
		{
		}
	}

	public int ItemId
	{
		set
		{
		}
	}

	public int ItemLevelBefore
	{
		set
		{
		}
	}

	public int CoinsSpent
	{
		set
		{
		}
	}

	public int CoinsBalanceAfter
	{
		set
		{
		}
	}

	public ItemShopPurchaseEvent()
		: base(null)
	{
	}
}
