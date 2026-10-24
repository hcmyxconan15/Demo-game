using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlaySoundButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	public delegate void ClickButton(int index);

	public bool UseNegativeShakeOnPress;

	public bool AllowSoundOnOverIfNotInteractable;

	public CanvasGroup CanvasGroup;

	[CompilerGenerated]
	private static ClickButton m_OnClicked;

	public int SoundIndex;

	public int HoverSoundIndex;

	private Button _buttonComponent;

	public static event ClickButton OnClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void PlayButtonSound()
	{
	}

	public void NegativeShakeOnPress()
	{
	}

	public void NegativeShakeOnPressAndNegativeSound()
	{
	}

	public void PlaySoundOver()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}
}
