using UnityEngine;

public class PushBackEffect : MonoBehaviour, IActiveEffectTick
{
	public bool CantBePush;

	public float PushTime;

	public float PushForce;

	private bool _isPushing;

	private float _pushStartTime;

	private Vector3 _pushDirection;

	public void PushEnemy(Transform position, float pushForce)
	{
	}

	private void OnDisable()
	{
	}

	public void TickActiveEffect(float deltaTime)
	{
	}
}
