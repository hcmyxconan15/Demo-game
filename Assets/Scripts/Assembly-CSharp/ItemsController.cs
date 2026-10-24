using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
	private sealed class CollectorLootClaim
	{
		public object Claimer;

		public Vector3 Center;

		public float RadiusSqr;
	}

	[CompilerGenerated]
	private sealed class _003CDropItemsAndCoins_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnemyBase enemyBase;

		public ItemsController _003C_003E4__this;

		public Transform transformPosition;

		public int quantityDrop;

		private int _003Ci_003E5__2;

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
		public _003CDropItemsAndCoins_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CDropItemsAndCoinsFromBox_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float minRadiusToDrop;

		public float maxRadiusToDrop;

		public int quantityDropXp;

		public int quantityDropSmallLife;

		public ItemsController _003C_003E4__this;

		public Transform transformPosition;

		public int quantityDropCoins;

		public int quantityDropBox;

		public DropBox.BoxType boxType;

		private float _003CminRadius_003E5__2;

		private float _003CmaxRadius_003E5__3;

		private int _003CxpOrLifeCount_003E5__4;

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
		public _003CDropItemsAndCoinsFromBox_003Ed__51(int _003C_003E1__state)
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

	public Transform ItemsParent;

	public int ChestCollected;

	[Header("Run meta counters (unlock stats)")]
	public int DashesThisRun;

	public int OverloadsActivatedThisRun;

	public int ShopsVisitedThisRun;

	[Header("Coins")]
	[SerializeField]
	private Coin CoinPrefab;

	[SerializeField]
	private Coin CoinType2Prefab;

	public List<Coin> Coins;

	[Header("Xp")]
	public int ForceInitialXpDrop;

	[SerializeField]
	private XpItem XpPrefab;

	[SerializeField]
	private XpItem XpPrefabGreen;

	[SerializeField]
	private XpItem XpPrefabRed;

	public List<XpItem> XpItemsInMap0;

	public List<XpItem> XpItemsInMap1;

	public List<XpItem> XpItemsInMap2;

	[Header("Health")]
	public float LifeCooldown;

	[SerializeField]
	private IncreaseLife IncreaseLifePrefab;

	public List<IncreaseLife> LivesOnMap;

	[SerializeField]
	private IncreaseLife SmallIncreaseLifePrefab;

	public List<IncreaseLife> SmallLivesOnMap;

	[Header("Box")]
	[SerializeField]
	private DropBox UpgradeBox;

	[SerializeField]
	private DropBox UpgradeBoxByPay;

	[SerializeField]
	private DropBox LevelUpBox;

	[SerializeField]
	private DropBox SelectSimpleUpgrade;

	[SerializeField]
	private DropBox EvolveWeaponBox;

	public List<DropBox> DropBoxes;

	[Header("FullMagnet")]
	public float FullMagnetCooldown;

	public FullMapMagnet FullMapMagnet;

	public List<FullMapMagnet> FullMapMagnets;

	[Header("Increase Speed")]
	public float IncreaseSpeedCooldown;

	public List<IncreaseSpeed> IncreaseSpeed;

	[Header("Increase Damage")]
	public float IncreaseDamageCooldown;

	public List<IncreaseDamageItem> IncreaseDamageItems;

	[Header("SpecialItems")]
	public CollectionPointHitPoints CollectionPointHitPointsPrefab;

	public List<CollectionPointHitPoints> CollectionPointHitPoints;

	private readonly List<CollectorLootClaim> _collectorLootClaims;

	private int _randomValueCoins;

	private int _randomValueXp;

	private float _dropChance;

	private float _forceInitialXpDrop;

	private float _fullMagnetCooldown;

	private float _increaseSpeedCooldown;

	private float _lifeCooldownCooldown;

	private float _increaseDamageCooldown;

	private int _randomValue;

	private Vector3 _randomPosition;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void NormalEnemyDrop(int enemyLevel, int quantity, Transform transformPosition)
	{
	}

	public void MultipleDrop(int quantityDropXp, int quantityDropCoins, int quantityDropBox, DropBox.BoxType boxType, Transform transformPosition, float minRadiusToDrop, float maxRadiusToDrop, int quantityDropSmallLife = 0)
	{
	}

	public void MultipleEnemyDrop(EnemyBase enemyBase, int quantityDrop, Transform transformPosition)
	{
	}

	[IteratorStateMachine(typeof(_003CDropItemsAndCoins_003Ed__50))]
	private IEnumerator DropItemsAndCoins(int quantityDrop, EnemyBase enemyBase, Transform transformPosition)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDropItemsAndCoinsFromBox_003Ed__51))]
	private IEnumerator DropItemsAndCoinsFromBox(int quantityDropXp, int quantityDropCoins, int quantityDropBox, DropBox.BoxType boxType, Transform transformPosition, float minRadiusToDrop, float maxRadiusToDrop, int quantityDropSmallLife)
	{
		return null;
	}

	public void DropItemBox(Transform transformPosition, DropBox.BoxType boxType)
	{
	}

	public void InstantiateCoin(Transform position, int quantity, int coinType, float radiusFroTheDrop)
	{
	}

	public void InstantiateXpStars(Transform position, int quantity, float radiusFroTheDrop)
	{
	}

	public void InstantiateXpStarsGreen(Transform position, int quantity, float radiusFroTheDrop)
	{
	}

	public void InstantiateXpStarsRed(Transform position, int quantity, float radiusFroTheDrop)
	{
	}

	public void InstantiateItemBox(Transform position)
	{
	}

	public void InstantiateItemBox(Transform initialPosition, Vector3 endPosition, DropBox.BoxType boxTypeToDrop)
	{
	}

	private void AnimateDrop(Transform itemToAnimate, Vector3 startPosition, Vector3 endPosition)
	{
	}

	public void InstantiateItemBoxRandomOnMap(DropBox.BoxType boxTypeToDrop)
	{
	}

	private DropBox GetDropBoxPrefab(DropBox.BoxType boxType)
	{
		return null;
	}

	public void InstantiateLifeRecoversRandomOnMap()
	{
	}

	private void ManageItemInstance(Transform transformPosition)
	{
	}

	public void InstantiateFullMapMagnet(Transform position)
	{
	}

	public void InstantiateIncreaseSpeed(Transform position)
	{
	}

	public void InstantiateLife(Transform transformPosition)
	{
	}

	public void InstantiateSmallLife(Transform transformPosition, float radiusForTheDrop)
	{
	}

	public void InstantiateDoubleDamage(Transform transformPosition)
	{
	}

	public void ForceAllXpGoToPlayer()
	{
	}

	public void ForceCoinsGoToPlayer()
	{
	}

	public void ForceLivesGoToPlayer()
	{
	}

	private static void ForceLivesListGoToPlayer(List<IncreaseLife> lives, Transform playerTransform)
	{
	}

	public void ForceNearbyXpAndCoinsToPlayer(Vector3 center, float radius)
	{
	}

	public void ForceNearbyXpAndCoinsToTransform(Vector3 center, float radius, Transform magnetTarget)
	{
	}

	public void PullAndAbsorbNearbyLoot(object claimer, Vector3 detectCenter, float pullRadius, Vector3 magnetTarget, float pullSpeed, float absorbRadius, Vector3 playerPosition, float playerAvoidRadius, out int xpAbsorbed, out int coinsAbsorbed, out int itemsAbsorbed, out bool anyInRange)
	{
		xpAbsorbed = default;
		coinsAbsorbed = default;
		itemsAbsorbed = default;
		anyInRange = default;
	}

	private void PullAbsorbXpList(List<XpItem> xpItems, object claimer, Vector3 detectCenter, Vector3 magnetTarget, float pullSqr, float absorbSqr, Vector3 playerPosition, float playerAvoidSqr, float step, ref int xpAbsorbed, ref int itemsAbsorbed, ref bool anyInRange)
	{
	}

	public bool TryClaimNearestXpOrCoin(object claimer, Vector3 center, float searchRadius, float preferMinRadius, float claimRadius, out Vector3 nearestPosition)
	{
		nearestPosition = default;
		return false;
	}

	private void ClaimLootForCollector(object claimer, Vector3 nearestPosition, float claimRadius)
	{
	}

	public void ReleaseCollectorClaim(object claimer)
	{
	}

	public bool TryGetNearestXpOrCoin(Vector3 center, float radius, out Vector3 nearestPosition)
	{
		nearestPosition = default;
		return false;
	}

	public bool TryGetNearestXpOrCoin(Vector3 center, float radius, object claimer, out Vector3 nearestPosition)
	{
		nearestPosition = default;
		return false;
	}

	public bool TryGetNearestXpOrCoin(Vector3 center, float maxRadius, float minRadius, object claimer, out Vector3 nearestPosition)
	{
		nearestPosition = default;
		return false;
	}

	public bool HasXpOrCoinInArea(Vector3 center, float radius)
	{
		return false;
	}

	public bool HasXpOrCoinInArea(Vector3 center, float radius, object claimer)
	{
		return false;
	}

	public bool HasXpOrCoinInArea(Vector3 center, float radius, object claimer, Vector3 playerPosition, float playerAvoidRadius)
	{
		return false;
	}

	private bool HasXpInList(List<XpItem> xpItems, Vector3 center, float radiusSqr, object claimer, Vector3 playerPosition, float playerAvoidSqr)
	{
		return false;
	}

	private bool TryNearestFromXpList(List<XpItem> xpItems, Vector3 center, float maxSqr, float minSqr, object claimer, ref float bestSqr, ref Vector3 nearestPosition)
	{
		return false;
	}

	private bool IsLootClaimedByOther(Vector3 position, object claimer)
	{
		return false;
	}

	private static void ForceNearbyXpList(List<XpItem> xpItems, Vector3 center, float radiusSqr, Transform playerTransform)
	{
	}

	private static float HorizontalSqrDistance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	public bool WeaponEvolutionOnMap()
	{
		return false;
	}
}
