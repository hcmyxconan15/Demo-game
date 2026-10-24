using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TabButtonItems : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public TextMeshProUGUI Text;

	public Button Button;

	public Image ButtonImage;

	public Color NormalColor;

	public Color SelectedColor;

	public Sprite ActiveSprite;

	public Sprite InactiveSprite;

	public void SetStatus(bool selected)
	{
	}

	private void SetTextColor(bool selected)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
