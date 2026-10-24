using System.Collections.Generic;
using UnityEngine;

public class BodyJoin : MonoBehaviour
{
	public Transform BaseTransform;

	public List<Renderer> Renderers;

	public List<WeaponPosition> WeaponsPositions;

	public DronePositionController DronePositionController;

	public OthersPosition OthersPositions;

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}
}
