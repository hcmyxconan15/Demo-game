using UnityEngine;

public class AnimatorController : MonoBehaviour
{
	public bool InMovement;

	public bool DoNotUseAnimator;

	public Animator Animator;

	public BaseJoin BaseJoin;

	private static readonly int Y;

	private static readonly int X;

	private static readonly int TurnLeft;

	private static readonly int TurnRight;

	private static readonly int Dead;

	private Vector3 _aimDirection;

	public void SetAimAnimation(Vector3 movementDirection)
	{
	}

	public void SetTurnAnimation(bool turnLeft, bool turnRight)
	{
	}

	public void SetDeadAnimation(bool dead)
	{
	}

	public void ActiveSpecialEffectDuringRunningState(bool active)
	{
	}
}
