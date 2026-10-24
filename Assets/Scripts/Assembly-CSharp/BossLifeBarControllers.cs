using System.Collections.Generic;
using UnityEngine;

public class BossLifeBarControllers : MonoBehaviour
{
	public CanvasGroup BossLifeBarsCanvasGroup;

	public List<BossLifeBarUi> BossLifeBars;

	public static BossLifeBarControllers Instance;

	private void Awake()
	{
	}

	public BossLifeBarUi GetBossLifeBar()
	{
		return null;
	}
}
