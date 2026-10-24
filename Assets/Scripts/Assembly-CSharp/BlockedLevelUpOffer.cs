public readonly struct BlockedLevelUpOffer
{
	public int TypeId { get; }

	public int ItemId { get; }

	public string Reason { get; }

	public BlockedLevelUpOffer(int typeId, int itemId, string reason)
	{
		TypeId = 0;
		ItemId = 0;
		Reason = null;
	}
}
