using System;

[Serializable]
public struct WeaponProficiencyBonuses
{
	public float DamagePercent;

	public float AttackRatePercent;

	public float ReloadPercent;

	public float MagazineFlat;

	public float IntervalPercent;

	public float OnWeak;

	public float OnFire;

	public float OnShock;

	public float OnMark;

	public float OnMarkCriticalChanceBonus;
}
