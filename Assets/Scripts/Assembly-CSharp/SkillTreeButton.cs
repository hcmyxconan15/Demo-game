using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SkillTreeButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public int Id;

	public int CurrentLevel;

	public int Maximum;

	public bool Unlocked;

	public bool LockedForDemo;

	public Image Icon;

	public GameObject SelectedImage;

	public GameObject CanBeUpgradeGameObject;

	public List<GameObject> UpgradeImages;

	public List<Image> CompletedImage;

	public Image ButtonImage;

	public Sprite NormalIconSprite;

	public Sprite FullIconSprite;

	public Sprite UnlockedIconSprite;

	public Sprite LockedIconSprite;

	public CanvasGroup CanvasGroup;

	public Transform SkillTreeButtonGameObject;

	public Transform SkillTreeUpgradeGameObject;

	[Header("Locked sprites")]
	public Sprite LockedForDemoIconSprite;

	public Sprite LockedForDemoSlotSprite;

	public List<SkillTreeDependencyEntry> SkillTreeButtonsNeighbors;

	private const float ScrollMovingVelocitySqr = 100f;

	public bool IsLockedForDemo => false;

	public void InitPowerUp(PowerUpData powerUpData)
	{
	}

	public void SetupSkill(int level)
	{
	}

	public void CheckUnlockStatus()
	{
	}

	public void SelectThis()
	{
	}

	public void ShowPowerUpInfo()
	{
	}

	private void ShowSkillButton(bool show)
	{
	}

	private static bool IsScrollContentMoving(PointerEventData eventData)
	{
		return false;
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
