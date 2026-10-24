using Rewired;
using UnityEngine;

public class InputController : MonoBehaviour
{
	[Tooltip("This is the layer for the ground.")]
	public LayerMask GroundLayer;

	public Player PlayerRewired;

	private void Awake()
	{
	}

	public Vector3 GetMouseDirection()
	{
		return default;
	}
}
