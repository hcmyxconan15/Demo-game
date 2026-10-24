public class PlanetSelectedEvent : GamePlayBaseEvent
{
	public int PlanetId
	{
		set
		{
		}
	}

	public int PreviousPlanetId
	{
		set
		{
		}
	}

	public PlanetSelectedEvent()
		: base(null)
	{
	}
}
