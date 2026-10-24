using UnityEngine;

[ExecuteInEditMode]
public class LightSource : MonoBehaviour
{
	private GameObject Celestial;

	private GameObject Planet;

	private GameObject Atmosphere;

	private GameObject Rings;

	private Transform IlluminationSource;

	private MaterialPropertyBlock _propBlockPlanet;

	private MaterialPropertyBlock _propBlockAtmosphere;

	private MaterialPropertyBlock _propBlockRings;

	private Renderer PlanetM;

	private Renderer RingsM;

	private Renderer AtmosphereM;

	public GameObject Sun;

	public void Start()
	{
	}

	public void Update()
	{
	}
}
