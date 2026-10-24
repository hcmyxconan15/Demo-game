using System.Collections.Generic;
using UnityEngine;

public struct OverloadDeployContext
{
	public int OverloadId;

	public int SlotIndex;

	public int MaxSlots;

	public float Lifetime;

	public Transform DeployAnchor;

	public bool UseFixedLandingAnchor;

	public Vector3 FixedLandingAnchor;

	public List<Vector3> BurstReservedLandings;

	public float BurstLandingSeparation;
}
