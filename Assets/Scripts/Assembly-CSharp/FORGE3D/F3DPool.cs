using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	public class F3DPool : MonoBehaviour
	{
		[HideInInspector]
		public string poolName;

		[HideInInspector]
		public Transform[] templates;

		[HideInInspector]
		public Transform[] templatesParent;

		[HideInInspector]
		public int[] poolLength;

		[HideInInspector]
		public int[] poolLengthCurrent;

		[HideInInspector]
		public int[] poolLengthMax;

		[HideInInspector]
		public string broadcastSpawnName;

		[HideInInspector]
		public string broadcastDespawnName;

		[HideInInspector]
		public bool delayedSpawnInInstall;

		[HideInInspector]
		public int objectsPerUpdate;

		[HideInInspector]
		public bool needBroadcasting;

		[HideInInspector]
		public bool optimizeSpawn;

		[HideInInspector]
		public int targetFPS;

		[HideInInspector]
		public bool pooling;

		[HideInInspector]
		public bool needDebugging;

		[HideInInspector]
		public bool needSort;

		[HideInInspector]
		public bool needParenting;

		private float normalValue;

		private Dictionary<Transform, List<Transform>> readyObjects;

		private Dictionary<Transform, List<Transform>> occupiedObjects;

		private bool installing;

		public int GetTemplatesCount()
		{
			return 0;
		}

		private bool CheckForExistingTemplate(Transform obj)
		{
			return false;
		}

		public bool Despawn(Transform obj)
		{
			return false;
		}

		public bool Despawn(Transform obj, Transform template)
		{
			return false;
		}

		public int GetTemplatePosition(Transform obj)
		{
			return 0;
		}

		public Transform SpawnAudio(Transform obj, AudioClip clip, Vector3 pos, Transform par)
		{
			return null;
		}

		public Transform Spawn(Transform obj, Transform par, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion))
		{
			return null;
		}

		public Transform Spawn(Transform obj, Vector3 pos, Quaternion rot, Transform par)
		{
			return null;
		}

		public Transform Spawn(Transform obj, Vector3 pos = default(Vector3), Quaternion rot = default(Quaternion))
		{
			return null;
		}

		public void SetTemplates(Transform[] newArray)
		{
		}

		public void SetLength(int[] newPoolLenght)
		{
		}

		public void SetLengthMax(int[] newPoolLengthMax)
		{
		}

		private void CalculateObjectsPerUpdate()
		{
		}

		private void DelayedSpawnInInstall()
		{
		}

		private void NonDelayedSpawnInInstall()
		{
		}

		private void Update()
		{
		}

		private Transform InstantiateItem(Transform temp, Transform par, int templatePosition)
		{
			return null;
		}

		public void Install()
		{
		}
	}
}
