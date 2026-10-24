using System;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class F3DPoolContainer
	{
		public string poolName;

		public Transform[] templates;

		public int[] poolLength;

		public int[] poolLengthMax;

		public string broadcastSpawnName;

		public string broadcastDespawnName;

		public bool delayedSpawnInInstall;

		public int objectsPerUpdate;

		public bool needBroadcasting;

		public bool optimizeSpawn;

		public int targetFPS;

		public bool pooling;

		public bool needSort;

		public bool needParenting;

		public bool needDebug;
	}
}
