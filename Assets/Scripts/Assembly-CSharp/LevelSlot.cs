using DG.Tweening;
using UnityEngine;

public class LevelSlot : MonoBehaviour
{
	public GameObject Component;

	public GameObject ActiveIcon;

	public GameObject NextLevelImage;

	private const float IdlePeakScale = 1.15f;

	private const float IdleDuration = 0.8f;

	private Tween _nextLevelIdleTween;

	public void SetSlotStatus(bool componentActive, bool levelPassed, bool isNextLevel = false)
	{
	}

	private void SetNextLevelIndicator(bool active)
	{
	}

	private void OnDisable()
	{
	}
}
