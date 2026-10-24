using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EvolveWeapon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEvolveWeaponCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int weaponId;

		public int newWeaponId;

		public EvolveWeapon _003C_003E4__this;

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
		public _003CEvolveWeaponCoroutine_003Ed__19(int _003C_003E1__state)
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

	public bool EvolveWeaponOpen;

	public bool ConfirmEvolution;

	public GameObject EvolvePanel;

	public TextMeshProUGUI EvolveButtonText;

	public Button EvolveConfirmButton;

	public GameObject EvolveText;

	public SkillButton SkillButtonWeaponToEvolve;

	public SkillButton SkillButtonNewWeapon;

	public BoxAnimation BoxAnimation;

	public bool OpenEvolveChestMade;

	public void InitBoxAnimation()
	{
	}

	public void OpenBoxAnimation()
	{
	}

	public void ReadyToOpenBox()
	{
	}

	public void ReadyToContinue()
	{
	}

	public void PressConfirmEvolution()
	{
	}

	public void StartEvolveWeapon(int weaponId, int newWeaponId)
	{
	}

	public void ForceAbortPresentation()
	{
	}

	private void SetupWeaponToEvolve(Weapon weapon)
	{
	}

	private void SetupWeaponNewEvolve(Weapon weapon)
	{
	}

	[IteratorStateMachine(typeof(_003CEvolveWeaponCoroutine_003Ed__19))]
	private IEnumerator EvolveWeaponCoroutine(int weaponId, int newWeaponId)
	{
		return null;
	}
}
