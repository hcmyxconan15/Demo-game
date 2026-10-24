using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyOnMapController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRelocateSpreadCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyOnMapController _003C_003E4__this;

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
		public _003CRelocateSpreadCoroutine_003Ed__35(int _003C_003E1__state)
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
	private sealed class _003CSpawnEnemiesByConfig_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string setupName;

		public EnemyStepConfig config;

		public EnemyOnMapController _003C_003E4__this;

		public bool needForNodeQuest;

		public bool forceSpam;

		public bool selectSimpleUpgradeDrop;

		private bool _003CinitialSpam_003E5__2;

		private int _003CquestSpawnGeneration_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CSpawnEnemiesByConfig_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CSpawnEnemiesByStepIndex_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int configurationStep;

		public EnemyOnMapController _003C_003E4__this;

		public EnemyStepConfig config;

		private bool _003CinitialSpam_003E5__2;

		private int _003CloopCount_003E5__3;

		private int _003CconfigurationStepForTheEnemies_003E5__4;

		private int _003Ci_003E5__5;

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
		public _003CSpawnEnemiesByStepIndex_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CWaitSpawnDelay_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public bool needForNodeQuest;

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
		public _003CWaitSpawnDelay_003Ed__39(int _003C_003E1__state)
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

	public bool StopEnemiesSpam;

	public bool SpecialEnemyOnMap;

	public int MapEnemyLevel;

	public int MaxEnemiesAliveOnMap;

	[Header("Enemies manager")]
	public int CurrentConfigurationStep;

	public float EnemyPhaseTimeInterval;

	public float NextEnemyPhaseTime;

	public EnemySetupToSelect StageEnemyConfiguration;

	public EnemySetupToSelect EndgameEnemyConfiguration;

	[Header("Map selection enemies manager")]
	public List<EnemyStepConfig> EnemyStepConfigs;

	public GameControllers GameControllers;

	public EnemiesController EnemiesController;

	public EnemySetupToSelect NormalEliteEnemy;

	public EnemySetupToSelect EliteEnemy;

	public EnemySetupToSelect BossEnemy;

	public EnemySetupToSelect Mercenary;

	public EnemySetupToSelect OptionalHuntEnemy;

	[Header("Performance")]
	[Tooltip("Spread NavMesh relocation over several frames instead of one spike (recommended when many enemies can be far).")]
	public bool RelocateDistantEnemiesUseSpreadRoutine;

	[Tooltip("Seconds between relocation passes.")]
	public float RelocateDistantEnemiesInterval;

	private float _relocateTime;

	private Coroutine _relocateSpreadCoroutine;

	private int _questSpawnGeneration;

	private void Awake()
	{
	}

	private void ApplyQuestEnemyProfile()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void IncreaseEnemiesSpamOnMap(int increase)
	{
	}

	public void EndCurrentQuestObjective()
	{
	}

	public void AddNormalEliteEnemyStep(int stepLevel, bool questEnemy)
	{
	}

	public void AddEliteEnemyStep(int stepLevel, bool questEnemy)
	{
	}

	public void AddMercenaryStep(int stepLevel, bool questEnemy)
	{
	}

	public void AddOptionalHuntStep(int optionalHuntLevelStatus)
	{
	}

	public void AddGoldenBugStep()
	{
	}

	public void AddFinalBossStep()
	{
	}

	private void ManageEnemiesPhases()
	{
	}

	[IteratorStateMachine(typeof(_003CRelocateSpreadCoroutine_003Ed__35))]
	private IEnumerator RelocateSpreadCoroutine()
	{
		return null;
	}

	private void StartEnemiesNewPhase()
	{
	}

	[IteratorStateMachine(typeof(_003CSpawnEnemiesByStepIndex_003Ed__37))]
	private IEnumerator SpawnEnemiesByStepIndex(EnemyStepConfig config, int configurationStep)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CSpawnEnemiesByConfig_003Ed__38))]
	private IEnumerator SpawnEnemiesByConfig(EnemyStepConfig config, string setupName, bool forceSpam, bool needForNodeQuest, bool selectSimpleUpgradeDrop)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitSpawnDelay_003Ed__39))]
	private static IEnumerator WaitSpawnDelay(float seconds, bool needForNodeQuest)
	{
		return null;
	}

	public int RelocateDistantEnemiesOutsidePlayerView()
	{
		return 0;
	}
}
