using UnityEngine;

public class MissileDamage : DamageBase
{
	private const float CameraShakeCooldown = 0.08f;

	private static float _nextCameraShakeTime;

	public float DamageRadius;

	public LayerMask RayCasterLayer;

	public short EffectId;

	public override void ApplyExpandDamage()
	{
	}
}
