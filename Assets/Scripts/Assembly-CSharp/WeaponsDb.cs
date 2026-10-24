using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapons DB", menuName = "GameData/Weapon/new Weapon db")]
public class WeaponsDb : ScriptableObject, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class _003CEnumerateAllWeapons_003Ed__18 : IEnumerable<Weapon>, IEnumerable, IEnumerator<Weapon>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Weapon _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		public WeaponsDb _003C_003E4__this;

		private List<Weapon>.Enumerator _003C_003E7__wrap1;

		Weapon IEnumerator<Weapon>.Current
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
		public _003CEnumerateAllWeapons_003Ed__18(int _003C_003E1__state)
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

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		IEnumerator<Weapon> IEnumerable<Weapon>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	public List<Weapon> Weapons;

	public BulletsDb BulletsDb;

	public WeaponsDb WeaponsEvolutionsDb;

	public UnlockDb UnlockDb;

	public ChipDb ChipDb;

	public OverloadDb OverloadDb;

	public WeaponProficiencyConfig WeaponProficiencyConfig;

	public List<int> PhysicProjectileWeapons;

	public List<int> EnergyProjectileWeapons;

	public List<int> MissileWeapons;

	public List<int> BeamWeapons;

	public List<int> Others;

	public List<UnlockItemData> UnlockList;

	private static readonly Dictionary<int, int> KnownOrphanEvolutionIdsByBaseId;

	public Weapon GetWeapon(int weaponId)
	{
		return null;
	}

	public bool IsEvolutionWeapon(int weaponId)
	{
		return false;
	}

	public List<Weapon> GetEvolutionWeapons()
	{
		return null;
	}

	public int GetBaseWeaponIdForEvolution(int evolutionWeaponId)
	{
		return 0;
	}

	public Weapon GetBaseWeaponForEvolution(int evolutionWeaponId)
	{
		return null;
	}

	public int ResolveProficiencyWeaponId(int weaponId)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CEnumerateAllWeapons_003Ed__18))]
	public IEnumerable<Weapon> EnumerateAllWeapons()
	{
		return null;
	}

	private void OnValidate()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	private void IsolateTagGates()
	{
	}

	private void RefreshWeaponListMetadata()
	{
	}

	public ChipDb GetChipDbReference()
	{
		return null;
	}

	public OverloadDb GetOverloadDbReference()
	{
		return null;
	}

	private string GetUnlockConditionText(int weaponId)
	{
		return null;
	}

	public void FillUnlockList()
	{
	}

	private static string GetEvolutionLabel(Weapon weapon)
	{
		return null;
	}

	public void EnsurePlaceholderEvolutionsForAllWeapons()
	{
	}

	private int GetNextPlaceholderEvolutionId()
	{
		return 0;
	}

	private Weapon FindExistingPlaceholderEvolution(Weapon baseWeapon)
	{
		return null;
	}

	private static void AlignPlaceholderFlagsWithBase(Weapon evolutionWeapon, Weapon baseWeapon)
	{
	}

	private static Weapon CloneWeaponAsPlaceholderEvolution(Weapon baseWeapon, ushort evolutionId)
	{
		return null;
	}

	public void SyncEvolutionBaseStatsFromMaxLevel()
	{
	}
}
