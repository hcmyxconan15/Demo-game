using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
	public int EnemyId;

	public string EnemyName;

	public bool QuestEnemy;

	public EnemyData.EnemyType Type;

	public bool DropItemBox;

	public DropBox.BoxType BoxType;

	public bool EndGameEnemy;

	public bool LockTargetEnemy;

	public List<int> EnemyPartsId;

	public Transform Target;

	public StatsBase Stats;

	public Collider EnemyCollider;

	public EnemyMovement EnemyMovement;

	public PushBackEffect PushBackEffect;

	public FlashOnDamageMaterial FlashOnDamage;

	public Animator EnemyAnimator;

	public bool NodeSelectUpgradeDrop { get; private set; }

	public EnemyOffscreenLod OffscreenLod { get; private set; }

	protected virtual void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public abstract void ActiveEnemy(Vector3 position);

	public void SetQuestEnemy(bool questEnemy)
	{
	}

	public void SetNodeSelectUpgradeDrop(bool enabled)
	{
	}
}
