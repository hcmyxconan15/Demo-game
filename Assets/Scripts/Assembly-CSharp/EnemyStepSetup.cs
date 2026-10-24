using System;
using System.Collections.Generic;

[Serializable]
public class EnemyStepSetup
{
	public string SetupName;

	public int StepLevel;

	public int MaxEnemiesAliveOnStep;

	public int PrisonId;

	public float ActivePrisonTime;

	public List<EnemyStepConfig> EnemySetups;
}
