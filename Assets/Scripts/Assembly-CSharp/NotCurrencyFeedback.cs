using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NotCurrencyFeedback : MonoBehaviour
{
	public bool DoNotUseSound;

	public Transform ComponentTransform;

	public Image ImageComponent;

	public TextMeshProUGUI TextComponent;

	public Color AlertColor;

	private Color _originalTextColor;

	private Color _originalImageColor;

	private void Awake()
	{
	}

	public void ShakeSkillOnNotPointsToSpend()
	{
	}

	private void RestoreColorsOnSkillPoints()
	{
	}
}
