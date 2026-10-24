using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New achievement DB", menuName = "GameData/Achievement/new achievement db")]
public class AchievementsDatabase : ScriptableObject
{
	public enum AchievementApiName
	{
		ROOKIE_ACHIEVEMENT = 0,
		MASTER_ACHIEVEMENT = 1,
		PEST_CONTROL = 2
	}

	public enum StatsApiName
	{
		None = 0,
		stat_score = 1,
		stat_enemies_defeated = 2,
		stat_enemies_normal_defeated = 3,
		stat_enemies_elite_defeated = 4,
		stat_enemies_mercenary_defeated = 5,
		stat_enemies_boss_defeated = 6,
		stat_chest_open = 7,
		stat_quest_completed = 8,
		stat_run_completed = 10,
		stat_weapon_level_max = 11,
		stat_microchip_level_max = 12,
		stat_weapon_damage = 13,
		stat_weapon_damage_max = 14,
		stat_any_weapon_level_max = 15,
		stat_any_microchip_level_max = 16,
		stat_runs_started = 17,
		stat_nodes_cleared = 18,
		stat_dashes = 19,
		stat_overloads_activated = 20,
		stat_shops_visited = 21,
		stat_elites_one_run = 22,
		stat_enemies_defeated_with_mecha = 23,
		stat_enemies_elite_defeated_with_mecha = 24,
		stat_quest_completed_with_mecha = 25,
		stat_nodes_cleared_with_mecha = 26,
		stat_planet_completed = 27,
		stat_enemy_defeated = 28
	}

	public List<Achievement> Achievements;
}
