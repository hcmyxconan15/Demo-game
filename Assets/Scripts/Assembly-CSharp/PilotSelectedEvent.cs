public class PilotSelectedEvent : GamePlayBaseEvent
{
	public int PilotId
	{
		set
		{
		}
	}

	public int PreviousPilotId
	{
		set
		{
		}
	}

	public PilotSelectedEvent()
		: base(null)
	{
	}
}
