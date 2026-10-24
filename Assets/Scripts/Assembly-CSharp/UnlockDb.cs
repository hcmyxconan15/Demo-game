using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "newUnlockDb", menuName = "GameData/new unlockDb")]
public class UnlockDb : ScriptableObject
{
	[CompilerGenerated]
	private sealed class _003CEnumerateAllUnlockItems_003Ed__27 : IEnumerable<ItemToUnlock>, IEnumerable, IEnumerator<ItemToUnlock>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private ItemToUnlock _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public UnlockDb _003C_003E4__this;

		private List<ItemToUnlock>.Enumerator _003C_003E7__wrap1;

		ItemToUnlock IEnumerator<ItemToUnlock>.Current
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
		public _003CEnumerateAllUnlockItems_003Ed__27(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		private void _003C_003Em__Finally3()
		{
		}

		private void _003C_003Em__Finally4()
		{
		}

		private void _003C_003Em__Finally5()
		{
		}

		private void _003C_003Em__Finally6()
		{
		}

		private void _003C_003Em__Finally7()
		{
		}

		private void _003C_003Em__Finally8()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<ItemToUnlock> IEnumerable<ItemToUnlock>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public List<ItemToUnlock> MechUnlocks;

	public List<ItemToUnlock> WeaponUnlocks;

	public List<ItemToUnlock> MicroChipUnlocks;

	public List<ItemToUnlock> OverloadUnlocks;

	public List<ItemToUnlock> DroneUnlocks;

	public List<ItemToUnlock> PilotUnlocks;

	public List<ItemToUnlock> BaseUnlocks;

	public List<ItemToUnlock> BodyUnlocks;

	public WeaponsDb WeaponsDb;

	public DroneDb DroneDb;

	public ChipDb ChipDb;

	public OverloadDb OverloadDb;

	public RobotBodyDb RobotBodyDb;

	public RobotBaseDb RobotBaseDb;

	public MechaDataBase MechaDataBase;

	public PilotDb PilotDb;

	public EnemiesDb EnemiesDb;

	public List<ItemUnlockMissing> MissingMech;

	public List<ItemUnlockMissing> MissingWeapons;

	public List<ItemUnlockMissing> MissingMicroChip;

	public List<ItemUnlockMissing> MissingOverload;

	public List<ItemUnlockMissing> MissingDrone;

	public List<ItemUnlockMissing> MissingPilot;

	public List<ItemUnlockMissing> MissingBase;

	public List<ItemUnlockMissing> MissingBody;

	public List<ItemToUnlock> GetUnlockList(ItemToUnlock.UnlockType type)
	{
		return null;
	}

	public ItemToUnlock FindUnlock(int itemId, ItemToUnlock.UnlockType type)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CEnumerateAllUnlockItems_003Ed__27))]
	public IEnumerable<ItemToUnlock> EnumerateAllUnlockItems()
	{
		return null;
	}

	private void TryAddMissing(int itemId, ItemToUnlock.UnlockType type, string itemName, List<ItemUnlockMissing> targetList)
	{
	}

	private void ClearMissingLists()
	{
	}

	private bool HasUnlockEntry(int itemId, ItemToUnlock.UnlockType type)
	{
		return false;
	}

	private void OnValidate()
	{
	}

	private void BindEditorSources()
	{
	}

	private void BindUnlockList(List<ItemToUnlock> list)
	{
	}

	private void BindMissingList(List<ItemUnlockMissing> list)
	{
	}

	private void AssignListMeta(List<ItemToUnlock> list, ItemToUnlock.UnlockType type)
	{
	}

	public bool TryGetStarterMechFollowLabel(ItemToUnlock.UnlockType type, int itemId, out string label)
	{
		label = null;
		return false;
	}

	private void SyncMechStarterLoadoutConditions()
	{
	}

	private void SyncStarterSlot(Mech mech, ItemToUnlock mechUnlock, ItemToUnlock.UnlockType type, int itemId, Dictionary<long, int> claimedStarterSlots)
	{
	}

	private bool TryGetOwningStarterMech(ItemToUnlock.UnlockType type, int itemId, out Mech mech)
	{
		mech = null;
		return false;
	}

	private static bool IsStarterSlot(Mech mech, ItemToUnlock.UnlockType type, int itemId)
	{
		return false;
	}

	private List<ItemToUnlock> EnsureUnlockList(ItemToUnlock.UnlockType type)
	{
		return null;
	}

	private static bool ConditionsMatch(UnlockCondition left, UnlockCondition right)
	{
		return false;
	}

	private static UnlockCondition CopyCondition(UnlockCondition source)
	{
		return null;
	}

	private static void CopyConditionInto(UnlockCondition source, UnlockCondition target)
	{
	}

	public string GetItemDisplayName(ItemToUnlock.UnlockType type, int itemId)
	{
		return null;
	}

	public Sprite GetItemIcon(ItemToUnlock.UnlockType type, int itemId)
	{
		return null;
	}
}
