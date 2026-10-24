using System.Collections.Generic;
using UnityEngine;

namespace Hovl
{
	public class HS_Impact_position : MonoBehaviour
	{
		public enum HitSourceMode
		{
			MouseClicks = 0,
			ObjectCollisions = 1,
			Both = 2
		}

		[Header("Main")]
		public Collider targetCollider;

		public HitSourceMode hitSourceMode;

		[Header("Shader settings")]
		[Min(1f)]
		public int maxHits;

		public string shaderPropertyName;

		public float invalidHitTime;

		[Header("Collision filtering")]
		public bool useCollisionTagFilter;

		public string requiredCollisionTag;

		public bool acceptCollisionEnter;

		public bool acceptTriggerEnter;

		private MeshRenderer[] _meshRenderers;

		private readonly List<Vector4> _hitPositions;

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void Update()
		{
		}

		private void TryRegisterMouseHit()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private bool IsCollisionAllowed(Collider other)
		{
			return false;
		}

		private void RegisterHit(Vector3 worldHitPos)
		{
		}

		private void ApplyHitsToMaterials()
		{
		}

		[ContextMenu("Clear Hits")]
		public void ClearHits()
		{
		}

		public void AddHitFromWorldPosition(Vector3 worldPosition)
		{
		}
	}
}
