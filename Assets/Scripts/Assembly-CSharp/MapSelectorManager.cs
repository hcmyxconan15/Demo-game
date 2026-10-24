using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MapSelectorManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGenerateMapCoroutine_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapSelectorManager _003C_003E4__this;

		private UnityEngine.Random.State _003CpreviousRandomState_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGenerateMapCoroutine_003Ed__78(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CManageMapInOut_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool active;

		public MapSelectorManager _003C_003E4__this;

		public bool ignoreGamePlayUi;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CManageMapInOut_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003COpenMap_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapSelectorManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003COpenMap_003Ed__79(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScrollToCoroutine_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapSelectorManager _003C_003E4__this;

		public RectTransform target;

		public float offset;

		public float duration;

		private float _003CtargetNormalizedY_003E5__2;

		private float _003CstartNormalizedY_003E5__3;

		private float _003CelapsedTime_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CScrollToCoroutine_003Ed__77(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public bool Open;

	public bool CantSelectNode;

	public int NodeComponentCount;

	public bool EndedSelection;

	public bool FirstSelection;

	public CanvasGroup MapCanvasGroup;

	public GameObject BackButton;

	public NodeTypeComponent BossNode;

	public List<MapLevel> MapLevels;

	public List<Paths> PathsList;

	public List<NodeTypeComponent> NodeTypeComponentsSelected;

	public List<int> NodeToRandomFill;

	public GameControllers GameControllers;

	public NodeBd NodeBd;

	[Header("Scroll rect")]
	public RectTransform Viewport;

	public ScrollRect ScrollRect;

	private List<int> _startPathPositions;

	private NodeTypeComponent _nodeTypeComponentLastSelected;

	private bool _forceReset;

	private bool _generate;

	private bool _firstTimeOpen;

	private bool _useExplicitNextGenerationSeed;

	private int _explicitNextGenerationSeed;

	private int _seedForActiveGeneration;

	private Coroutine _manageMapInOut;

	private Coroutine _openMap;

	private const int MinNodeIndex = 0;

	private const int MaxNodeIndex = 6;

	private const int MaxMapLevelIndex = 10;

	private Coroutine _moveScroll;

	public int LastGeneratedMapSeed { get; private set; }

	private void Awake()
	{
	}

	public void GenerateNewMap()
	{
	}

	public void SetNextMapGenerationSeed(int seed)
	{
	}

	public void ClearNextMapGenerationSeed()
	{
	}

	public void AddFavoriteMapSeed(int seed)
	{
	}

	[ContextMenu("BookmarkLastGeneratedMapSeed")]
	public void BookmarkLastGeneratedMapSeed()
	{
	}

	public void OpenMapFromMainMenu()
	{
	}

	public void GoBackToMenu()
	{
	}

	public void ActiveMap(bool active, bool ignoreGamePlayUi = false)
	{
	}

	private void ActivateMapPanelNavigation()
	{
	}

	private void ApplyLastSelectedMapButton()
	{
	}

	[IteratorStateMachine(typeof(_003CManageMapInOut_003Ed__41))]
	private IEnumerator ManageMapInOut(bool active, bool ignoreGamePlayUi = false)
	{
		return null;
	}

	public void ForceCloseMap()
	{
	}

	private void StopMapTransitionCoroutines()
	{
	}

	public void SelectNode(NodeTypeComponent nodeTypeComponent)
	{
	}

	public void SelectNodeFromLoad(NodeTypeComponent nodeTypeComponent)
	{
	}

	private void ApplyNodeSelected(NodeTypeComponent nodeTypeComponent)
	{
	}

	private void CompleteSelectedNode(NodeTypeComponent nodeTypeComponent, bool savePath)
	{
	}

	private void MarkNodesOffPathAsPassed(NodeTypeComponent selectedNode)
	{
	}

	private static void CollectReachableUpward(NodeTypeComponent node, HashSet<NodeTypeComponent> reachableNodes)
	{
	}

	private static void MarkNodePassedIfOffPath(NodeTypeComponent node, HashSet<NodeTypeComponent> reachableNodes)
	{
	}

	private void SaveGenerateMapState()
	{
	}

	private void ResetNode()
	{
	}

	private static bool EdgesCross(int prev, int next, int otherFrom, int otherTo)
	{
		return false;
	}

	private bool WouldCrossExistingEdges(int prev, int next, int level)
	{
		return false;
	}

	private int PickNonCrossingNextIndex(int prev, int level)
	{
		return 0;
	}

	private void BuildPath(int pathIndex, int startIndex)
	{
	}

	private void CreateMapPath()
	{
	}

	private bool HasIndexSpaceCrossingEdges()
	{
		return false;
	}

	private static float Cross2D(Vector2 a, Vector2 b)
	{
		return 0f;
	}

	private static bool SegmentsProperlyIntersect(Vector2 a1, Vector2 a2, Vector2 b1, Vector2 b2)
	{
		return false;
	}

	private bool TryGetVisuallyCrossingNodes(out HashSet<NodeTypeComponent> nodesToFix)
	{
		nodesToFix = null;
		return false;
	}

	private void ResolveVisualPathCrossingsFromJitter()
	{
	}

	private void CreateFinalPath()
	{
	}

	private void RemoveRedundantInitialNodes()
	{
	}

	private void ActivePathNodes()
	{
	}

	private void RandomMoveNodesFromCenter()
	{
	}

	private void SetFirstLevelActive()
	{
	}

	private void RefreshAllActiveNodeLines()
	{
	}

	private void PlayActiveNodeIntroAnimations()
	{
	}

	private void ActiveCanvasGroup(bool active)
	{
	}

	public bool IsElementInViewport(RectTransform componentRecTransform)
	{
		return false;
	}

	public void ScrollToSmooth(RectTransform target, float duration = 0.5f, float offset = 50f)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToCoroutine_003Ed__77))]
	private IEnumerator ScrollToCoroutine(RectTransform target, float duration, float offset)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGenerateMapCoroutine_003Ed__78))]
	private IEnumerator GenerateMapCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COpenMap_003Ed__79))]
	private IEnumerator OpenMap()
	{
		return null;
	}

	private void SetNodeTypes()
	{
	}

	private void ConvertSharedLastLevelRestsToShop()
	{
	}

	private void EnsureAtLeastOneShopOnLastRestRow()
	{
	}

	private bool MapHasActiveShop()
	{
		return false;
	}

	private static List<NodeTypeComponent> GetActiveLastLevelChildren(NodeTypeComponent parent)
	{
		return null;
	}

	private static bool WouldLeaveParentWithoutRest(NodeTypeComponent pick)
	{
		return false;
	}

	private void AssignRandomNodeType(NodeTypeComponent node)
	{
	}

	private void ForceMercenaryAvoidingDuplicateSiblings(NodeTypeComponent node)
	{
	}

	private void ReplaceDuplicateMercenarySiblings()
	{
	}

	private static bool ParentHasMercenarySibling(NodeTypeComponent node)
	{
		return false;
	}

	private void ReplaceConsecutiveShops()
	{
	}

	private static List<Node.NodeType> GetOtherParentTypes(NodeTypeComponent child, NodeTypeComponent parentToConvert)
	{
		return null;
	}

	private void SetRandomEnemyEliteOrUnknown(NodeTypeComponent node)
	{
	}

	private void SetRandomEnemyEliteOrUnknown(NodeTypeComponent node, List<Node.NodeType> excludedTypes)
	{
	}

	private List<NodeTypeComponent> SelectLevelNodesAvoidingSharedBase(int level)
	{
		return null;
	}

	private static bool SharesBaseWithAny(NodeTypeComponent node, List<NodeTypeComponent> others)
	{
		return false;
	}

	private static bool NodesShareBase(NodeTypeComponent a, NodeTypeComponent b)
	{
		return false;
	}

	private int ReturnRandomNodeIndex()
	{
		return 0;
	}

	private bool NodeDontFollowRules(NodeTypeComponent node)
	{
		return false;
	}

	private bool MapLevelHasOtherUnknown(NodeTypeComponent node)
	{
		return false;
	}

	private void InjectOptionalAndSpecialNodes()
	{
	}

	private void TryInjectSpecialNode(Node nodeData, HashSet<int> usedPathIndexes)
	{
	}

	private bool TryInjectSpecialNodeOnPaths(Node nodeData, HashSet<int> usedPathIndexes, bool excludeUsedPaths)
	{
		return false;
	}

	private static bool HasEnemySiblingChoice(NodeTypeComponent node)
	{
		return false;
	}

	private void SetInputDirections()
	{
	}
}
