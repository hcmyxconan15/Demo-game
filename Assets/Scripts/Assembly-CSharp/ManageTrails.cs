using System.Collections.Generic;
using UnityEngine;

public class ManageTrails : MonoBehaviour
{
	private sealed class DetachedTrailTicker : MonoBehaviour
	{
		private void Update()
		{
		}

		private void OnDestroy()
		{
		}
	}

	private const float MaxLingerSeconds = 5f;

	public ParticleSystem TrailParticleSystem;

	private Transform _trailOrigin;

	private Vector3 _trailLocalPosition;

	private Quaternion _trailLocalRotation;

	private Vector3 _trailLocalScale;

	private bool _detached;

	private float _reattachUnscaledTime;

	private static readonly List<ManageTrails> Detached;

	private static DetachedTrailTicker _ticker;

	public void ResetTrail()
	{
	}

	public void DeactivateTrail()
	{
	}

	public void DetachTrail()
	{
	}

	internal void TickDetached()
	{
	}

	private void CacheTrailOrigin()
	{
	}

	private void ReattachTrail(bool clearParticles)
	{
	}

	private float GetLingerTime()
	{
		return 0f;
	}

	private void RegisterDetached()
	{
	}

	private void UnregisterDetached()
	{
	}

	private void OnDestroy()
	{
	}

	private static void EnsureTicker()
	{
	}
}
