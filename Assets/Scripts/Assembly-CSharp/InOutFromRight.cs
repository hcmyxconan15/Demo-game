using DG.Tweening;
using UnityEngine;

public class InOutFromRight : MonoBehaviour
{
	public enum HideDirection
	{
		Left = 0,
		Right = 1,
		Up = 3,
		Down = 4
	}

	public bool OnMovement;

	public HideDirection HideCanvasDirection;

	public CanvasGroup CanvasGroup;

	public RectTransform PanelRectTransform;

	public float MoveDistance;

	public float Duration;

	public float DurationOut;

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

	[ContextMenu("Move left")]
	public void MovePanelLeft()
	{
	}

	[ContextMenu("Move right")]
	public void MovePanelRight()
	{
	}

	public void CompleteMovement()
	{
	}
}
