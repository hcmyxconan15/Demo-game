using UnityEngine;
using UnityEngine.EventSystems;

public class ShowSimpleInfo : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public string InfoKey;

	public string DirectInfoText;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
