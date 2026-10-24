using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BeaconPortal : MonoBehaviour
{
	public bool ActiveShield;

	public ParticleSystem ParticleSystem;

	public Transform ShieldTransform;

	public List<Renderer> ShieldRenders;

	private static readonly int AppearGradientOffset;

	private Tween _shieldTween;

	private bool _closing;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayArriveAndDisable()
	{
	}

	public void PlayFadeOutAndDisable()
	{
	}

	public void ActivateShield()
	{
	}

	private void DeActivateShieldAndDestroy()
	{
	}

	private void OnDestroy()
	{
	}
}
