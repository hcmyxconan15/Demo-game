using DG.Tweening;
using TMPro;
using UnityEngine;

public class AnimateWriterText : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI TextUI;

	private string _message;

	[SerializeField]
	private float CharacterDelay;

	private int _lastVisibleChar;

	private Tween _writeTween;

	private void Awake()
	{
	}

	public void SetText(string text)
	{
	}

	public void StartTextAnimation()
	{
	}
}
