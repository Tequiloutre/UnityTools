using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field), Serializable]
public class EditCondition : PropertyAttribute
{
	public string editCondition { get; }

	public EditCondition(string _editCondition)
	{
		editCondition = _editCondition;
	}
}
