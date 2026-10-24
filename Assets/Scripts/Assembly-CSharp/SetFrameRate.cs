using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetFrameRate : MonoBehaviour
{
	[SerializeField]
	private bool ShowFps;

	[SerializeField]
	private bool Caped;

	[SerializeField]
	private int TargetFrameRate;

	[SerializeField]
	private TextMeshProUGUI Fps;

	[SerializeField]
	private TextMeshProUGUI Resolution;

	[SerializeField]
	private List<TextMeshProUGUI> Version;

	[SerializeField]
	private float UpdateInterval;

	private float _accum;

	private int _frames;

	private float _timeLeft;

	private float _fps;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CapFrameRate(bool capFrames)
	{
	}
}
