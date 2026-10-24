using DG.Tweening;
using UnityEngine;

public class IdleAnimation : MonoBehaviour
{
	[SerializeField]
	private Vector3 MinScale;

	[SerializeField]
	private Vector3 MaxScale;

	[SerializeField]
	private float Duration;

	private Tween _scaleTween;

	private void OnEnable()
	{
	}

	private void AnimateIdle()
	{
	}

	private void OnDisable()
	{
	}
}
