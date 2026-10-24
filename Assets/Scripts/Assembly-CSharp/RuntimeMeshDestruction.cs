using System.Collections.Generic;
using UnityEngine;

public class RuntimeMeshDestruction : MonoBehaviour
{
	public float ExplosionForce;

	public float ExplosionRadius;

	public float UpwardsModifier;

	public float PartLifetime;

	public float PartMass;

	public float HideDistance;

	public float HideDuration;

	public bool DestroyOriginal;

	public Transform ExplosionOrigin;

	public Transform PartsContainer;

	public List<Transform> Parts;

	private bool _hasExploded;

	public void Explode()
	{
	}

	private void ScheduleHideThenDestroy()
	{
	}
}
