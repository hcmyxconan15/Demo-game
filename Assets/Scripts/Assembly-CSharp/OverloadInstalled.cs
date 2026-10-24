using System;

[Serializable]
public class OverloadInstalled
{
	public int Level;

	public float ActivationCount;

	public float ActiveTimeStart;

	public float CombatTimeStart;

	public Overload Overload;

	private int _activeRandomValue;

	private float _lastActivationTime;

	public bool PassesActivationInterval()
	{
		return false;
	}

	public void RecordActivation()
	{
	}

	public void ResetActivationInterval()
	{
	}

	public bool TryActivateByPercent()
	{
		return false;
	}

	public bool TryActivateByPercentAndCount(int amount)
	{
		return false;
	}

	public int TryActivateByPercentAndCountTimes(int amount)
	{
		return 0;
	}

	private void EnsureActivationCounterInitialized()
	{
	}

	public bool TriggerOverLoad(int amount)
	{
		return false;
	}

	private int TriggerOverLoadTimes(int amount)
	{
		return 0;
	}

	public bool TriggerOverLoadByPercent()
	{
		return false;
	}

	private bool PassesHealActivationRequirements()
	{
		return false;
	}

	public bool IsStatusVisible(bool isMovingForOverloadTriggers, bool isEffectivelyStationary, Stats stats)
	{
		return false;
	}
}
