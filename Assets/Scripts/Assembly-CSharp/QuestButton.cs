using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestButton : MonoBehaviour
{
	public int QuestId;

	public TextMeshProUGUI QuestName;

	public TextMeshProUGUI RunCompleted;

	public TextMeshProUGUI QuestCompletedTime;

	public TextMeshProUGUI QuestElimination;

	[Header("State")]
	public Button SelectButton;

	public NavigableButton NavigableButton;

	public GameObject CompletedMark;

	public GameObject SelectedHighlight;

	public Image Icon;

	public Color CompleteColor;

	public Color IncompleteCompleteColor;

	public void SetupQuest(int questId, string questName, string runCompleted, string questCompletedTime, string questElimination, bool completed, int questIndex, Action<int> onSelected)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void HideQuest()
	{
	}
}
