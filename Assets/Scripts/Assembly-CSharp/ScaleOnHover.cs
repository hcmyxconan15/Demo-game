using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScaleOnHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Image TargetImage;

	public float HoverScaleMultiplier;

	public float Duration;

	public Ease HoverEase;

	public Ease LeaveEase;

	public InOnEnable InOnEnable;

	private Transform _target;

	private Vector3 _originalScale;

	private Tween _scaleTween;

	private bool _sharesScaleTargetWithInOnEnable;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private bool CanHover()
	{
		return false;
	}

	private void ResolveTarget()
	{
	}

	private void CaptureOriginalScale()
	{
	}

	private void AnimateTo(Vector3 scale, Ease ease)
	{
	}

	private void KillScaleTween()
	{
	}
}
