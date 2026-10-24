using UnityEngine;

[CreateAssetMenu(fileName = "InitialDataConfig", menuName = "GameData/new Initial Data Config")]
public class InitialDataConfig : ScriptableObject
{
	public DataUser Data;

	public ContentAvailabilitySnapshot Availability;
}
