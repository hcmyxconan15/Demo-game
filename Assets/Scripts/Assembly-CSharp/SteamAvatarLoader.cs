using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;

public class SteamAvatarLoader : MonoBehaviour
{
	public static SteamAvatarLoader Instance;

	[CompilerGenerated]
	private Action m_AvatarLoaded;

	private Callback<AvatarImageLoaded_t> _avatarImageLoaded;

	private readonly Dictionary<ulong, Texture2D> _textureCache;

	private readonly Dictionary<ulong, List<Action<Texture2D>>> _pendingCallbacks;

	private readonly HashSet<ulong> _requestedUserInfo;

	public event Action AvatarLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static SteamAvatarLoader EnsureInstance()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void RequestAvatar(ulong steamIdRaw, Action<Texture2D> onLoaded)
	{
	}

	private void EnsureCallbackRegistered()
	{
	}

	private void TryLoadAvatar(ulong steamIdRaw, CSteamID steamId)
	{
	}

	private void OnAvatarImageLoaded(AvatarImageLoaded_t callback)
	{
	}

	private static Texture2D CreateTextureFromHandle(int imageHandle)
	{
		return null;
	}

	private void CompletePending(ulong steamIdRaw, Texture2D texture)
	{
	}
}
