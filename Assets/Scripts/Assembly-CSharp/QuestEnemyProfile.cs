using UnityEngine;

[CreateAssetMenu(fileName = "New Quest Enemy Profile", menuName = "GameData/Enemies/new quest enemy profile")]
public class QuestEnemyProfile : ScriptableObject
{
	public EnemySetupToSelect StageEnemyConfiguration;

	public EnemySetupToSelect EndgameEnemyConfiguration;

	public EnemySetupToSelect NormalEliteEnemy;

	public EnemySetupToSelect EliteEnemy;

	public EnemySetupToSelect BossEnemy;

	public EnemySetupToSelect Mercenary;

	public EnemySetupToSelect OptionalHuntEnemy;
}
