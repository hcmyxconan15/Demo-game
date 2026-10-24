using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

public class InAnimateTransformOnEnable : MonoBehaviour
{
	public int SoundIndex;

	public float Delay;

	public bool IdleOnComplete;

	public bool InOutType;

	public Transform ComponentTransform;

	public float TimeScale;

	private TweenerCore<Vector3, Vector3, VectorOptions> _twCore0;

	private TweenerCore<Vector3, Vector3, VectorOptions> _twCore1;

	private Sequence _twCore;

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void AnimateOnEnable()
	{
	}

	private void OnComplete()
	{
	}

	private void IdleAnimation()
	{
	}

	private void KillTweens()
	{
	}
}
