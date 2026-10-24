using System.Collections.Generic;
using UnityEngine;

public class IconsOnScreenController : MonoBehaviour
{
	public GameObject IconOnScreenParent;

	public List<IconOnScreen> IconOnScreens;

	public IconFlightSettings FlightSettings;

	private bool _arcUp;

	private readonly Dictionary<RectTransform, Vector3> _restScaleByTarget;

	private void Start()
	{
	}

	public void MoveIconToTarget(Sprite icon, RectTransform from, RectTransform to, bool hideUntilArrival)
	{
	}

	public void MoveIconToTarget(Sprite icon, Vector3 startWorldPosition, float startWorldWidth, RectTransform to, bool hideUntilArrival, float delay = 0f)
	{
	}

	private IconOnScreen GetFreeIcon()
	{
		return null;
	}

	private static void RebuildLayoutFor(RectTransform target)
	{
	}

	private static RectTransform GetSlotRoot(RectTransform icon)
	{
		return null;
	}

	private static void SetSlotHidden(RectTransform slotRoot, bool hidden)
	{
	}

	private void StopArrivalPop(RectTransform target)
	{
	}

	private void ArrivalPop(RectTransform target)
	{
	}
}
