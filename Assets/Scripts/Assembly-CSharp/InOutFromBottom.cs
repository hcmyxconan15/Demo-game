using DG.Tweening;
using UnityEngine;

public class InOutFromBottom : MonoBehaviour
{
	public bool OnMovement;

	public InOutFromRight.HideDirection HideCanvasDirection;

	public CanvasGroup CanvasGroup;

	public bool ManageInteractable;

	public RectTransform PanelRectTransform;

	public float MoveDistance;

	public float Duration;

	public float DurationOut;

	public Ease EaseType;

	public Ease EaseTypeBack;

	public void MovePanelBottom()
	{
	}

	public void MovePanelUp()
	{
	}

	private void Interactable(bool interactable)
	{
	}
}
