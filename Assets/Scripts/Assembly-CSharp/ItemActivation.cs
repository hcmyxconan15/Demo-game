using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ItemActivation : MonoBehaviour
{
	public Image IconImage;

	public Image SlotImage;

	public CanvasGroup CanvasGroup;

	public RectTransform RectTransform;

	public Sprite SlotMicrochip;

	public Sprite SlotOverload;

	private Sequence _sequence;

	private Transform _followTarget;

	private Vector3 _worldOffset;

	private Camera _worldCamera;

	private float _floatUpDistance;

	private float _floatProgress;

	private bool _tracking;

	public bool IsFree => false;

	public void ShowActivationFollowing(Sprite icon, bool isMicrochip, Transform followTarget, Vector3 worldOffset, Camera worldCamera, float floatUpDistance, float duration, float startScale, float endScale)
	{
	}

	private void LateUpdate()
	{
	}

	private void ApplyFollowPosition()
	{
	}

	private void OnDisable()
	{
	}
}
