using DG.Tweening;
using UnityEngine;

public class InOutFromLeft : MonoBehaviour
{
	public bool OnMovement;

	public InOutFromRight.HideDirection HideCanvasDirection;

	public CanvasGroup CanvasGroup;

	public RectTransform PanelRectTransform;

	public float MoveDistance;

	public float Duration;

	public float DurationOut;

	public float DelayTimeLeft;

	public float DelayTimeRight;

	public Ease EaseType;

	public Ease EaseTypeBack;

	private Vector2 _leftPosition;

	private Vector2 _rightPosition;

	private bool _positionsCached;

	private void CachePositions(bool movingLeft)
	{
	}

	private void KillActiveTweens()
	{
	}

	public void MovePanelLeft()
	{
	}

	public void MovePanelRight()
	{
	}
}
