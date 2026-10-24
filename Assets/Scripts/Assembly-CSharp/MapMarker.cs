using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("MiniMap/Map marker")]
public class MapMarker : MonoBehaviour
{
	public Sprite markerSprite;

	public Color MarkerSpriteColor;

	public float markerSize;

	public bool isActive;

	private Color _color;

	private Image markerImage;

	private MapCanvasController controller;

	public Image MarkerImage => null;

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public void show()
	{
	}

	public void hide()
	{
	}

	public bool isVisible()
	{
		return false;
	}

	public Vector3 getPosition()
	{
		return default;
	}

	public void setLocalPos(Vector3 pos)
	{
	}

	public void setOpacity(float opacity)
	{
	}
}
