public class SessionEndEvent : LoggableEvent
{
	public string SessionId
	{
		set
		{
		}
	}

	public int SessionDurationSec
	{
		set
		{
		}
	}

	public int RunsThisSession
	{
		set
		{
		}
	}

	public SessionEndEvent()
		: base(null)
	{
	}
}
