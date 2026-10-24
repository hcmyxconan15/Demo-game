using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NavigableButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public bool Selected;

	[Header("Settings")]
	public bool PressOnMovement;

	public bool DontAnimateOnPress;

	public bool DoNotAnimateOnSelect;

	public Button ButtonComponent;

	public InOnEnable InOnEnableComponent;

	public NavigableButton UpComponent;

	public NavigableButton RightComponent;

	public NavigableButton DownComponent;

	public NavigableButton LeftComponent;

	[Header("To Menu Navigations")]
	public MenuNavigation MenuNavigationLeft;

	public MenuNavigation MenuNavigationRight;

	public GameObject ActiveObjectOnSelected;

	public List<GameObject> OthersActiveObjectsOnSelected;

	[Header("Custom behaviours")]
	public PressOnToggle PressOnToggle;

	public ManageSliders ManageSliders;

	public DropdownController DropdownController;

	public PlaySoundButton PlaySoundButton;

	public List<RectTransform> Corners;

	public SelectedEvent SelectedEvent;

	public SelectedEvent NotInteractableOnPressEvent;

	public SelectedEvent UnselectedEvent;

	private void Awake()
	{
	}

	public void ClickOnThisButton()
	{
	}

	public void SelectThisButton(bool selected, bool doNotPlaySelectAnimation = false, bool doNotTriggerSoundOver = false)
	{
	}

	public bool MoveToAnotherMenuNavigation(MenuNavigation.InputDirection inputDirection)
	{
		return false;
	}

	private static bool HasActiveNavigableSelector(MenuNavigation navigation)
	{
		return false;
	}

	public bool MoveTo(MenuNavigation.InputDirection inputDirection)
	{
		return false;
	}

	private void SelectAnimation()
	{
	}

	private void ResetComponent()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	private void ClearKeyboardSelectionInParentMenu()
	{
	}

	private MenuNavigation FindOwningMenuNavigation()
	{
		return null;
	}

	private void ClearEventSystemSelectionIfThisButton()
	{
	}

	private static bool IsUsingJoystickInput()
	{
		return false;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
