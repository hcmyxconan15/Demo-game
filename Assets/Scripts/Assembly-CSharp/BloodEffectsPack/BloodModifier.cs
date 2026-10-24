using System.Collections.Generic;
using UnityEngine;

namespace BloodEffectsPack
{
	public class BloodModifier : MonoBehaviour
	{
		public enum EffectType
		{
			Splash = 0,
			Decal = 1
		}

		public enum RPType
		{
			BuiltIn = 0,
			URP = 1,
			HDRP = 2
		}

		public RPType RP;

		public EffectType effectType;

		public Color color;

		public float colorIntensity;

		public float albedoPower;

		public float ambientColorIntensity;

		[Range(-180f, 180f)]
		public float hueShift;

		public float smoothness;

		public bool useSpecularity;

		public float gravityScale;

		public BloodPreset[] decalPresets;

		public BloodPreset[] splashPresets;

		private List<Material> mats;

		public void Apply()
		{
		}
	}
}
