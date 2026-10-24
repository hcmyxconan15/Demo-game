using System;
using UnityEngine;

[Serializable]
public class AttackSetting
{
	public int EffectId;

	public Transform EffectTransformPosition;

	public GameObject AttackCollider;

	[Header("Attacks alerts")]
	public int AlertId;
}
