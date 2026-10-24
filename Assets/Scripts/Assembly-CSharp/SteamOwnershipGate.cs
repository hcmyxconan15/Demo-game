using UnityEngine;

public static class SteamOwnershipGate
{
	public static bool ShouldBlockGameStart { get; private set; }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetOnPlayMode()
	{
	}

	public static void BlockSilent()
	{
	}

	public static void NotifyAndQuit(string logReason)
	{
	}
}
