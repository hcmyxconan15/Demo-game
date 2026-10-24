using UnityEngine;

namespace TopDownShooter
{
	public class MoveObject : MonoBehaviour
	{
		[Tooltip("Direction and speed to move the gameObject")]
		public Vector3[] MovementDirection;

		private int _randomPosition;

		private int _lastRandomPosition;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
