using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BunchOfCoins : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDisableParticleByTime_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ParticleSystem particleSystemToDeactivate;

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
		public _003CDisableParticleByTime_003Ed__13(int _003C_003E1__state)
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

	public bool UsingThisBunch;

	[SerializeField]
	private GameObject BunchOfCoinsParent;

	[SerializeField]
	private List<RectTransform> Coins;

	[SerializeField]
	private Vector2[] InitialPos;

	[SerializeField]
	private Quaternion[] InitialRotation;

	public CoinsController CoinsController;

	private void Start()
	{
	}

	public void MoveCoins(Vector3 startPosition, Vector3 endPosition, int value, Vector3 pathDirection, bool alreadyCredited = false)
	{
	}

	private void ResetPosition()
	{
	}

	private void CompleteMovement()
	{
	}

	private void CompleteMovement(int index, int value, bool alreadyCredited)
	{
	}

	private void CoinSound()
	{
	}

	private void PlayParticleOnCoin()
	{
	}

	[IteratorStateMachine(typeof(_003CDisableParticleByTime_003Ed__13))]
	private IEnumerator DisableParticleByTime(ParticleSystem particleSystemToDeactivate)
	{
		return null;
	}
}
