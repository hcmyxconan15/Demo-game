using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

public class ReportBugToDiscord : MonoBehaviour
{
	public string EmailAddress;

	public string Subject;

	public string DiscordChannelUrl;

	public UnityEvent OnReportCopied;

	private const uint AssocFIsProtocol = 4096u;

	private const uint AssocStrCommand = 1u;

	private const uint AssocStrFriendlyAppName = 4u;

	private const uint AssocStrProgId = 20u;

	private const uint SOk = 0u;

	private const uint SFalse = 1u;

	public void ReportBug()
	{
	}

	private bool TryOpenEmail(string body)
	{
		return false;
	}

	private void OpenDiscordFallback(string body)
	{
	}

	private static bool CanLaunchEmail()
	{
		return false;
	}

	[PreserveSig]
	private static extern uint AssocQueryString(uint flags, uint str, string pszAssoc, string pszExtra, StringBuilder pszOut, ref uint pcchOut);

	private static bool HasWindowsMailtoHandler()
	{
		return false;
	}

	private static bool HasWindowsMailtoAssociation(uint associationKind)
	{
		return false;
	}

	private static string EscapeUrl(string text)
	{
		return null;
	}

	private static string BuildReportBody()
	{
		return null;
	}

	private static string GetLanguageName(int languageIndex)
	{
		return null;
	}

	private static string GetGameData(DataUser data)
	{
		return null;
	}

	private static string GetOptionsData(DataUser data)
	{
		return null;
	}

	private static int To01(bool value)
	{
		return 0;
	}

	private static string GetPlayTime()
	{
		return null;
	}

	private static string FormatPlayTime(float seconds)
	{
		return null;
	}

	private static string GetSteamInfo()
	{
		return null;
	}
}
