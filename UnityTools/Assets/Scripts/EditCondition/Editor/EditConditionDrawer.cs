using UnityEditor;
using UnityEngine;
using System.Reflection;

[CustomPropertyDrawer(typeof(EditCondition))]
public class EditConditionDrawer : PropertyDrawer
{
	private bool editCondition = false;
	
	public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
	{
		SerializedObject _target = _property.serializedObject;
		
		FieldInfo _propertyField = _target.targetObject.GetType().GetField(_property.name, BindingFlags.Instance | BindingFlags.NonPublic);
		if (_propertyField == null)
		{
			Debug.LogError("[EditCondition] Property field not found");
			return;
		}
		
		EditCondition _editCondition = _propertyField.GetCustomAttribute<EditCondition>();
		if (_editCondition == null)
		{
			Debug.LogError("[EditCondition] Attribute \"EditCondition\" not found");
			return;
		}

		string _attributeName = _editCondition.editCondition;
		if (string.IsNullOrEmpty(_attributeName))
		{
			Debug.LogError("[EditCondition] editCondition value is null or empty");
			return;
		}
		
		SerializedProperty _editConditionProperty = _target.FindProperty(_attributeName);
		if (_editConditionProperty == null)
		{
			Debug.LogError($"[EditCondition] Property \"{_attributeName}\" not found");
			return;
		}

		if (!(editCondition = _editConditionProperty.boolValue)) return;
		EditorGUI.PropertyField(_position, _property, _label, true);
	}

	public override float GetPropertyHeight(SerializedProperty _property, GUIContent _label)
	{
		return editCondition ? EditorGUI.GetPropertyHeight(_property, _label, true) : 0.0f;
	}
}
