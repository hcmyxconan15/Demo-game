using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Outline : MonoBehaviour
{
	public enum Mode
	{
		OutlineAll = 0,
		OutlineVisible = 1,
		OutlineHidden = 2,
		OutlineAndSilhouette = 3,
		SilhouetteOnly = 4
	}

	[Serializable]
	private class ListVector3
	{
		public List<Vector3> data;
	}

	private static HashSet<Mesh> registeredMeshes;

	[SerializeField]
	private Mode outlineMode;

	[SerializeField]
	private Color outlineColor;

	[SerializeField]
	[Range(0f, 10f)]
	private float outlineWidth;

	[Header("Optional")]
	[SerializeField]
	[Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
	private bool precomputeOutline;

	[SerializeField]
	[HideInInspector]
	private List<Mesh> bakeKeys;

	[SerializeField]
	[HideInInspector]
	private List<ListVector3> bakeValues;

	private List<Renderer> renderers;

	private Material outlineMaskMaterial;

	private Material outlineFillMaterial;

	private bool needsUpdate;

	public Mode OutlineMode
	{
		get
		{
			return Mode.OutlineAll;
		}
		set
		{
		}
	}

	public Color OutlineColor
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public float OutlineWidth
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void AddRenderers(params Renderer[] newRenderers)
	{
	}

	public void AddRenderers(IEnumerable<Renderer> newRenderers)
	{
	}

	public void AddRenderersFrom(Component root, bool includeInactive = true)
	{
	}

	public void AddRenderersFrom(params Renderer[] newRenderers)
	{
	}

	public void AddRenderersFrom(GameObject root, bool includeInactive = true)
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private static bool ShouldOutline(Renderer renderer)
	{
		return false;
	}

	private void Bake()
	{
	}

	private void LoadSmoothNormals()
	{
	}

	private void PrepareRendererMeshes(Renderer renderer)
	{
	}

	private void PrepareMeshFilter(MeshFilter meshFilter, Renderer renderer)
	{
	}

	private void PrepareSkinnedMesh(SkinnedMeshRenderer skinnedMeshRenderer)
	{
	}

	private void ApplyOutlineMaterials(Renderer renderer)
	{
	}

	private void RemoveOutlineMaterials(Renderer renderer)
	{
	}

	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	private void CombineSubmeshes(Mesh mesh, Material[] materials)
	{
	}

	private void UpdateMaterialProperties()
	{
	}
}
