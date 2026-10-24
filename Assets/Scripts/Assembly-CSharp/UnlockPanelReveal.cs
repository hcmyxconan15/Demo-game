using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UnlockPanelReveal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public bool popComplete;

		public int remaining;

		public Action _003C_003E9__3;

		internal void _003CPlayProficiencyReveal_003Eb__0()
		{
		}

		internal bool _003CPlayProficiencyReveal_003Eb__1()
		{
			return false;
		}

		internal void _003CPlayProficiencyReveal_003Eb__3()
		{
		}

		internal bool _003CPlayProficiencyReveal_003Eb__2()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public bool complete;

		internal void _003CPlayUnlockItemReveal_003Eb__0()
		{
		}

		internal bool _003CPlayUnlockItemReveal_003Eb__1()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CPlayProficiencyReveal_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockPanelReveal _003C_003E4__this;

		public List<WeaponProficiencyGain> proficiencyGains;

		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		private WeaponProficiencyConfig _003Cconfig_003E5__2;

		private List<ProficiencyEndGameComponent> _003CactiveComponents_003E5__3;

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
		public _003CPlayProficiencyReveal_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CPlayUnlockItemReveal_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockPanelReveal _003C_003E4__this;

		public List<ItemToUnlock> revealItems;

		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

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
		public _003CPlayUnlockItemReveal_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CRevealPanelCoroutine_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockPanelReveal _003C_003E4__this;

		public List<WeaponProficiencyGain> proficiencyGains;

		public List<ItemToUnlock> itemsToUnlock;

		private bool _003ChasGains_003E5__2;

		private List<ItemToUnlock> _003CrevealItems_003E5__3;

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
		public _003CRevealPanelCoroutine_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CRunFillAndCountDown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProficiencyEndGameComponent component;

		public WeaponProficiencyGain gain;

		public WeaponProficiencyConfig config;

		public Action onComplete;

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
		public _003CRunFillAndCountDown_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CWaitForStageContinue_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UnlockPanelReveal _003C_003E4__this;

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
		public _003CWaitForStageContinue_003Ed__33(int _003C_003E1__state)
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

	public GameObject UnlockPanel;

	public Sprite WeaponSlotSprite;

	public Sprite OverloadSlotSprite;

	public Sprite MicrochipSlotSprite;

	public GameObject NextButton;

	public CanvasGroup UnlockPanelCanvasGroup;

	public GridLayoutGroup GridLayoutUnlockItems;

	public UnlockItemReveal UnlockItemRevealPrefab;

	public Transform UnlockItemRevealsContent;

	public List<UnlockItemReveal> UnlockItemReveals;

	[Header("Weapons Proficiency")]
	public Transform ProficiencyContent;

	public ProficiencyEndGameComponent ProficiencyEndGameComponentPrefab;

	public List<ProficiencyEndGameComponent> ProficiencyEndGameComponents;

	public float ProficiencyRevealStagger;

	public float ProficiencyPopInDuration;

	public float ProficiencyStampDuration;

	public AnimateWriterText WriterText;

	[Header("Reveal animation")]
	public float RevealDelayBetweenItems;

	public float RevealPopInDuration;

	public float RevealStampDuration;

	public float RevealStartScale;

	public float RevealPopScale;

	public float RevealSettleScale;

	public float RevealFinalScale;

	private Sequence _revealSequence;

	private bool _awaitingStageContinue;

	private bool _stageContinue;

	private static List<ItemToUnlock> BuildRevealItems(List<ItemToUnlock> itemsToUnlock)
	{
		return null;
	}

	private static void AddRevealItem(List<ItemToUnlock> revealItems, HashSet<(ItemToUnlock.UnlockType Type, int ItemId)> revealedItems, ItemToUnlock.UnlockType type, int itemId)
	{
	}

	public void RevealUnlockPanel(List<ItemToUnlock> itemsToUnlock, List<WeaponProficiencyGain> proficiencyGains = null)
	{
	}

	public void HideUnlockPanel()
	{
	}

	public bool TryHandleStageContinue()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CRevealPanelCoroutine_003Ed__32))]
	private IEnumerator RevealPanelCoroutine(List<ItemToUnlock> itemsToUnlock, List<WeaponProficiencyGain> proficiencyGains)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForStageContinue_003Ed__33))]
	private IEnumerator WaitForStageContinue()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayProficiencyReveal_003Ed__34))]
	private IEnumerator PlayProficiencyReveal(List<WeaponProficiencyGain> proficiencyGains)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRunFillAndCountDown_003Ed__35))]
	private IEnumerator RunFillAndCountDown(ProficiencyEndGameComponent component, WeaponProficiencyGain gain, WeaponProficiencyConfig config, Action onComplete)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayUnlockItemReveal_003Ed__36))]
	private IEnumerator PlayUnlockItemReveal(List<ItemToUnlock> revealItems)
	{
		return null;
	}

	private void HideAllUnlockReveals()
	{
	}

	private void HideAllProficiencyComponents()
	{
	}

	private void ActiveNextButton()
	{
	}

	private void HideNextButton()
	{
	}

	private Sequence CreateItemRevealSequence(Transform itemTransform)
	{
		return null;
	}

	private Sequence CreateProficiencyRevealSequence(Transform itemTransform)
	{
		return null;
	}

	private Sequence CreateRevealSequence(Transform itemTransform, float popInDuration, float stampDuration)
	{
		return null;
	}

	private void KillRevealSequence()
	{
	}

	private void OnDisable()
	{
	}
}
