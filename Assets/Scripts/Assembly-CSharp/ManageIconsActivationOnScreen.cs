using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ManageIconsActivationOnScreen : MonoBehaviour
{
	private struct PendingPlayerFallback
	{
		public Sprite Icon;

		public bool IsMicrochip;

		public float Duration;

		public float EndScale;
	}

	public static ManageIconsActivationOnScreen Instance;

	[Header("Master toggle")]
	public bool Enabled;

	[Header("Special icons")]
	public Sprite RevivalIcon;

	[Header("Refs")]
	public List<ItemActivation> IconsActivationComponents;

	public ItemActivation ItemActivationPrefab;

	public Camera WorldCamera;

	[Header("Robot fallback motion")]
	[FormerlySerializedAs("WorldOffset")]
	public Vector3 RobotWorldOffset;

	[FormerlySerializedAs("FloatUpDistance")]
	public float RobotFloatUpDistance;

	[FormerlySerializedAs("Duration")]
	public float RobotDuration;

	[FormerlySerializedAs("StartScale")]
	public float RobotStartScale;

	[FormerlySerializedAs("EndScale")]
	public float RobotEndScale;

	[Header("Revival motion")]
	public float RevivalEndScale;

	public float RevivalDuration;

	[Header("Buff slot scale punch")]
	[FormerlySerializedAs("BuffSlotEndScale")]
	public float BuffSlotPunchScale;

	[FormerlySerializedAs("BuffSlotDuration")]
	public float BuffSlotPunchDuration;

	[Header("Player fallback queue")]
	public float MinPlayerFallbackDelay;

	private RectTransform _rectTransform;

	private readonly Queue<PendingPlayerFallback> _playerFallbackQueue;

	private float _nextPlayerFallbackUnscaledTime;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void PlayActivation(Sprite icon, bool isMicrochip, OverloadInstalled overloadInstalled = null)
	{
	}

	public void PlayRevival()
	{
	}

	private bool TryPlayBuffSlotScale(OverloadInstalled overloadInstalled)
	{
		return false;
	}

	private void ProcessPlayerFallbackQueue()
	{
	}

	private bool TryWorldToScreen(Vector3 worldPosition, Camera camera, out Vector2 screenPoint)
	{
		screenPoint = default;
		return false;
	}

	private Transform GetRobotFollowTarget()
	{
		return null;
	}

	private Camera GetWorldCamera()
	{
		return null;
	}

	private ItemActivation AcquireActivation()
	{
		return null;
	}
}
