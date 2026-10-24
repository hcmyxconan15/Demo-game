using UnityEngine;

[ExecuteAlways]
public class RectTransformCircleTool : MonoBehaviour
{
	public RectTransform Center;

	public RectTransform[] Items;

	public float Radius;

	[Range(0f, 360f)]
	public float RotationOffset;

	public SkillTreeManager SkillTreeManager;

	private void Arrange()
	{
	}

	private void OnValidate()
	{
	}
}
