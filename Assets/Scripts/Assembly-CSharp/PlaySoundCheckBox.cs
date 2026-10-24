using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundCheckBox : MonoBehaviour
{
	public delegate void ClickButton(int index);

	public bool OnlySoundOnActive;

	[CompilerGenerated]
	private static ClickButton m_OnClickedCheckBox;

	[SerializeField]
	private int SoundIndex;

	private Toggle _toggleComponent;

	public static event ClickButton OnClickedCheckBox
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void PlayButtonSound(bool value)
	{
	}
}
