using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New base DB", menuName = "GameData/Base/new base db")]
public class RobotBaseDb : ScriptableObject
{
	public List<BaseType> BaseTypes;

	public Color ColorPlus;

	public BaseType GetBase(int baseId)
	{
		return null;
	}

	public string GetLevelGrowthInfoText(BaseType baseType, int appliedTimes, bool showProgress, bool lineJump)
	{
		return null;
	}

	private void OnValidate()
	{
	}
}
