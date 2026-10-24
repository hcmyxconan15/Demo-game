using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NodeTypeComponent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public enum NodeState
	{
		Locked = 0,
		Unlocked = 1,
		Completed = 2,
		Passed = 3,
		Disable = 4
	}

	public bool Active;

	public int NodeIndex;

	public int NodeLevel;

	public float NodeXPosition;

	public float NodeYPosition;

	public Image NodeImage;

	public Image Selected;

	public Image BackGround;

	public CanvasGroup Border;

	public Image BorderImage;

	public NodeState CurrentNodeState;

	public Node.NodeType NodeType;

	public RectTransform NodeRecTransform;

	public List<NodeTypeComponent> UpNodes;

	public List<NodeTypeComponent> DownNodes;

	public List<Image> LineImages;

	[SerializeField]
	private float lineThickness;

	private float _initialScale;

	private Vector2 _originalAnchoredPosition;

	public Color NormalIconColor;

	public Color ActiveColorLine;

	public Color NormalColorLine;

	public Color SelectedColorLine;

	[Header("Can select colors")]
	public Color CanSelectedColor;

	public Color CantSelectedColor;

	[Header("Animations")]
	[SerializeField]
	private float hoverScaleFactor;

	[SerializeField]
	private float hoverScaleDuration;

	[SerializeField]
	private float idleScaleFactor;

	[SerializeField]
	private float idleScaleDuration;

	[SerializeField]
	private float selectedFillDuration;

	[SerializeField]
	private float introDelayBase;

	[SerializeField]
	private float introDelayPerLevel;

	[SerializeField]
	private float introScaleUpDuration;

	[SerializeField]
	private float introScaleDownDuration;

	[SerializeField]
	private float introOvershootScale;

	private Sequence _introSequence;

	private Sequence _idleTween;

	private Tween _selectedFillTween;

	private Tween _rejectShakeTween;

	private bool _introAnimationPlayed;

	private bool _introFinished;

	private bool _isHovered;

	private bool _enterByMouse;

	private bool _needExitAnimation;

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public void RefreshLineImages()
	{
	}

	private void HideLineImage(int index)
	{
	}

	private void HideAllLineImages()
	{
	}

	private Color GetLineColor(int lineIndex)
	{
		return default;
	}

	private void UpdateLineImage(Image lineImage, Vector3 startWorldPos, Vector3 endWorldPos)
	{
	}

	public void SetupNodeState(NodeState nodeState)
	{
	}

	public void SetNodeType(Node node)
	{
	}

	private void ApplyNodeImageSize(Node.NodeType nodeType)
	{
	}

	public void ChangeNodeState(NodeState nodeState, bool animate = true)
	{
	}

	private void UnlockUpNodes(bool animate)
	{
	}

	private void ApplyNodeState(NodeState nodeState)
	{
	}

	private void SetNodeVisible(bool visible)
	{
	}

	private void ResetPassedVisuals()
	{
	}

	private void ApplyPassedVisuals()
	{
	}

	private void PlayStateAnimation(NodeState nodeState)
	{
	}

	public void PlayIntroAnimation()
	{
	}

	public void CheckLineColors()
	{
	}

	public void ResetNode()
	{
	}

	public void SelectNode()
	{
	}

	public void SelectNodeForLoad()
	{
	}

	private void PlayRejectShake()
	{
	}

	private void PlayCompletedAnimation()
	{
	}

	private void MoveScrollToThis()
	{
	}

	private void PrepareForIntroAnimation()
	{
	}

	private void KillIntroTween()
	{
	}

	private void KillAllTweens()
	{
	}

	private void KillIdleTween()
	{
	}

	private void RefreshSelectableIdle()
	{
	}

	private void ResetChildScalesImmediate()
	{
	}

	private void ResetHoverVisualsImmediate()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerEnterAction()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerExitAction()
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void MoveRectTransformRandomly()
	{
	}

	public void LoadRectTransformPosition(float nodeXPosition, float nodeYPosition)
	{
	}
}
