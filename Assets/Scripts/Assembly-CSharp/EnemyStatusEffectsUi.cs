using UnityEngine;

public class EnemyStatusEffectsUi : MonoBehaviour
{
	private const float ActivationPeakScale = 1.35f;

	private const float ActivationDuration = 0.2f;

	public StatusSlot Weak;

	public StatusSlot Fire;

	public StatusSlot Shock;

	public StatusSlot Mark;

	public StatusSlot SpeedBuff;

	public StatusSlot DamageBuff;

	public StatusSlot RegenBuff;

	private bool _prevFire;

	private bool _prevWeak;

	private bool _prevShock;

	private bool _prevMark;

	private bool _prevSpeedBuff;

	private bool _prevDamageBuff;

	private bool _prevRegenBuff;

	public void Bind(Transform statusTransform)
	{
	}

	public void Refresh(bool fire, bool weak, bool shock, bool mark, bool speedBuff, bool damageBuff, bool regenBuff)
	{
	}

	public void Release(Transform poolRoot)
	{
	}

	private static void ApplySlot(StatusSlot slot, bool active, ref bool previous)
	{
	}
}
