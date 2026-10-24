using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class TurretStructure
	{
		public bool NeedLOD;

		public string Name;

		public GameObject Base;

		public GameObject Swivel;

		public string SwivelPrefix;

		public GameObject Head;

		public string HeadPrefix;

		public GameObject Mount;

		public string MountPrefix;

		public GameObject Breech;

		public string BarrelPrefix;

		public List<string> WeaponSlotsNames;

		public List<GameObject> WeaponSlots;

		public List<GameObject> WeaponBreeches;

		public List<string> WeaponBarrelSockets;

		public List<GameObject> WeaponBarrels;

		public bool HasTurretScript;
	}
}
