using System;

[Serializable]
public class Alert
{
	public string AlertId;

	public int AlertTime;

	public string AlertString;

	public AlertComponent.AlertType AlertType;
}
