using System;
using System.Collections.Generic;
using UnityEngine;

namespace FORGE3D
{
	[Serializable]
	public class F3DPoolManagerDB : ScriptableObject
	{
		public List<string> poolsName;

		public List<F3DPoolContainer> pools;

		public string namer;
	}
}
