using DG.Tweening;
using TMPro;
using UnityEngine;

public class SimpleQuestPreview : MonoBehaviour
{
	public TextMeshProUGUI QuestNameText;

	public TextMeshProUGUI QuestConditions;

	public CanvasGroup CanvasGroup;

	public RectTransform PanelRectTransform;

	public Vector2 MoveDirection;

	public int MoveDistance;

	public Ease EaseType;

	private string _name;

	private string _condition;

	private bool _showIn;

	private bool _moving;

	private void Start()
	{
	}

	public void ShowIn()
	{
	}

	public void ShowOut()
	{
	}

	public void UpdateQuestPreview(QuestActive questActive)
	{
	}
}
