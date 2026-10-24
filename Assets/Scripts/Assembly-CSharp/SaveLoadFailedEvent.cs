public class SaveLoadFailedEvent : LoggableEvent
{
	public string Operation
	{
		set
		{
		}
	}

	public string ErrorMessage
	{
		set
		{
		}
	}

	public SaveLoadFailedEvent()
		: base(null)
	{
	}
}
