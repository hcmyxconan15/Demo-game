public class PlayerDeathEvent : GamePlayBaseEvent
{
	public string CurrentNodeType
	{
		set
		{
		}
	}

	public int TimeAliveSec
	{
		set
		{
		}
	}

	public int PlayerLevelAtDeath
	{
		set
		{
		}
	}

	public bool RevivalAvailable
	{
		set
		{
		}
	}

	public PlayerDeathEvent()
		: base(null)
	{
	}
}
