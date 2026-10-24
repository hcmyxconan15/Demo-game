using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class BossAttackController : EnemyRobotAttackController
{
	public enum BossState
	{
		Neutral = 0,
		Movement = 1,
		FrontTurretAttack = 2,
		Frenezzy = 3,
		FrontalChargeAttack = 4,
		FloorSweep = 5
	}

	[CompilerGenerated]
	private sealed class _003CAlignChargeBaseAndBodyTowardsPlayer_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

		public float rotationSpeed;

		private Transform _003CmovementRoot_003E5__2;

		private Transform _003Ctarget_003E5__3;

		private Quaternion _003CtargetRotation_003E5__4;

		private float _003CstepPerSecond_003E5__5;

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
		public _003CAlignChargeBaseAndBodyTowardsPlayer_003Ed__103(int _003C_003E1__state)
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
	private sealed class _003CBulletsAttacking_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CBulletsAttacking_003Ed__74(int _003C_003E1__state)
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
	private sealed class _003CFloorSweepAttacking_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

		private BasicTurret _003Cturret0_003E5__2;

		private BasicTurret _003Cturret1_003E5__3;

		private int _003CbulletRounds_003E5__4;

		private float _003CrotationTime_003E5__5;

		private int _003CmuzzleIndex0_003E5__6;

		private int _003CmuzzleIndex1_003E5__7;

		private int _003Ci_003E5__8;

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
		public _003CFloorSweepAttacking_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CFrenezzyAttacking_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CFrenezzyAttacking_003Ed__75(int _003C_003E1__state)
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
	private sealed class _003CFrontalChargeAttacking_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

		private Transform _003CmovementRoot_003E5__2;

		private Vector3 _003CchargeDirection_003E5__3;

		private float _003CdistanceRemaining_003E5__4;

		private float _003CchargeSpeed_003E5__5;

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
		public _003CFrontalChargeAttacking_003Ed__101(int _003C_003E1__state)
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
	private sealed class _003CRotateFrenezzyTowardsPlayer_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

		private Transform _003CattackTransform_003E5__2;

		private Quaternion _003CtargetRotation_003E5__3;

		private float _003CstepPerSecond_003E5__4;

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
		public _003CRotateFrenezzyTowardsPlayer_003Ed__100(int _003C_003E1__state)
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
	private sealed class _003CRotateTowardsPlayer_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

		public float rotationSpeed;

		private Transform _003CattackTransform_003E5__2;

		private Quaternion _003CtargetRotation_003E5__3;

		private float _003CstepPerSecond_003E5__4;

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
		public _003CRotateTowardsPlayer_003Ed__102(int _003C_003E1__state)
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
	private sealed class _003CSkyAttackCoroutine_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CSkyAttackCoroutine_003Ed__87(int _003C_003E1__state)
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
	private sealed class _003CStart_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CStart_003Ed__67(int _003C_003E1__state)
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
	private sealed class _003CUpperTurretAttacking_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CUpperTurretAttacking_003Ed__85(int _003C_003E1__state)
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
	private sealed class _003CWaitForCurrentVolley_003Ed__99 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BossAttackController _003C_003E4__this;

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
		public _003CWaitForCurrentVolley_003Ed__99(int _003C_003E1__state)
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

	public BossState CurrentState;

	public Transform BulletsAlertTransform;

	public float CooldownFrontTurret;

	[Header("Upper turret")]
	public float CooldownUpperTurret;

	public int DistanceToAttackUpper;

	public int AttackTelegrafTimeUpper;

	public EnemyUpperTurretController UpperTurretController;

	public DisablePartsOnDead DisablePartsOnDead;

	[SerializeField]
	private BarsAlertComponent BarsAlertComponent;

	[Header("Sky attack")]
	public int LifePercentTrigger;

	public int BulletId;

	public float CooldownSkyAttack;

	public float FireRateForSkyAttack;

	public float FireAttackQuantity;

	[Header("Invoke allied attack")]
	public bool CanInvokeAlies;

	public int LifePercentTriggerInvokeAllied;

	public float InvokeAlliedCooldown;

	public int AlliedNumberPerCall;

	public List<int> AlliedToInvoke;

	[Header("Frenezzy attack")]
	public bool UseFrenezzyAttack;

	public int FrenezzyLifePercentTrigger;

	public int FrontAttacksBeforeFrenezzy;

	public float FrenezzyBurstDelay;

	public float FrenezzyRotationSpeed;

	[Header("Frontal charge attack")]
	public bool UseFrontalChargeAttack;

	public float ChargeCooldown;

	public float ChargeTriggerDistanceMin;

	public float ChargeTriggerDistanceMax;

	public float ChargeDistance;

	public float ChargeSpeed;

	public float ChargeRotationSpeed;

	public float ChargeCollisionCheckDistance;

	public float ChargePathCheckHeight;

	public ParticleSystem ChargeParticle;

	[Header("Floor sweep attack")]
	public bool UseFloorSweepAttack;

	public float CooldownFloorSweep;

	public int DistanceToAttackFloorSweep;

	public float AttackTelegrafTimeFloorSweep;

	public float FloorSweepTargetAngleX;

	private float _cooldownUpperTurret;

	private float _cooldownFrontTurret;

	private float _cooldownSkyAttack;

	private float _chargeCooldown;

	private float _cooldownFloorSweep;

	private float _fireAttackQuantity;

	private float _invokeAlliedCooldown;

	private int _frontAttacksCount;

	private bool _activeSkyAttack;

	private bool _frontTurretAttackActive;

	private bool _frenezzyAttackActive;

	private bool _chargeAttackActive;

	private bool _chargingForward;

	private bool _upperTurretAttackActive;

	private bool _skyAttackActive;

	private bool _floorSweepAttackActive;

	private Unity.Mathematics.Random rng;

	private WaitForSeconds _waitUpperTelegraf;

	private WaitForSeconds _waitSkyFireRate;

	private WaitForSeconds _waitFloorSweepTelegraf;

	private WaitForSeconds _waitFloorSweepShot;

	private float _distanceToAttackUpperSqr;

	private float _distanceToAttackFloorSweepSqr;

	private static readonly int Shoot;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__67))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	private void DetachPartsOnDead()
	{
	}

	public void UpperTurretAttack()
	{
	}

	protected override void RotateTurretIfNeeded()
	{
	}

	protected override void Attack()
	{
	}

	protected override void ForceStopAttacking()
	{
	}

	[IteratorStateMachine(typeof(_003CBulletsAttacking_003Ed__74))]
	protected override IEnumerator BulletsAttacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFrenezzyAttacking_003Ed__75))]
	private IEnumerator FrenezzyAttacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFloorSweepAttacking_003Ed__76))]
	private IEnumerator FloorSweepAttacking()
	{
		return null;
	}

	private void FireFloorSweepShot(BasicTurret turret, ref int muzzleIndex)
	{
	}

	private void ResetFloorSweepTurretPitch()
	{
	}

	private bool UpperFirstShot()
	{
		return false;
	}

	private bool UpperUsingTurrets()
	{
		return false;
	}

	private void InvokeAllied()
	{
	}

	private bool LifePercentTriggerReached(int percent)
	{
		return false;
	}

	private bool ShouldUseFrenezzyAttack()
	{
		return false;
	}

	private bool ShouldUseChargeAttack(float sqrDist)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CUpperTurretAttacking_003Ed__85))]
	private IEnumerator UpperTurretAttacking()
	{
		return null;
	}

	private void StartSkyAttack()
	{
	}

	[IteratorStateMachine(typeof(_003CSkyAttackCoroutine_003Ed__87))]
	private IEnumerator SkyAttackCoroutine()
	{
		return null;
	}

	public void ShuffleAndActivate(List<int> allies)
	{
	}

	private bool IsBlockingMainAttackState()
	{
		return false;
	}

	private bool TryStartFrontAttack()
	{
		return false;
	}

	private bool TryStartFrenezzyAttack()
	{
		return false;
	}

	private bool TryStartChargeAttack()
	{
		return false;
	}

	private bool TryStartSkyAttack()
	{
		return false;
	}

	private bool TryStartFloorSweepAttack()
	{
		return false;
	}

	private void ExitAttackState(BossState attackState)
	{
	}

	private void SetState(BossState newState)
	{
	}

	private void RefreshStateFromActiveAttacks()
	{
	}

	private void LaunchFrontTurretsVolley()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForCurrentVolley_003Ed__99))]
	private IEnumerator WaitForCurrentVolley()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRotateFrenezzyTowardsPlayer_003Ed__100))]
	private IEnumerator RotateFrenezzyTowardsPlayer()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFrontalChargeAttacking_003Ed__101))]
	private IEnumerator FrontalChargeAttacking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRotateTowardsPlayer_003Ed__102))]
	private IEnumerator RotateTowardsPlayer(float rotationSpeed)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAlignChargeBaseAndBodyTowardsPlayer_003Ed__103))]
	private IEnumerator AlignChargeBaseAndBodyTowardsPlayer(float rotationSpeed)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private bool ShouldStopChargeByForwardCheck(Transform movementRoot, Vector3 chargeDirection)
	{
		return false;
	}

	private bool IsChargePathClear()
	{
		return false;
	}

	private void ActiveBossCamera(bool active)
	{
	}
}
