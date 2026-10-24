using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemySetupConfig", menuName = "GameData/New enemy setup configuration")]
public class EnemySetupToSelect : ScriptableObject
{
	public List<EnemyStepSetup> EnemySetups;

	public EnemiesDb EnemiesDb;

	public bool DontSetLevelAutomatic;

	private int _randomSelectValue;

	private List<int> _enemyByLevelToSelect;

	[TextArea(3, 10)]
	public string LevelSetup;

	public EnemyStepSetup GetEnemyStepSetupRandom()
	{
		return null;
	}

	public EnemyStepSetup GetEnemySetupByStepLevel(int stepLevel)
	{
		return null;
	}

	private void OnValidate()
	{
	}

	public void RefreshEditorNames()
	{
	}

	[ContextMenu("Set String On")]
	public void SetStringOn()
	{
	}

	private string GetCurrentLevelSetupList()
	{
		return null;
	}
}
