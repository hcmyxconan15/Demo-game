using System;
using UnityEngine;

[Serializable]
public class EventConclusion
{
	public bool HaveConclusionText;

	public string ConclusionText;

	[Tooltip("Condition Id to apply for condition that can use id")]
	public int ConditionId;

	public UnknownEvent.EventRewardType RewardType;
}
