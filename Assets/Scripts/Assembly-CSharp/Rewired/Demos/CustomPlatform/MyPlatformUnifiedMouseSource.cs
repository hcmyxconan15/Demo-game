using Rewired.Platforms.Custom;
using UnityEngine;

namespace Rewired.Demos.CustomPlatform
{
	public class MyPlatformUnifiedMouseSource : CustomPlatformUnifiedMouseSource
	{
		public override Vector2 mousePosition => default;

		protected override void Update()
		{
		}
	}
}
