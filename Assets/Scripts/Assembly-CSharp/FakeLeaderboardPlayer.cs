using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class FakeLeaderboardPlayer
{
	public string Name;

	public int HuntScore;

	[FormerlySerializedAs("HuntTimeSeconds")]
	[Tooltip("Thalassia completion time in seconds. 18:00 = 1080")]
	public int ThalassiaTimeSeconds;

	[Tooltip("Pyrosia completion time in seconds. 18:00 = 1080")]
	public int PyrosiaTimeSeconds;

	[Tooltip("Aureglace completion time in seconds. 18:00 = 1080")]
	public int AureglaceTimeSeconds;

	[Tooltip("Mireva completion time in seconds. 18:00 = 1080")]
	public int MirevaTimeSeconds;

	public Sprite Avatar;

	public int GetHuntTimeSeconds(int planetId)
	{
		return 0;
	}

	private int FallbackTime(int timeSeconds)
	{
		return 0;
	}
}
