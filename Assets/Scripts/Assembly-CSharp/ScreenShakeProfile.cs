using System;
using UnityEngine;

[Serializable]
public class ScreenShakeProfile
{
	public string ProfileName;

	[Header("Impulse Source Setting")]
	public float ImpulseTime;

	public float ImpulseForce;

	public Vector3 DefaultVelocity;

	public AnimationCurve ImpulseCurve;

	[Header("Impulse Listener Setting")]
	public float ListenerAmplitude;

	public float ListenerFrequency;

	public float ListenerDuration;
}
