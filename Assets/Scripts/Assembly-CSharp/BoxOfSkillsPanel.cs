using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoxOfSkillsPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAddBoxResults_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoxOfSkillsPanel _003C_003E4__this;

		public int coinsToAdd;

		public List<int> microchipsToSelect;

		public List<int> weaponsToSelect;

		public List<int> overloadsToSelect;

		public List<int> microchipsToUpgrade;

		public List<int> weaponsToUpgrade;

		public List<int> overloadsToUpgrade;

		public int choiceToAdd;

		public Action<int> onCoinsFromGoldSlots;

		private int _003CcoinsFromGoldSlots_003E5__2;

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
		public _003CAddBoxResults_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CSmoothIntFill_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoxOfSkillsPanel _003C_003E4__this;

		public int targetValue;

		public TextMeshProUGUI textMeshProUGUI;

		private float _003Celapsed_003E5__2;

		private float _003Cduration_003E5__3;

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
		public _003CSmoothIntFill_003Ed__22(int _003C_003E1__state)
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

	public int CoinsToAd;

	public DropBox.BoxShape CurrentShape;

	public TextMeshProUGUI ButonText;

	public Button ContinueButton;

	public GameObject CoinsToAddPanel;

	public TextMeshProUGUI CoinsOnBoxText;

	public CanvasGroup SkillSelectionFromBoxCanvas;

	public List<SkillButton> SkillButtonsFromBox;

	public BoxAnimation BoxAnimation;

	public BoxAnimation BoxAnimationShape1;

	public BoxAnimation BoxAnimationShapeSpecial;

	public const float SequenceSpeedMultiplier = 3f;

	private bool SpeedUpBoxSequence => false;

	public float ScaledRealtime(float seconds)
	{
		return 0f;
	}

	private float GetAnimationTimeScale()
	{
		return 0f;
	}

	public void InitBoxAnimation(DropBox.BoxShape boxShape)
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

	public void HideBoxRewardContents()
	{
	}

	public void ActiveBoxRewardsCanvas(bool active)
	{
	}

	[IteratorStateMachine(typeof(_003CSmoothIntFill_003Ed__22))]
	private IEnumerator SmoothIntFill(int targetValue, TextMeshProUGUI textMeshProUGUI)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAddBoxResults_003Ed__23))]
	public IEnumerator AddBoxResults(int choiceToAdd, int coinsToAdd, List<int> weaponsToUpgrade, List<int> weaponsToSelect, List<int> microchipsToUpgrade, List<int> microchipsToSelect, List<int> overloadsToUpgrade, List<int> overloadsToSelect, Action<int> onCoinsFromGoldSlots)
	{
		return null;
	}

	private void AddMicrochipResult(int buttonIndex, List<int> microchipsToUpgrade, List<int> microchipsToSelect)
	{
	}

	private void AddWeaponResult(int buttonIndex, List<int> weaponsToUpgrade, List<int> weaponsToSelect)
	{
	}

	private void AddOverloadResult(int buttonIndex, List<int> overloadsToUpgrade, List<int> overloadsToSelect)
	{
	}
}
