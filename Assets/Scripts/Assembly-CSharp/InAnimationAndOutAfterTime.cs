using DG.Tweening;
using UnityEngine;

public class InAnimationAndOutAfterTime : MonoBehaviour
{
	public float YMovement;

	public float Delay;

	public float InDuration;

	public float OutDuration;

	public float VisibleTime;

	public float ShakeDuration;

	public float ShakeStrength;

	public int ShakeVibrato;

	public Ease InEase;

	public Ease OutEase;

	private Sequence _sequence;

	private Vector3 _startLocalPosition;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void PlayAnimation()
	{
	}

	private void KillSequence()
	{
	}
}
