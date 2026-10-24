using System.Collections.Generic;
using DamageNumbersPro;
using UnityEngine;

public class PopUpTextController : MonoBehaviour
{
	public bool UseDamageNumbers;

	public List<DamageNumber> DamageNumbers;

	public static PopUpTextController Instance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CheckCurrentDamageNumbersSettingsStatus()
	{
	}

	public void PopUpTextOnPosition(Transform position, int index, int value)
	{
	}
}
