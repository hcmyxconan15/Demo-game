using UnityEngine;
using UnityEngine.Events;

public abstract class QuestItemOnMap : MonoBehaviour
{
	public int ItemId;

	public int PositionOnMapIndex;

	public UnityEvent CollectionComplete;
}
