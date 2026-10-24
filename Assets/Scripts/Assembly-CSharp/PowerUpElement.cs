using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PowerUpElement : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public int Id;

	public int Maximum;

	public Image Icon;

	public GameObject SelectedImage;

	public List<GameObject> UpgradeImages;

	public List<Image> CompletedImage;

	public PowerUpData PowerUpData;

	public Image ButtonImage;

	public Sprite NormalIconSprite;

	public Sprite FullIconSprite;

	public void InitPowerUp(PowerUpData powerUpData)
	{
	}

	public void SetupSkill(int level)
	{
	}

	public void SelectThis()
	{
	}

	public void ShowPowerUpInfo()
	{
	}

	public void OnMouseOver()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
