public abstract class GamePlayBaseEvent : LoggableEvent
{
	public int PlayerLevel
	{
		set
		{
		}
	}

	public int RobotId
	{
		set
		{
		}
	}

	public string Weapons
	{
		set
		{
		}
	}

	public string Overload
	{
		set
		{
		}
	}

	public string Chips
	{
		set
		{
		}
	}

	public string RunId
	{
		set
		{
		}
	}

	protected GamePlayBaseEvent(string eventName)
		: base(null)
	{
	}
}
