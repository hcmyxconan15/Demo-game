public class SettingChangedEvent : LoggableEvent
{
	public string SettingKey
	{
		set
		{
		}
	}

	public string OldValue
	{
		set
		{
		}
	}

	public string NewValue
	{
		set
		{
		}
	}

	public SettingChangedEvent()
		: base(null)
	{
	}
}
