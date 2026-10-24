public class LevelUpChoicePickedEvent : GamePlayBaseEvent
{
	public string PickedType
	{
		set
		{
		}
	}

	public int PickedId
	{
		set
		{
		}
	}

	public int SlotIndex
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

	public bool WasUpgrade
	{
		set
		{
		}
	}

	public int CoinsAtPick
	{
		set
		{
		}
	}

	public LevelUpChoicePickedEvent()
		: base(null)
	{
	}
}
