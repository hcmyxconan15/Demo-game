using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifetimeManager : MonoBehaviour
{
	private static ProjectileLifetimeManager _instance;

	private readonly List<IProjectileLifetimeTick> _active;

	public static void RegisterTick(IProjectileLifetimeTick tick)
	{
	}

	public static void UnregisterTick(IProjectileLifetimeTick tick)
	{
	}

	private static ProjectileLifetimeManager GetOrCreate()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void RegisterTickInternal(IProjectileLifetimeTick tick)
	{
	}

	private void UnregisterTickInternal(IProjectileLifetimeTick tick)
	{
	}

	private void Update()
	{
	}
}
