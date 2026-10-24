using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ParticleEffect
{
	public string Name;

	public List<ParticleSystem> ParticleSystems;

	[NonSerialized]
	private int _rentCursor;

	public ParticleSystem GetEffectToPlay()
	{
		return null;
	}

	public ParticleSystem RentNextWhenFull()
	{
		return null;
	}
}
