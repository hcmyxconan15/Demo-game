using UnityEngine;

[AddComponentMenu("MiniMap/Marker Group")]
[RequireComponent(typeof(RectTransform))]
public class MarkerGroup : MonoBehaviour
{
	private RectTransform _rectTransform;

	public RectTransform MarkerGroupRect => null;
}
