using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainQuestActiveComponent : MonoBehaviour
{
	public ConditionToNextNode.PassNodeType ActiveCondition;

	[Header("Kill Ui")]
	public CanvasGroup KillCanvasGroup;

	public Image Icon;

	public TextMeshProUGUI QuestConditionText;

	public TextMeshProUGUI QuestValueStatus;

	public ProgressBarPro KillerTimerBar;

	[Header("Time Ui")]
	public CanvasGroup TimerCanvasGroup;

	public TextMeshProUGUI QuestTimeConditionText;

	public TextMeshProUGUI QuestTimerValueStatus;

	public ProgressBarPro TimerBar;

	public CanvasGroup CanvasGroup;

	public RectTransform PanelRectTransform;

	public Vector2 MoveDirection;

	public int MoveDistance;

	public Ease EaseType;

	public UnityEvent EndMovement;

	private float _valueToReach;

	private float _valueKillerTimeToReach;

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

	public void UpdateMainQuestPreview(ConditionToNextNode conditionToNextNode)
	{
	}

	public void UpdateQuestValue(float value)
	{
	}

	public void UpdateKillerNodeTimer(float value)
	{
	}

	private void MovementInEnd()
	{
	}
}
