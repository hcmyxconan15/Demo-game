using UnityEngine;

public abstract class MovementController : MonoBehaviour
{
	public enum MovementType
	{
		TypeA = 0,
		TypeB = 1
	}

	public MovementType SelectedMovementType;

	public MechPlayerController MechPlayerController;

	public Vector3 InputDirection;

	public float CurrentVelocity;

	public bool DoNotAllowSpecialAction;

	public int BaseDashCharges;

	public int MaxDashCharges;

	public int CurrentDashCharges;

	public int DashTimesUsedInRun;

	public bool SpecialActionReady => false;

	public virtual bool IsDashContactImmune => false;

	public virtual void CancelDash()
	{
	}

	public abstract void Move();

	public abstract void Rotate();

	public abstract void Dash();

	public abstract void SetDash(float dashTimer, int baseDashCharges = 1);

	public abstract Quaternion GetInputDirection();

	public abstract void IncreaseSpeedByTime(float speed, float time);

	public abstract void ActiveDashParticles(bool active);

	public abstract void ActiveDriftParticles(bool active);
}
