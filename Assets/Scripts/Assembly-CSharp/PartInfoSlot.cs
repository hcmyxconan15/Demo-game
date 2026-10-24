using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PartInfoSlot : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Image Icon;

	public TextMeshProUGUI Text;

	public GameObject FullComponent;

	private string _hoverInfoText;

	private void Awake()
	{
	}

	public void SetInfo(Sprite icon, string compactText, string hoverText)
	{
	}

	public void Hide()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
