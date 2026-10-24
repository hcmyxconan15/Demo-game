using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropBox : MonoBehaviour
{
	public enum BoxShape
	{
		BoxShape0 = 0,
		BoxShape1 = 1,
		BoxShapeSpecial = 2
	}

	public enum BoxType
	{
		UpgradeBox = 0,
		LevelUpBox = 1,
		SelectSimpleUpgradeBox = 2,
		EvolveBox = 3,
		UpgradeBoxByPay = 4
	}

	public int EffectId;

	public int CoinsToAdd;

	public int CoinsIfEmpty;

	public int MaxItemsToAdd;

	public int MinItemsToAdd;

	public BoxShape Shape;

	public BoxType CurrentBoxType;

	public bool Ready;

	public bool Taken;

	public ParticleSystem MarkerParticleSystem;

	public Transform BoxTransform;

	[Header("Get by coins")]
	public bool NeedCoins;

	public string ButtonName;

	public Transform CoinTransform;

	public TextMeshProUGUI CoinsPriceText;

	public Image CurrencyIcon;

	public Collider PhysicalCollider;

	public Color NormalColor;

	public Color AlertColor;

	public MapMarker MapMarker;

	private bool _playerTouching;

	private Transform _gravityCenterTransform;

	private MainMenuJoystickBase _mainMenuJoystick;

	private Vector3 _direction;

	private Vector3 _position;

	private bool _usingMouseOnly;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void Collect()
	{
	}

	private void CompleteCollection()
	{
	}

	private void TryToCollectWithCoins()
	{
	}

	private void SetPriceAndAlert()
	{
	}

	private void NotCurrencyFeedback()
	{
	}

	private void SetNotCurrencyStatus(bool notCoins)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
