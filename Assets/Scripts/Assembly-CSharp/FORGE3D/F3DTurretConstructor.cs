using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class F3DTurretConstructor : MonoBehaviour
	{
		public GameObject[] Breeches;

		public GameObject[] Barrels;

		public GameObject Base;

		public GameObject Swivel;

		public GameObject Mount;

		public GameObject Head;

		public int turretIndex;

		public bool needUpdateListOfTemplates;

		public int GetSelectedType()
		{
			return 0;
		}

		public void ChangeTurretIndex(int index, TurretStructure struc)
		{
		}

		private bool CheckForName(string[] names, string name)
		{
			return false;
		}

		public void UpdateFullTurret(TurretStructure struc)
		{
		}

		public void UnlinkGameObject()
		{
		}

		private void InstallLods()
		{
		}

		private void InstallTurretController()
		{
		}

		private GameObject FindGameObject(string[] names, GameObject parent)
		{
			return null;
		}

		public void UpdateTurret(TurretStructure curStructure)
		{
		}

		private void UpdateBreeches(List<GameObject> breeches, List<string> socketNames, List<GameObject> barrels, List<string> barrelSocketNames)
		{
		}

		private GameObject UpdateBarrel(GameObject barrelGO, GameObject parentGO, string socket)
		{
			return null;
		}

		private void UpdateHead(GameObject headGO, string prefix)
		{
		}

		private void UpdateMount(GameObject mountGO, string prefix)
		{
		}

		private void UpdateSwivel(GameObject swivelGO, string prefix)
		{
		}

		private void UpdateBase(GameObject baseGO)
		{
		}
	}
}
