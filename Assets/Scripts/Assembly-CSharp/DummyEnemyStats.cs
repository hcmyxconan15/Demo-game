public class DummyEnemyStats : StatsBase
{
	public override void ApplyDamage(DamageBase damageBaseStats, bool showDamageText)
	{
	}

	public override void ApplyFireDamage(int damage)
	{
	}

	public override void ApplyDamageOtherSource(int weaponId, int damage, bool critical, float pushBackForce, float inmuneTime)
	{
	}

	public override void AddLife(int life)
	{
	}

	public override void AddLifeBasedOnPercents(int lifePercent)
	{
	}

	public override void ApplyPureDamage(int damage)
	{
	}

	public override void ApplyPureDamageBasedOnPercents(int percentFromCurrentLife)
	{
	}

	public override void ApplyFiredState(float timer, float potency, int tickNeedForAccumulatedFirePotencyUp)
	{
	}

	public override void ManageFiredState()
	{
	}

	public override void ApplyShockState(float timer)
	{
	}

	public override void ManageShockState()
	{
	}

	public override void ApplyWeakState(float timer)
	{
	}

	public override void ManageWeakState()
	{
	}

	public override void ApplyMarkState(float timer, int criticalChanceBonusPercent)
	{
	}

	public override void ManageMarkState()
	{
	}

	public override void Dead()
	{
	}

	public override void DisableNotDead()
	{
	}

	public override void IncreaseAttackByTime(int increasePercent, int time)
	{
	}
}
