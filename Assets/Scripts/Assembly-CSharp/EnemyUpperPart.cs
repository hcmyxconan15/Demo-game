using System.Collections.Generic;
using UnityEngine;

public class EnemyUpperPart : MonoBehaviour
{
	public List<Renderer> Renderer;

	public EnemyRobotAttackController EnemyRobotAttackController;

	public DisablePartsOnDead DisablePartsOnDead;

	[ContextMenu("Collect Renderers")]
	public void CollectRenderers()
	{
	}
}
