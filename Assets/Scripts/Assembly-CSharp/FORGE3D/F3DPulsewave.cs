using UnityEngine;

namespace FORGE3D
{
	public class F3DPulsewave : MonoBehaviour
	{
		public float FadeOutDelay;

		public float FadeOutTime;

		public float ScaleTime;

		public Vector3 ScaleSize;

		public bool DebugLoop;

		private new Transform transform;

		private MeshRenderer meshRenderer;

		private int timerID;

		private bool isFadeOut;

		private bool isEnabled;

		private Color defaultColor;

		private Color color;

		private int tintColorRef;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnSpawned()
		{
		}

		private void OnDespawned()
		{
		}

		private void OnFadeOut()
		{
		}

		private void Update()
		{
		}
	}
}
