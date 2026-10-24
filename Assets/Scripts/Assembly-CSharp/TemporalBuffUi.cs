using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class TemporalBuffUi : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public string BuffId;

	public string BuffInfo;

	public CanvasGroup CanvasGroup;

	public Color ColorPlus;

	private Tween _alphaTween;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetBufExtraInfo(int valueToShow)
	{
	}

	public void Deactivate()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void LoopAlphaAnimation()
	{
	}
}
