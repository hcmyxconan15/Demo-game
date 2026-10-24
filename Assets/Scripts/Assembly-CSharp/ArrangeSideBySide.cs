using System.Collections.Generic;
using UnityEngine;

public class ArrangeSideBySide : MonoBehaviour
{
	[Tooltip("List of objects to arrange")]
	public List<GameObject> objectsToArrange;

	[Tooltip("Size of each object along X (if you want to override bounds)")]
	public List<float> objectSizes;

	[Tooltip("Gap between objects")]
	public float spacing;

	[Tooltip("Arrange along X axis")]
	public bool horizontal;

	[ContextMenu("Arrange Objects")]
	public void Arrange()
	{
	}
}
