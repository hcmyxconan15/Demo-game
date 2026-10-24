using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class IconOnScreen : MonoBehaviour
{
	public Image IconImage;

	public bool InUse;

	private RectTransform _rectTransform;

	private Sequence _flightSequence;

	private RectTransform Rect => null;

	public void Fly(Sprite icon, RectTransform from, RectTransform to, Vector3 pathDirection, IconFlightSettings settings, Action onArrive)
	{
	}

	public void Fly(Sprite icon, Vector3 startWorldPosition, float startWorldWidth, RectTransform to, Vector3 pathDirection, IconFlightSettings settings, Action onArrive, float delay = 0f)
	{
	}

	public void Hide()
	{
	}

	public static float GetWorldWidth(RectTransform rectTransform)
	{
		return 0f;
	}

	private float GetScaleToMatchSizeOf(RectTransform other)
	{
		return 0f;
	}

	private float GetScaleToMatchWidth(float worldWidth)
	{
		return 0f;
	}
}
