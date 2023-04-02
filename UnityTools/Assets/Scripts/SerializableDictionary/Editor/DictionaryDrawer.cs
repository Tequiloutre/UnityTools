using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(SDictionary<,>))]
public class DictionaryDrawer : PropertyDrawer
{
	public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
	{
		EditorGUI.BeginProperty(position, label, property);
		EditorGUI.PropertyField(position, property.FindPropertyRelative("content"), label);
		EditorGUI.EndProperty();
	}

	public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("content"));
	}
}
