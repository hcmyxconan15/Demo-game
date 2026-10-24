using System.Text;
using AOT;
using Steamworks;
using UnityEngine;

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	protected static bool s_EverInitialized;

	protected static SteamManager s_instance;

	protected bool m_bInitialized;

	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

	private SaveDataInGame m_SaveData;

	private uint m_AppId;

	protected static SteamManager Instance => null;

	public static bool Initialized => false;

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	private bool IsSteamApiDisabledBySaveData()
	{
		return false;
	}

	private bool IsSteamOwnershipRequired()
	{
		return false;
	}

	private static SaveDataInGame GetSaveDataInGame()
	{
		return null;
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
	}

	protected virtual void Awake()
	{
	}

	private bool ShouldEnforceOwnership()
	{
		return false;
	}

	private void WarnOnAppIdMismatch()
	{
	}

	private bool HasSteamOwnership()
	{
		return false;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Update()
	{
	}
}
