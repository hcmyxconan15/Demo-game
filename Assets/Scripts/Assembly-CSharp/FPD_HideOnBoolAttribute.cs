using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field, Inherited = true)]
public class FPD_HideOnBoolAttribute : PropertyAttribute
{
	public string BoolVarName;

	public bool HideInInspector;

	public FPD_HideOnBoolAttribute(string boolVariableName)
	{
	}

	public FPD_HideOnBoolAttribute(string conditionalSourceField, bool hideInInspector)
	{
	}
}
