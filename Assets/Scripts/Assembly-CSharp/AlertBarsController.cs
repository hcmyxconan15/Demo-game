using System.Collections.Generic;
using UnityEngine;

public class AlertBarsController : MonoBehaviour
{
	public List<BarsAlerts> BarsAlerts;

	public List<BarsAlertComponent> BarsAlertComponentOnMap;

	public GameObject SimpleDamageAlertPrefab;

	public List<GameObject> SimpleDamageAlert;

	public Transform BarsParentTransform;

	public void ShowDamageAlert(Transform transformPosition)
	{
	}

	public BarsAlertComponent ShowAlertBar(Transform transformPosition, int id)
	{
		return null;
	}

	public BarsAlertComponent ShowAlertBar(Vector3 transformPosition, int id)
	{
		return null;
	}

	public BarsAlertComponent ShowAlertBar(Vector3 position, Transform transformDirection, int id)
	{
		return null;
	}
}
