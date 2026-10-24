using TMPro;
using UnityEngine;

public class DropdownComponent : MonoBehaviour
{
	public int ComponentIndex;

	public TextMeshProUGUI DropDownText;

	public RectTransform RectTransform;

	public DropdownController DropdownController;

	public void SetupComponent(string textToShow, int index, DropdownController dropdownController)
	{
	}

	public void SelectThisComponent()
	{
	}

	public void IsOverThisComponent()
	{
	}
}
