using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class F3DTurretScriptable : ScriptableObject
	{
		public List<TurretStructure> Turrets;

		public List<GameObject> Bases;

		public List<GameObject> Swivels;

		public string SwivelPrefix;

		public List<GameObject> Heads;

		public string HeadPrefix;

		public List<GameObject> Mounts;

		public string MountPrefix;

		public List<GameObject> Breeches;

		public string BarrelPrefix;

		public List<GameObject> Barrels;

		public int SelectedTurret;

		public string WeaponSocket;
	}
}
