using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AvatarInfo : MonoBehaviour
{
	public int Id;

	public Image AvatarImage;

	[SerializeField]
	private TextMeshProUGUI LevelTextOnAvatar;

	[Header("Damage Feedback")]
	[SerializeField]
	private float DamageShakeDuration;

	[SerializeField]
	private float DamageShakeX;

	[SerializeField]
	private float DamageShakeY;

	[SerializeField]
	private float DamageKickUp;

	[SerializeField]
	private float DamageTintDuration;

	[SerializeField]
	private Color DamageTintColor;

	private RectTransform _avatarRect;

	private Sequence _damageSequence;

	private Vector2 _restAnchoredPos;

	private Color _restColor;

	private bool _restCached;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void SetAvatar(Pilot pilot)
	{
	}

	private void CacheRestState()
	{
	}

	private void RestoreRestState()
	{
	}

	public void DamageAvatar()
	{
	}
}
