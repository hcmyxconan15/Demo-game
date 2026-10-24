using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AdvanceMapConditionsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpenMapAfterCompleteNode_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AdvanceMapConditionsController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003COpenMapAfterCompleteNode_003Ed__53(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public bool SelectingNode;

	public bool CompletingNodeTransition;

	public bool MapEnded;

	public float CurrentKillerTimeForThisNode;

	public float MaxTimeForThisNode;

	public int MapLevelStatus;

	public int EnemyLevelStatus;

	public int EliteEnemyLevelStatus;

	public int MercenaryEnemyLevelStatus;

	public int OptionalHuntLevelStatus;

	public ConditionToNextNode ConditionToNextNodeSelected;

	public List<ConditionToNextNode> ConditionsToNextNode;

	public NextMapNodeConditionPanel NextMapNodeConditionPanel;

	[SerializeField]
	private GameControllers GameControllers;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void KillEnemy(EnemyBase enemyBase, int value)
	{
	}

	private void SubtractObjectiveProgress(float amount)
	{
	}

	private void CheckNextNodeCondition()
	{
	}

	private void ManageNodeStepByTime()
	{
	}

	private void ManageKillNodeTime()
	{
	}

	public void StarMapSelectionOnStartLevel()
	{
	}

	public void CompleteMapNodeCondition()
	{
	}

	public void SelectNode(NodeTypeComponent nodeTypeComponent)
	{
	}

	private void ApplyNodeSelected(NodeTypeComponent nodeTypeComponent)
	{
	}

	private void InitialNodeSelected()
	{
	}

	private void EnemyNodeSelected(int stepLevel)
	{
	}

	private void EliteEnemyNodeSelected(int stepLevel)
	{
	}

	private void MercenaryNodeSelected(int stepLevel)
	{
	}

	private void TreasureNodeSelected()
	{
	}

	private void ShopNodeSelected()
	{
	}

	private void RestNodeSelected()
	{
	}

	private void UnknownNodeSelected(int nodeLevel)
	{
	}

	private void OptionalHuntNodeSelected(int optionalHuntLevelStatus)
	{
	}

	private void SpecialEventNodeSelected()
	{
	}

	private void BossNodeSelected()
	{
	}

	private void EndMap()
	{
	}

	private void ApplyTimeNodeCondition()
	{
	}

	private void ApplyTreasureNodeCondition()
	{
	}

	private void ApplyRestNodeCondition()
	{
	}

	private void ApplyShopNodeCondition()
	{
	}

	private void ApplyUnknowNodeCondition()
	{
	}

	private void ApplyKillEnemyNodeCondition()
	{
	}

	private void ApplyKillEliteNodeCondition()
	{
	}

	private void ApplyKillMercenaryNodeCondition()
	{
	}

	private void ApplyOptionalHuntNodeCondition()
	{
	}

	private void ApplySpecialNodeCondition()
	{
	}

	private float GetMercenaryFailSafeTime()
	{
		return 0f;
	}

	private void ApplyKillBossNodeCondition()
	{
	}

	private void SetCondition(ConditionToNextNode conditionToNextNode)
	{
	}

	private ConditionToNextNode GetConditionToNextNode(ConditionToNextNode.PassNodeType condition)
	{
		return null;
	}

	private bool CanOpenMapAfterCompleteNode()
	{
		return false;
	}

	private void AbortOpenMapAfterRunEnded()
	{
	}

	[IteratorStateMachine(typeof(_003COpenMapAfterCompleteNode_003Ed__53))]
	private IEnumerator OpenMapAfterCompleteNode()
	{
		return null;
	}
}
