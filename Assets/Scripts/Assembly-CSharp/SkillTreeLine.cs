using UnityEngine;
using UnityEngine.UI;

public class SkillTreeLine : MonoBehaviour
{
	[SerializeField]
	private float LineWeight;

	[SerializeField]
	private Image LineImage;

	[SerializeField]
	private RectTransform Point1;

	[SerializeField]
	private RectTransform Point2;

	[SerializeField]
	private RectTransform ComponentRectTransform;

	[SerializeField]
	private Color LineColorDisable;

	[SerializeField]
	private Color LineColorEnable;

	private Vector3 _size;

	public void Init(RectTransform point1, RectTransform point2)
	{
	}

	public void SetLine()
	{
	}

	public void SetLineColor(bool enable)
	{
	}

	public void DisableRaycast()
	{
	}
}
