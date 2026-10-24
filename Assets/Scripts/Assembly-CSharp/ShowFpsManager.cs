using TMPro;
using UnityEngine;

public class ShowFpsManager : MonoBehaviour
{
	public bool ShowFps;

	public TextMeshProUGUI FpsText;

	public Color BadFpsColor;

	public Color NormalFpsColor;

	public float UpdateInterval;

	private const int BadFpsThreshold = 24;

	private float _timeLeft;

	private float _accumulative;

	private int _frames;

	private int _lastDisplayedFps;

	private bool _wasBadFps;

	public static ShowFpsManager Instance;

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void SetShowFps()
	{
	}

	private void Update()
	{
	}
}
