using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class StatusSlot : MonoBehaviour
{
	public Image StatusImage;

	public Image StatusBackground;

	public RectTransform StatusRectTransform;

	private Tween _activationScaleTween;

	public void PlayActivationScale(float peakScale, float duration)
	{
	}

	private void OnDisable()
	{
	}
}
