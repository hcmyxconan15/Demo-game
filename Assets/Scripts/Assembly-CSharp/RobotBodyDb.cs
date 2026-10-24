using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New body part DB", menuName = "GameData/Body/new body db")]
public class RobotBodyDb : ScriptableObject
{
	public List<BodyType> BodyTypes;

	public Color ColorPlus;

	public BodyType GetBody(int bodyId)
	{
		return null;
	}

	public string GetLevelGrowthInfoText(BodyType body, int appliedTimes, bool showProgress, bool lineJump)
	{
		return null;
	}

	private void OnValidate()
	{
	}
}
