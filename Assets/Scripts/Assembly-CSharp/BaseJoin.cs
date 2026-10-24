using System.Collections.Generic;
using UnityEngine;

public class BaseJoin : MonoBehaviour
{
	public MechPlayerController MechPlayerController;

	public Transform BaseTransform;

	public List<Renderer> Renderers;

	public Animator BaseAnimator;

	public AnimatorController AnimatorController;

	public bool UseMoveOffsetOnMaterial;

	public MoveOffsetOnMaterial MoveOffsetOnMaterial;

	private void Update()
	{
	}
}
