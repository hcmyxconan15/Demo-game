using System.Collections.Generic;
using Unity.Services.Analytics;

public abstract class LoggableEvent : Event
{
	public readonly string EventName;

	public readonly Dictionary<string, object> LoggedParameters;

	protected LoggableEvent(string eventName)
		: base(null)
	{
	}

	protected void SetParam(string key, int value)
	{
	}

	protected void SetParam(string key, long value)
	{
	}

	protected void SetParam(string key, float value)
	{
	}

	protected void SetParam(string key, double value)
	{
	}

	protected void SetParam(string key, bool value)
	{
	}

	protected void SetParam(string key, string value)
	{
	}
}
