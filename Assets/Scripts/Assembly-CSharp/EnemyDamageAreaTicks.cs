using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyDamageAreaTicks : EnemyBulletBase
{
	[CompilerGenerated]
	private sealed class _003CManageLifeTime_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyDamageAreaTicks _003C_003E4__this;

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
		public _003CManageLifeTime_003Ed__29(int _003C_003E1__state)
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

	private static readonly Collider[] SharedColliderBuffer;

	public int ImpactDamage;

	[FormerlySerializedAs("Damage")]
	public int TickDamage;

	public float DelayDamage;

	public int DamageTicks;

	public float DamageTimeActive;

	public float DamageTimeBetweenTicks;

	public float DamageRadius;

	public bool DamageEnemies;

	public LayerMask RayCasterLayer;

	public ParticleSystem ParticleSystem;

	public float LifeTime;

	[Header("Contact push")]
	public bool PushPlayer;

	public float PushDistance;

	public float PushDuration;

	public float ControlDisableTime;

	public float RotationSpeedDuringPush;

	public bool RandomizeRotationDirection;

	public MechPlayerController MechPlayerController;

	public AudioSource AudioSource;

	[Header("Sound distance")]
	[Tooltip("At or below this distance from the player, impact sound uses full volume (before random jitter).")]
	public float SoundFullVolumeDistance;

	[Tooltip("At or beyond this distance, impact sound volume reaches zero. Between full and silent distance, volume falls off linearly.")]
	public float SoundSilentDistance;

	private int _damageTick;

	private int _sourceEnemyId;

	private int _impactOutgoing;

	private int _tickOutgoing;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	internal override void DeactivateBullet()
	{
	}

	[IteratorStateMachine(typeof(_003CManageLifeTime_003Ed__29))]
	private IEnumerator ManageLifeTime()
	{
		return null;
	}

	private void CacheOutgoingDamage()
	{
	}

	private int ScaleOutgoingDamage(int damage)
	{
		return 0;
	}

	private void ApplyExpandDamage(int damage)
	{
	}

	private void ApplyPlayerContactPush()
	{
	}

	private void FixedSoundOnPosition(int id)
	{
	}

	private float GetDistanceToPlayerVolumeMultiplier()
	{
		return 0f;
	}
}
