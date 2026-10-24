using UnityEngine;

namespace Hovl
{
	public class HS_CallBackParent : MonoBehaviour
	{
		[SerializeField]
		protected Transform parentObject;

		protected virtual void OnParticleSystemStopped()
		{
		}
	}
}
