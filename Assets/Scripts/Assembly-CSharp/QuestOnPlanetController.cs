using System.Collections.Generic;
using UnityEngine;

public class QuestOnPlanetController : MonoBehaviour
{
	public int QuestSelectedId;

	public RectTransform LocationMercenaryNameRectTransform;

	public Camera WorldCamera;

	public Vector3 Offset;

	public InOutFromLeft InOutFromLeft;

	[Header("Hunt list panel")]
	public QuestButton QuestButtonPrefab;

	public RectTransform QuestListParent;

	public GameObject EmptyHuntsState;

	public MenuNavigation MenuNavigation;

	[Header("Markers on planet")]
	public RectTransform MarkerSpritePrefab;

	public RectTransform MarkersParent;

	public bool _open;

	private readonly List<QuestOnPlanet> _activeQuests;

	private readonly List<QuestButton> _rowPool;

	private readonly List<RectTransform> _markerPool;

	private List<NavigableButton> _planetNavButtons;

	private bool _markersVisible;

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void OpenInfoPanel(bool open)
	{
	}

	public void ShowMarkers(int planetId, PlanetQuestMarkers questMarkers)
	{
	}

	public void HideMarkers()
	{
	}

	public void SetToSelectedLocation(int id)
	{
	}

	public void SelectQuest(int questIndex)
	{
	}

	public bool HasSelectableQuest()
	{
		return false;
	}

	private bool IsHuntFocused()
	{
		return false;
	}

	private void StartSelectedQuest()
	{
	}

	private void BuildQuestList(int planetId, PlanetQuestMarkers questMarkers)
	{
	}

	private void SetHuntsNavigation()
	{
	}

	private void CachePlanetNavigationButtons()
	{
	}

	private void RestorePlanetNavigationButtons()
	{
	}

	private void HideSurplusRowsAndMarkers(int visibleCount)
	{
	}

	private int GetInitialSelection(int planetId)
	{
		return 0;
	}

	private QuestButton GetPooledRow()
	{
		return null;
	}

	private RectTransform GetPooledMarker()
	{
		return null;
	}

	private void HideQuestOnPlanets()
	{
	}
}
