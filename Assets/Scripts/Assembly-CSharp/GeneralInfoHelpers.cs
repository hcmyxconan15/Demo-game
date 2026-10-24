using UnityEngine;

public class GeneralInfoHelpers : MonoBehaviour
{
	public static GeneralInfoHelpers Instance;

	public InfoHelper InfoHelper;

	public InfoHelperSimple InfoHelperSimple;

	private void Awake()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}
}
