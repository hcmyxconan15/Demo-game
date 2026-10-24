using System.Collections.Generic;
using UnityEngine;

public class ActiveEffectTicker : MonoBehaviour
{
	private static ActiveEffectTicker _instance;

	private readonly List<IActiveEffectTick> _active;

	private readonly List<IActiveEffectTick> _activeLate;

	public static void Register(IActiveEffectTick tick)
	{
	}

	public static void Unregister(IActiveEffectTick tick)
	{
	}

	public static void RegisterLate(IActiveEffectTick tick)
	{
	}

	public static void UnregisterLate(IActiveEffectTick tick)
	{
	}

	private static ActiveEffectTicker GetOrCreate()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Add(List<IActiveEffectTick> list, IActiveEffectTick tick)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private static void Tick(List<IActiveEffectTick> list)
	{
	}
}
