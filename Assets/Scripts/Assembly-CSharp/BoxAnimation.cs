using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

public class BoxAnimation : MonoBehaviour
{
	public Transform FullComponent;

	public Transform CoverComponent;

	public ParticleSystem IdleParticles;

	public ParticleSystem OpenParticles;

	public UnityEvent StartIdleEvent;

	[SerializeField]
	private float _openDuration;

	[SerializeField]
	private float _lidOpenAngleX;

	[SerializeField]
	private Vector3 _fullJuiceEulerOffset;

	[SerializeField]
	private Ease _openEase;

	[SerializeField]
	private float _spinInDuration;

	[SerializeField]
	private Vector3 _spinInEuler;

	[SerializeField]
	private Ease _spinInEase;

	[SerializeField]
	private float _idleShakeSegmentDuration;

	[SerializeField]
	private float _idleShakeStrength;

	[SerializeField]
	private int _idleShakeVibrato;

	[SerializeField]
	private float _idleShakePauseDuration;

	private Sequence _sequence;

	private float _timeScale;

	private Vector3 _initialFullEuler;

	private Vector3 _initialFullScale;

	private Vector3 _initialCoverEuler;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void AnimateIn(float timeScale = 1f)
	{
	}

	private void IdleStatus()
	{
	}

	public void OpenAnimate(float timeScale = 1f)
	{
	}

	private void ApplySequenceTimeScale()
	{
	}

	public void Restart()
	{
	}

	private void KillTweening()
	{
	}

	private void CacheInitialTransforms()
	{
	}

	private void ApplyOpenProgress(float t)
	{
	}
}
