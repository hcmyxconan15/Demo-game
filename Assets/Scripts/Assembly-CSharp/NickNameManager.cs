using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NickNameManager : MonoBehaviour
{
	public bool NickNameSet;

	public GameObject NickNamePanel;

	public TMP_InputField NickNameInput;

	public Button SubmitButton;

	public TextMeshProUGUI AcceptButtonText;

	public Color InvalidColor;

	public Color ValidColor;

	public List<string> RandomNickNames;

	public MainMenuJoystick MainMenuJoystick;

	private const int MinNickNameLength = 3;

	private const int MaxNickNameLength = 16;

	private static readonly Regex InvalidCharactersRegex;

	private const string NickNameKey = "NickName";

	private void Awake()
	{
	}

	public void OpenNickNamePanel()
	{
	}

	public void CloseNickNamePanel()
	{
	}

	public void CheckNickName(string nickName)
	{
	}

	public void SetNickName()
	{
	}

	public void SetRandomNickName()
	{
	}

	private string GetRandomNickName()
	{
		return null;
	}

	private bool IsNickNameValid(string nickName)
	{
		return false;
	}

	private string SanitizeNickName(string nickName)
	{
		return null;
	}
}
