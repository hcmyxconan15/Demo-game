public class SessionStartEvent : LoggableEvent
{
	public string SessionId
	{
		set
		{
		}
	}

	public string Platform
	{
		set
		{
		}
	}

	public SessionStartEvent()
		: base(null)
	{
	}
}
