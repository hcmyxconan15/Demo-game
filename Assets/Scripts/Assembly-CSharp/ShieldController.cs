using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
	public bool ActiveShield;

	public Transform ShieldTransform;

	public List<Renderer> ShieldRenders;

	private static readonly int AppearGradientOffset;

	private Tween _shieldTween;

	public void ActivateShield()
	{
	}

	public void DeActivateShield()
	{
	}

	private void DeActiveShieldTransform()
	{
	}
}
