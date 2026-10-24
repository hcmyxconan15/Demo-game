using UnityEngine;

public class PointOfInterestMarkerUi : MonoBehaviour
{
	public Transform PointOfInterestOnMap;

	public CanvasGroup CanvasGroup;

	public bool Active;

	public PointComponent PointComponent;

	public Camera WorldCamera;

	public Vector3 WorldOffset;

	public float EdgePadding;

	public bool UseDistanceFromCenter;

	public float CenterPadding;

	public float ArrowRotationOffset;

	public bool HideWhenBehindCamera;

	private RectTransform _boundsRectTransform;

	private Canvas _canvas;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void SetPointOfInterest(Transform pointOfInterestOnMap)
	{
	}

	public void ActivePointOfInterest(bool active)
	{
	}

	public void ShowFromUiPanels(bool show)
	{
	}

	private void CacheCanvasReferences()
	{
	}

	private void UpdateMarkerPosition()
	{
	}

	private bool IsOnScreen(Vector3 screenPoint)
	{
		return false;
	}

	private Vector2 GetClampedScreenPosition(Vector2 screenPosition, bool isBehindCamera)
	{
		return default;
	}

	private void SetArrowVisible(bool showArrow, Vector2 screenPosition)
	{
	}

	private void SetMarkerVisible(bool visible)
	{
	}
}
