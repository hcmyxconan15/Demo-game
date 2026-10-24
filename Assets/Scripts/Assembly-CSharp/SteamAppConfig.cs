public static class SteamAppConfig
{
	public const uint ReleaseAppId = 2773630u;

	public const uint DemoAppId = 4699340u;

	public const uint PlaytestAppId = 4311480u;

	public static uint AppId => 0u;

	public static uint GetAppId(SaveDataInGame.GameBuildChannel channel)
	{
		return 0u;
	}

	private static SaveDataInGame.GameBuildChannel GetBuildChannel()
	{
		return SaveDataInGame.GameBuildChannel.Release;
	}
}
