using UnityEngine;

namespace ShatterStone
{
	public class DemoClickInteraction : MonoBehaviour
	{
		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private float maxDistance;

		[Tooltip("Tag used to identify ore nodes in the scene.")]
		[SerializeField]
		private string oreNodeTag;

		[SerializeField]
		private string orePickupTag;

		private void Update()
		{
		}
	}
}
