using UnityEngine;

namespace Missiles
{
	[RequireComponent(typeof(Collider))]
	public abstract class BaseMissile : MonoBehaviour
	{
		public bool CombineEffect;

		public short ExplosionEffectId;

		public short ExplosionEffectIdOnGround;

		public bool ExplodeOnImpact;

		public DamageBase DamageBase;

		public bool DisableTarget;

		[Tooltip("If damage OnTriggerEnter.")]
		public bool DamageOnTrigger;

		[Tooltip("If damage OnCollisionEnter.")]
		public bool DamageOnCollision;

		[Tooltip("If using gravity.")]
		public bool useGravity;

		[Tooltip("Explode if the target is close less or equal than distanceToExplode.")]
		public float distanceToExplode;

		[Tooltip("Target the first enemy in scene, target a random enemy in scene, target the nearest enemy in scene between minDistance and maxDistance.")]
		public TargetType typeOfTarget;

		[Tooltip("If type of target = target nearest enemy the target must be between the maximum and minimum distances for the projectile to consider it a target.")]
		public float minDistance;

		[Tooltip("If type of target = target nearest enemy the target must be between the maximum and minimum distances for the projectile to consider it a target.")]
		public float maxDistance;

		[Range(1f, 30f)]
		[Tooltip("The projectile  life time, if reach 0 destroy it.")]
		public float lifeTime;

		[Range(0f, 15f)]
		[Tooltip("The time this projectile  wait to mark the targett,if exit a target.")]
		public float timeToSetTarget;

		[Range(0f, 2f)]
		[Tooltip("After a failed retarget search, wait this long before searching again.")]
		public float retargetDelay;

		[Range(0f, 200f)]
		[Tooltip("Minimum horizontal search radius after losing a target.")]
		public float retargetSearchRadius;

		[Range(0f, 400f)]
		[Tooltip("This is the projectile start speed after activate projectile.")]
		public float startSpeed;

		[Range(0f, 400f)]
		[Tooltip("This is the maximum speed the projectile can reach.")]
		public float MaxSpeed;

		[Tooltip("This is the acceleration speed.")]
		public float accelerationSpeed;

		[Range(10f, 1000f)]
		[Tooltip("This is the turn speed,the larger the number, the faster it will rotate.")]
		public float turnSpeed;

		[Tooltip("This is the projectile current speed.")]
		public float currentSpeed;

		[Tooltip("This is the projectile accurancy.")]
		[Range(0f, 10f)]
		public float missileStability;

		[Tooltip("Drag the sound of the missile here (this is the active sound of the missile, the explosion sounds is recommended to put in explosion prefabs).")]
		public AudioSource missileEngineSound;

		[Tooltip("The current selected target.")]
		public GameObject SelectedTarget;

		public ManageTrails ManageTrails;

		internal Vector3 direction;

		internal bool addTarget;

		internal float time;

		internal float offSet;

		internal bool activate;

		internal Vector3 diference;

		public Vector3 _targetOffset;

		private EnemyBase _selectedEnemy;

		private float _nextRetargetTime;

		private bool _usePositionRetarget;

		private bool _hasRetargeted;

		private Rigidbody _rigidbody;

		private StatsBase _statsBase;

		protected void ResetMissileTargetState()
		{
		}

		protected void PrepareMissilePhysics()
		{
		}

		private bool IsSelectedEnemyTargetValid()
		{
			return false;
		}

		private bool HasValidPursuitTarget()
		{
			return false;
		}

		private void ClearSelectedEnemyTarget()
		{
		}

		private void SetSelectedEnemyTarget(EnemyBase enemy)
		{
		}

		public virtual void TargetEnemy()
		{
		}

		public void TargetNearestEnemy(float minDistanceValue, float maxDistanceValue)
		{
		}

		public virtual void TargetRandomEnemy()
		{
		}

		public void TargetPlayer()
		{
		}

		public virtual void PersuitTarget3D()
		{
		}

		public virtual void PursuitTargetZx()
		{
		}

		public virtual void Accelerate(float acceleration)
		{
		}

		public virtual void ExplodeByDistance(float distanceToExplodeValue)
		{
		}

		public virtual void GroundLimit()
		{
		}

		public virtual void EndLifeByTime()
		{
		}

		public virtual void MissileContact()
		{
		}

		public virtual void MissileContactGround()
		{
		}

		public virtual void UseGravity(bool useGravityValue)
		{
		}

		public virtual void RemoveForces(bool removeForces)
		{
		}

		public virtual void OnTriggerEnter(Collider other)
		{
		}

		public virtual void OnCollisionEnter(Collision other)
		{
		}
	}
}
