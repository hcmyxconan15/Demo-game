using System;

[Serializable]
public class PlanetQuest
{
	public int QuestId;

	public string Name;

	public int MarkerPointIndex;

	public QuestEnemyProfile EnemyProfile;

	public bool NotAvailable;
}
