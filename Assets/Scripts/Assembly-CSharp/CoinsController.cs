using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsController : MonoBehaviour
{
	public bool AllowCoinMovement;

	public Transform EndCoinsPosition;

	public TextMeshProUGUI CoinsText;

	public List<ParticleSystem> ParticleSystem;

	public List<BunchOfCoins> BunchOfCoinsList;

	public Camera MainCamera;

	public Animator ConAnimator;

	public NotCurrencyFeedback NotCurrencyFeedback;

	public static CoinsController Instance;

	private static readonly int Animate;

	private int _displayedCoins;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CheckCurrentAllowCoinMovementSettingsStatus()
	{
	}

	public void UpdateCoin()
	{
	}

	public void AddDisplayedCoins(int coins)
	{
	}

	private void SetCoinsText(int coins)
	{
	}

	public void AddCoinsFromUIPosition(int coins, Vector3 startPosition, Vector3 pathDirection, bool alreadyCredited = false)
	{
	}

	public void AddCoinsFrom3DdWorldPosition(int coins, Transform startPosition, Vector3 pathDirection, bool alreadyCredited = false)
	{
	}

	public void AnimateCoin()
	{
	}

	public void TriggerNotCurrencyFeedback()
	{
	}

	private BunchOfCoins GetFreeBunchOfCoins()
	{
		return null;
	}
}
