using UnityEngine;

[AddComponentMenu("MiniMap/Map canvas controller")]
[RequireComponent(typeof(RectTransform))]
public class MapCanvasController : MonoBehaviour
{
	private static MapCanvasController _instance;

	public Transform playerTransform;

	public Transform Camera;

	public float radarDistance;

	public bool hideOutOfRadius;

	public bool useOpacity;

	public float maxRadarDistance;

	public bool rotateMap;

	public float scale;

	public float minimalOpacity;

	private RectTransform mapRect;

	private InnerMap innerMap;

	private MapArrow mapArrow;

	private MarkerGroup markerGroup;

	private float innerMapRadius;

	public static MapCanvasController Instance => null;

	public InnerMap InnerMapComponent => null;

	public MarkerGroup MarkerGroup => null;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void checkIn(MapMarker marker)
	{
	}

	private float distanceToPlayer(Vector3 other)
	{
		return 0f;
	}
}
