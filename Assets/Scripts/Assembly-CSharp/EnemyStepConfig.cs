using System;

[Serializable]
public class EnemyStepConfig
{
	public string EnemyName;

	public int EnemyIndex;

	public int EnemyNumberToSpam;

	public float SpamIntervalInitialTime;

	public float SpamInterval;

	public float SpamTimes;

	public bool InfinitySpawn;

	public bool OnceTimeSpawn;
}
