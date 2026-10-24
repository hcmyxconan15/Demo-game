using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FillItemsRandom : MonoBehaviour
{
	private struct FillEntry
	{
		public Sprite Icon;

		public Sprite SlotSprite;
	}

	[CompilerGenerated]
	private sealed class _003CPrepareScrollBoundsNextFrame_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FillItemsRandom _003C_003E4__this;

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
		public _003CPrepareScrollBoundsNextFrame_003Ed__30(int _003C_003E1__state)
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

	public ItemInfoMain ItemInfoMain;

	public RectTransform Content;

	public ScrollRect ScrollRect;

	public float ScrollDuration;

	public WeaponsDb WeaponsDb;

	public ChipDb ChipDb;

	public OverloadDb OverloadDb;

	public RobotBodyDb RobotBodyDb;

	public RobotBaseDb RobotBaseDb;

	public PilotDb PilotDb;

	public DroneDb DroneDb;

	[Header("Slot images by type")]
	public Sprite WeaponSlotSprite;

	public Sprite EvolutionSlotSprite;

	public Sprite ChipSlotSprite;

	public Sprite OverloadSlotSprite;

	public Sprite BodySlotSprite;

	public Sprite BaseSlotSprite;

	public Sprite PilotSlotSprite;

	public Sprite DroneSlotSprite;

	private float _topAnchoredY;

	private float _bottomAnchoredY;

	private float _scrollTargetY;

	private float _scrollSpeed;

	private bool _isScrolling;

	private bool _boundsReady;

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void BeginScroll(float targetY)
	{
	}

	[ContextMenu("Fill Items Random")]
	public void FillItemsRandoms()
	{
	}

	[IteratorStateMachine(typeof(_003CPrepareScrollBoundsNextFrame_003Ed__30))]
	private IEnumerator PrepareScrollBoundsNextFrame()
	{
		return null;
	}

	private static void FreezeLayout(RectTransform content)
	{
	}

	private void ClearContent()
	{
	}

	private List<FillEntry> CollectEntries()
	{
		return null;
	}

	private static void Shuffle(List<FillEntry> entries)
	{
	}

	private static void ApplyVisibleIcon(ItemInfoMain item, FillEntry entry)
	{
	}
}
