using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardRebindSlot : MonoBehaviour
{
	private const string MapCategory = "Default";

	private const string MapLayout = "Default";

	public string ActionName;

	public AxisRange ActionRange;

	public string CompanionActionName;

	public TextMeshProUGUI Label;

	public Button Button;

	private KeyboardRebindController _controller;

	public void Initialize(KeyboardRebindController controller)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClicked()
	{
	}

	public void SetListeningVisual(bool listening)
	{
	}

	public void RefreshLabel()
	{
	}

	public ActionElementMap FindPrimaryElementMap()
	{
		return null;
	}

	public static ControllerMap GetKeyboardMap()
	{
		return null;
	}

	public static ActionElementMap FindElementMapForAction(ControllerMap keyboardMap, int actionId, AxisRange actionRange)
	{
		return null;
	}

	public static ActionElementMap FindNonArrowElementMap(ControllerMap keyboardMap, int actionId)
	{
		return null;
	}

	public static bool IsArrowKey(KeyCode keyCode)
	{
		return false;
	}
}
