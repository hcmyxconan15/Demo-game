using System.Collections.Generic;
using UnityEngine;

public class DirectionMarkersController : MonoBehaviour
{
	public Transform ItemDirectionParent;

	public ItemDirection ItemDirectionPrefab;

	public ItemDirection PowerUpDirectionPrefab;

	public List<ItemDirection> ItemDirections;

	public List<ItemDirection> PowerUpDirections;

	public void SetItemToTrack(Transform itemTransform)
	{
	}

	public void SetPowerUpToTrack(Transform itemTransform)
	{
	}
}
