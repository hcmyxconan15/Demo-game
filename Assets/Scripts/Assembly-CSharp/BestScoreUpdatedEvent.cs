public class BestScoreUpdatedEvent : GamePlayBaseEvent
{
	public int Score
	{
		set
		{
		}
	}

	public int PreviousBest
	{
		set
		{
		}
	}

	public int Delta
	{
		set
		{
		}
	}

	public BestScoreUpdatedEvent()
		: base(null)
	{
	}
}
