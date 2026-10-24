using UnityEngine;
using UnityEngine.UI;

public class TestSwitchBar : MonoBehaviour
{
	[SerializeField]
	private ProgressBarPro[] progressBarPrefabs;

	[SerializeField]
	private Transform prefabParent;

	[SerializeField]
	private int currentPrefab;

	[SerializeField]
	private Text prefabName;

	private ProgressBarPro bar;

	private float currentValue;

	private void Start()
	{
	}

	public void SetRandomBar()
	{
	}

	public void ShiftBar(int shift)
	{
	}

	private void InstantiateBar(int num)
	{
	}

	private void EnableBar()
	{
	}

	public void SetValue(float value)
	{
	}

	public void SetBarColor(Color color)
	{
	}
}
