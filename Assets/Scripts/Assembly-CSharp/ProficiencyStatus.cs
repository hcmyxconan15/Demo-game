using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProficiencyStatus : MonoBehaviour
{
	public GameObject ProficiencyStatusPanel;

	public Slider ProficiencyStatusSlider;

	public TextMeshProUGUI ProficiencyStatusText;

	public TextMeshProUGUI ProficiencyLevelText;

	public List<TextMeshProUGUI> StatGainTexts;

	public List<Image> StatGainImage;

	public Color NormalColor;

	public Color InactiveColor;

	public Color ValueColor;

	public Color EvolutionColor;

	public Color ActiveImageColor;

	public Color DisableImageColor;

	[Tooltip("Multiplier applied to ValueColor when the reward level is not yet unlocked.")]
	public float InactiveValueDarken;

	public void SetProficiencyStatus(int currentLevel, float proficiency, float proficiencyMax)
	{
	}

	public void SetProficiencyStatus(int currentLevel, float proficiency, float proficiencyMax, Weapon weapon, WeaponProficiencyConfig config)
	{
	}

	public void ActiveInfo(bool active)
	{
	}

	private void RefreshStatGainTexts(int currentLevel, Weapon weapon, WeaponProficiencyConfig config)
	{
	}

	private void HideStatGainTexts()
	{
	}

	private void SetStatGainImageColor(int index, bool isActive)
	{
	}

	private Image GetStatGainImage(int index)
	{
		return null;
	}

	private string FormatGainLine(string wordKey, string valueText, bool isActive)
	{
		return null;
	}

	private Color DarkenValueColor(Color color)
	{
		return default;
	}

	private static string GetStatWordKey(WeaponProficiencyStat stat)
	{
		return null;
	}

	private static string FormatBonusValue(WeaponProficiencyStat stat, float value)
	{
		return null;
	}
}
