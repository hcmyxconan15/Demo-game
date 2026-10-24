using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("MiniMap/Inner map")]
[RequireComponent(typeof(Image))]
public class InnerMap : MonoBehaviour
{
	private RectTransform _innerMapRect;

	public RectTransform InnerMapRect => null;

	public float getMapRadius()
	{
		return 0f;
	}
}
