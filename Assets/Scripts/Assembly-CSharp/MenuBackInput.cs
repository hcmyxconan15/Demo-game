public static class MenuBackInput
{
	private static int _consumedFrame;

	public static bool ConsumedThisFrame => false;

	public static bool TryConsume()
	{
		return false;
	}

	public static bool ShouldBlockGlobalBack()
	{
		return false;
	}
}
