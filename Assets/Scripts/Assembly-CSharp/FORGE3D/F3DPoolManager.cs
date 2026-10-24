using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class F3DPoolManager : MonoBehaviour
	{
		public static F3DPoolManager instance;

		public static Dictionary<string, F3DPool> Pools;

		public string databaseName;

		public int selectedItem;

		public bool[] haveToShowArr;

		private List<F3DPool> curPools;

		private void Awake()
		{
		}

		public F3DPool GetPool(string valueName)
		{
			return null;
		}

		private void InstallManager()
		{
		}

		public int GetPoolsCount()
		{
			return 0;
		}
	}
}
