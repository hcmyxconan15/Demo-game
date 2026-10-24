using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ShatterStone;
using UnityEngine;
using UnityEngine.Serialization;

public class OreNodeSmallLife : OreNode
{
	[CompilerGenerated]
	private sealed class _003CDelayDestroy_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelayDestroy_003Ed__12(int _003C_003E1__state)
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

	[Range(0f, 15f)]
	public float MinRadiusToDrop;

	[FormerlySerializedAs("DropRadius")]
	[Range(0f, 15f)]
	public float MaxRadiusToDrop;

	public float DropHeightOffset;

	[Range(0f, 100f)]
	public int CoinDropChance;

	public float CoinDropHeightOffset;

	public float ShatterForce;

	public float ShatterRadius;

	public float ShatterUpwardsModifier;

	private Transform _dropAnchor;

	protected override Vector3 CalculateRandomDropPosition(OreNodeBounds bounds)
	{
		return default;
	}

	protected override void SpawnDrop(Vector3 dropPos)
	{
	}

	protected override void OnPiecesInstantiated(GameObject shatteredPieces)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayDestroy_003Ed__12))]
	protected override IEnumerator DelayDestroy()
	{
		return null;
	}
}
